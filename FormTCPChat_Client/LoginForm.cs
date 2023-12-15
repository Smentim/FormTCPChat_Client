using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;

namespace FormTCPChat_Client
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void check_show_password_CheckedChanged(object sender, EventArgs e)
        {
            if (check_show_password.Checked == true)
            {
                password_box.UseSystemPasswordChar = false;
            }
            else
            {
                password_box.UseSystemPasswordChar = true;
            }
        }

        public void button_auth_Click(object sender, EventArgs e)
        {
            if (login_box.Text == "")
            {
                MessageBox.Show("Введите ваш логин");
                return;
            }
                
            if (password_box.Text == "")
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            
            String loginUser = login_box.Text;
            String passUser = password_box.Text;
            String numPC = "123";
            String typeUser = "123";

            dbGet dbget = new dbGet();

            dbget.dbCheck(loginUser, passUser, numPC, typeUser);
        }

        private void yet_register_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerform = new RegisterForm();
            registerform.ShowDialog();
        }

        private void yet_register_MouseHover(object sender, EventArgs e)
        {
            yet_register.Font = new Font("Verdana", 11, FontStyle.Regular);
            yet_register.Location = new Point(10, 214);
        }

        private void yet_register_MouseLeave(object sender, EventArgs e)
        {
            yet_register.Font = new Font("Verdana", 10, FontStyle.Regular);
            yet_register.Location = new Point(20, 214);
        }
    }
}
