using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using static Odnogruppniki.strCon;
using System.Security.Cryptography;
using System.Linq;
using Odnogruppniki.Classes;
using static Odnogruppniki.Classes.UserQueries;

namespace Odnogruppniki
{
    public partial class LogIn : ClassFormStyle.ParentForm
    {
        User user = new User();
        public LogIn()
        {
            InitializeComponent();
        }

        private bool IfUserExists(User User)
        {
            string SqlExpression = "SELECT * FROM [Odnogruppniki].[User] WHERE [Login] = @login AND [Password] = @password";
            string login = textBox_login.Text;

            //string salt1 = "9io&"; string salt2 = "^tyG";
            //string password = salt1 + textBox_passwd1.Text + salt2;
            //password = GetHash(password);  // ХЕШИРОВАНИЕ ПАРОЛЯ
            string password = textBox_passwd1.Text;
            using (SqlConnection conn = new SqlConnection(STR_CONN))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(SqlExpression, conn);
                comm.Parameters.AddWithValue("login", login);
                comm.Parameters.AddWithValue("password", password);
                SqlDataReader rd = comm.ExecuteReader();
                rd.Read();
                if (rd.HasRows == true)
                {
                    return true;
                }
                else
                    return false;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IfUserExists(user))
            {
                GetUserByLogin(textBox_login.Text);
                UpdateUserStates(1);
                ChatMain chat_frm = new ChatMain();
                this.Hide();
                chat_frm.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Пользователь не найден");
        }
        public static string GetHash(string password)
        {  // шифрование
            using (var hash = SHA256.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.
                      GetBytes(password)).
                             Select(x => x.ToString("X2")));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Forms.RegistrationForm frm_reg = new Forms.RegistrationForm();
            frm_reg.Show();
        }

        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateUserStates(2);
        }
    }
}
