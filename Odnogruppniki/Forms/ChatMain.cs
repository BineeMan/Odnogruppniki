using Odnogruppniki.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static Odnogruppniki.strCon;
using static Odnogruppniki.Classes.User;

namespace Odnogruppniki
{
    public partial class ChatMain : ClassFormStyle.ParentForm
    {
        public ChatMain()
        {
            InitializeComponent();
        }

        private int GroupChatId = 0;

        private int IdLastMessage = 0;

        private int CurrentMessagesAmount = 0;

        private void LoadChats()
        {
            string SqlExpression = "SELECT Chat.[ID Group Chat], [Chat Name] FROM Odnogruppniki.[User] " +
                "JOIN Odnogruppniki.[Chat Members] " +
                "ON Odnogruppniki.[User].[ID] = Odnogruppniki.[Chat Members].[ID Member] " +
                "JOIN Odnogruppniki.Chat ON Odnogruppniki.[Chat Members].[ID Group Chat] = Odnogruppniki.Chat.[ID Group Chat] " +
                "WHERE[User].ID = " + User.IdUser;
            using (SqlConnection conn = new SqlConnection(STR_CONN))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(SqlExpression, conn);
                SqlDataAdapter ada = new SqlDataAdapter(SqlExpression, conn);
                DataSet ds = new DataSet();
                ada.Fill(ds);
                dataGridView_ChatList.DataSource = ds.Tables[0];
            }
            this.dataGridView_ChatList.Columns["ID Group Chat"].Visible = false;
        }

        private void AppendMessages()
        {
            string SqlExpression = "SELECT [ID Message], [ID], [Login], [Message]" +
                " FROM Odnogruppniki.[Chat Messages]" +
                " JOIN Odnogruppniki.[User] ON Odnogruppniki.[User].ID = Odnogruppniki.[Chat Messages].[ID Sender]" +
                " WHERE[ID Group Chat] = " + GroupChatId;
            using (SqlConnection conn = new SqlConnection(STR_CONN))
            {
                conn.Open();
                SqlCommand command1 = new SqlCommand(SqlExpression, conn);
                SqlDataReader dataReader = command1.ExecuteReader();
                int NewIdLastMessage = 0;
                while (dataReader.Read())
                {
                    
                    NewIdLastMessage = (int)dataReader["ID Message"];
                    if (NewIdLastMessage > IdLastMessage)
                    {
                        string NewLine = Environment.NewLine;
                        textBox_ChatWindow.AppendText(dataReader["Login"] + NewLine + dataReader["Message"]);
                        textBox_ChatWindow.AppendText(NewLine + NewLine);
                    }

                }
                IdLastMessage = NewIdLastMessage;
            }
        }

        private void SendMessage()
        {
            const string SqlExpression = "INSERT INTO Odnogruppniki.[Chat Messages] ([ID Sender], [ID Group Chat], [Message], [Message Time]) " +
                "VALUES(@IdSender, @IdGroupChat, @Message, @MessageTime)";
            string DT = DateTime.UtcNow.ToString();
            string message = textBox_Message.Text.ToString();

            using (SqlConnection conn = new SqlConnection(STR_CONN))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(SqlExpression, conn);
                comm.Parameters.AddWithValue("IdSender", User.IdUser);
                comm.Parameters.AddWithValue("IdGroupChat", GroupChatId);
                comm.Parameters.AddWithValue("Message", message);
                comm.Parameters.AddWithValue("MessageTime", DT);
                try
                {
                    comm.ExecuteNonQuery();
                    IncrementMessageAmount();
                    CurrentMessagesAmount = GetNewMessagesAmount();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void ChatMain_Load(object sender, EventArgs e)
        {
            LoadChats();
            label2.Text = CurrentMessagesAmount.ToString();
        }

        private void dataGridView_ChatList_SelectionChanged(object sender, EventArgs e)
        {
            GroupChatId = (int)dataGridView_ChatList.CurrentRow.Cells[0].Value;
            IdLastMessage = 0;
            textBox_ChatWindow.Clear();
            AppendMessages();
            label3.Text = GroupChatId.ToString();
            CurrentMessagesAmount = GetNewMessagesAmount();
            label2.Text = CurrentMessagesAmount.ToString();
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            SendMessage();
            AppendMessages();
            label2.Text = CurrentMessagesAmount.ToString();
            textBox_Message.Clear();
        }

        private int GetNewMessagesAmount()
        {
            string SqlExpression = "SELECT [Messages Amount] " +
                "FROM Odnogruppniki.Chat" +
                " WHERE [ID Group Chat] = " + GroupChatId;
            int NewMessagesAmount;
            using (SqlConnection conn = new SqlConnection(STR_CONN))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(SqlExpression, conn);
                SqlDataReader rd = comm.ExecuteReader();
                rd.Read();
                NewMessagesAmount = (int)rd["Messages Amount"];
            }
            return NewMessagesAmount;
        } //этот метод вовращает количество сообщений в текущем чате

        private void IncrementMessageAmount()
        {
            string SqlExpression = "UPDATE Odnogruppniki.Chat " +
                "SET [Messages Amount] = (SELECT[Messages Amount] FROM Odnogruppniki.Chat WHERE[ID Group Chat] = @id) + 1 " +
                "WHERE [ID Group Chat] = @id";
            MessageBox.Show(GroupChatId.ToString());
            using (SqlConnection conn = new SqlConnection(STR_CONN))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(SqlExpression, conn);
                comm.Parameters.AddWithValue("id", GroupChatId);
                try
                {
                    comm.ExecuteNonQuery();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        } //этот метод инкрементирует количество сообщений в текущем чате. Нужен только при отправке нового сообщения

        private void CheckNewMessagesAmount() //этот метод запускает метод LoadMessages(GroupChatId), если имеются новые сообщения. Нужен только в таймере
        {
            int NewMessagesAmount = GetNewMessagesAmount();
            if (CurrentMessagesAmount < NewMessagesAmount)
            {
                CurrentMessagesAmount = NewMessagesAmount;
                AppendMessages();
                label2.Text = CurrentMessagesAmount.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CheckNewMessagesAmount();
            label2.Text = CurrentMessagesAmount.ToString();
        }

        private void LoadLoginCompanion()
        {
            string SqlExpression = "SELECT Chat.[ID Group Chat], [ID Chat Type], [Chat Name] " +
                "FROM Odnogruppniki.Chat" +
                " WHERE Chat.[ID Group Chat] = " + GroupChatId;
            string ChatName = "";
            int ChatType = 1;
            using (SqlConnection conn = new SqlConnection(STR_CONN))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(SqlExpression, conn);
                SqlDataReader DataReader = command.ExecuteReader();
                while (DataReader.Read())
                {
                    ChatName = DataReader["Chat Name"].ToString();
                    ChatType = (int)DataReader["ID Chat Type"];
                }
            }
            if (ChatType == 2)
                return ChatName; 
            else
            {
                string LoginCompanion = "";
                SqlExpression = "SELECT [ID Member], [Login], [ID Group Chat] " +
                    "FROM Odnogruppniki.[Chat Members] " +
                    "JOIN Odnogruppniki.[User] " +
                    "ON Odnogruppniki.[User].[ID] = Odnogruppniki.[Chat Members].[ID Member] " +
                    "WHERE[ID Group Chat] = " + GroupChatId;
                using (SqlConnection conn = new SqlConnection(STR_CONN))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(SqlExpression, conn);
                    SqlDataReader DataReader = command.ExecuteReader();
                    while (DataReader.Read())
                    {
                        LoginCompanion = DataReader["Login"].ToString();
                        if (!LoginCompanion.Equals(User.Login))
                        {
                            return LoginCompanion;
                        }
                    }
                }
            }
            return "Error! Chat name do not exist!";
        }
    }
}
