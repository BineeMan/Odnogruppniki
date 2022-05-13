using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static Odnogruppniki.Classes.UserQueries;
using Odnogruppniki.Classes;

namespace Odnogruppniki.Forms
{
    public partial class RegistrationForm : ClassFormStyle.ParentForm
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationButton_Click_1(object sender, EventArgs e)
        {
            User.Login = textBox_login.Text;
            User.Password = textBox_passwd1.Text;
            if (textBox_passwd1.Text == textBox_passwd2.Text)
                AddUser();
            else
                MessageBox.Show("Пароли не совпадают");
        }
    }
}
