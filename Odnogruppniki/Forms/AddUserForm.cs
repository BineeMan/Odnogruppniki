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
using Odnogruppniki.Classes;

namespace Odnogruppniki.Forms
{
    public partial class AddUserForm : ClassFormStyle.ParentForm
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        int SelectedUserId = -1;

        private void FindUsers()
        {
            string Login = textBox_Login.Text;
            string SqlExpression = "SELECT [ID], [Login] " +
                "FROM Odnogruppniki.[User] " +
                "LEFT JOIN Odnogruppniki.[Chat Members] " +
                "ON Odnogruppniki.[User].[ID] = Odnogruppniki.[Chat Members].[ID Member] " +
                "WHERE [Login] LIKE '%"+ Login + "%' AND ( [ID Group Chat] IS NULL OR[ID Group Chat] NOT IN(" +
                                                                        "SELECT DISTINCT [ID Group Chat] " +
                                                                        "FROM Odnogruppniki.[Chat Members] " +
                                                                        "WHERE [ID Member] = "+ User.IdUser +") )";
            using (SqlConnection conn = new SqlConnection(STR_CONN))
            {
                conn.Open();
                SqlDataAdapter DataAdapter = new SqlDataAdapter(SqlExpression, conn);
                DataSet DataSet = new DataSet();
                DataAdapter.Fill(DataSet);
                dataGridView_UserList.DataSource = DataSet.Tables[0];
            }
            this.dataGridView_UserList.Columns["ID"].Visible = false;
        }

        private void AddUserToFriendList()
        {
            string SqlExpression1 = "INSERT INTO Odnogruppniki.Chat ([ID Creator], [Chat Name], [ID Chat Type], [Messages Amount]) " +
                "OUTPUT Inserted.[ID Group Chat]" +
                " VALUES(@UserID, '', 1, 0)";

            string SqlExpression2 = "INSERT INTO Odnogruppniki.[Chat Members] " +
                "([ID Member], [ID Group Chat]) " +
                "VALUES(@SelectedID, @NewChatID)";

            string SqlExpression3 = "INSERT INTO Odnogruppniki.[Chat Members] " +
                "([ID Member], [ID Group Chat]) " +
                "VALUES(@UserId, @NewChatID)";

            int NewChatID = 0;

            using (SqlConnection conn = new SqlConnection(STR_CONN))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(SqlExpression1, conn);
                comm.Parameters.AddWithValue("UserID", User.IdUser);
                SqlDataReader DataReader = comm.ExecuteReader();
                DataReader.Read();
                NewChatID = (int)DataReader["ID Group Chat"];
            }

            using (SqlConnection conn = new SqlConnection(STR_CONN))
            {
                conn.Open();
                SqlCommand comm1 = new SqlCommand(SqlExpression2, conn);
                SqlCommand comm2 = new SqlCommand(SqlExpression3, conn);

                comm1.Parameters.AddWithValue("SelectedID", SelectedUserId);
                comm1.Parameters.AddWithValue("NewChatID", NewChatID);

                comm2.Parameters.AddWithValue("UserId", User.IdUser);
                comm2.Parameters.AddWithValue("NewChatID", NewChatID);

                try
                {
                    comm1.ExecuteNonQuery();
                    comm2.ExecuteNonQuery();
                    MessageBox.Show("Новый пользователь добавлен!");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void button_Write_Click(object sender, EventArgs e)
        {
            if (SelectedUserId > 0)
                AddUserToFriendList();
            else
                MessageBox.Show("Пользователь не выбран!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FindUsers();
        }

        private void dataGridView_UserList_SelectionChanged(object sender, EventArgs e)
        {
            SelectedUserId = (int)dataGridView_UserList.CurrentRow.Cells[0].Value;
            //MessageBox.Show(SelectedUserId.ToString());
        }
    }
}
