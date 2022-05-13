using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Odnogruppniki.strCon;
using static Odnogruppniki.Classes.User;

namespace Odnogruppniki.Classes
{
    class UserQueries
    {
        public static void GetUserByLogin(string Login)
        {
            string SqlExpession = "SELECT* FROM [Odnogruppniki].[User] WHERE Login = @login";
            string login = Login;
            using (SqlConnection conn = new SqlConnection(STR_CONN))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(SqlExpession, conn);
                comm.Parameters.AddWithValue("login", login);
                SqlDataReader rd = comm.ExecuteReader();
                rd.Read();
                User.IdUser = (int)rd["ID"];
                User.Login = rd["Login"].ToString();
                User.Password = rd["Password"].ToString();
                User.IdState = (int)rd["ID State"];
            }
        }

        public static void AddUser()
        {
            string SqlExpession = "INSERT INTO [Odnogruppniki].[User] ([Login], [Password]) VALUES (@login, @password)";
            using (SqlConnection conn = new SqlConnection(STR_CONN))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(SqlExpession, conn);
                comm.Parameters.AddWithValue("login", User.Login);
                comm.Parameters.AddWithValue("password", User.Password);
                try
                {
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Вы успешно зарегестрированы");
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
            }
        }

        public static void UpdateUserStates(int idstate)
        {
            string SqlExpession = "UPDATE Odnogruppniki.[User] " +
                "SET [Last Activity Date] = GETDATE(), [ID State] = @idstate " +
                "WHERE ID = @id";
            using (SqlConnection conn = new SqlConnection(STR_CONN))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(SqlExpession, conn);
                comm.Parameters.AddWithValue("idstate", idstate);
                comm.Parameters.AddWithValue("id", User.IdUser);
                try
                {
                    comm.ExecuteNonQuery();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
            }
        }
    }

}