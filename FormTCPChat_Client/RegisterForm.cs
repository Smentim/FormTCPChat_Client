using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTCPChat_Client
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            login_reg_box.Text = "test";
            login_reg_box.ForeColor = Color.Gray;
            password_reg_box.Text = "password";
            password_reg_box.ForeColor = Color.Gray;
            password_reg_retry_box.Text = "password";
            password_reg_retry_box.ForeColor = Color.Gray;
            num_pc_box.Text = "pc_00";
            num_pc_box.ForeColor = Color.Gray;
        }

        private void login_reg_box_Enter(object sender, EventArgs e)
        {
            if (login_reg_box.Text == "test")
            {
                login_reg_box.Text = "";
                login_reg_box.ForeColor = Color.Black;
            }
        }

        private void login_reg_box_Leave(object sender, EventArgs e)
        {
            if (login_reg_box.Text == "")
            {
                login_reg_box.Text = "test";
                login_reg_box.ForeColor = Color.Gray;
            }
        }

        private void password_reg_box_Enter(object sender, EventArgs e)
        {
            if (password_reg_box.Text == "password")
            {
                password_reg_box.Text = "";
                password_reg_box.ForeColor = Color.Black;
            }
        }

        private void password_reg_box_Leave(object sender, EventArgs e)
        {
            if (password_reg_box.Text == "")
            {
                password_reg_box.Text = "password";
                password_reg_box.ForeColor = Color.Gray;
            }
        }

        private void password_reg_retry_box_Enter(object sender, EventArgs e)
        {
            if (password_reg_retry_box.Text == "password")
            {
                password_reg_retry_box.Text = "";
                password_reg_retry_box.ForeColor = Color.Black;
            }
        }

        private void password_reg_retry_box_Leave(object sender, EventArgs e)
        {
            if (password_reg_retry_box.Text == "")
            {
                password_reg_retry_box.Text = "password";
                password_reg_retry_box.ForeColor = Color.Gray;
            }
        }

        private void num_pc_box_Enter(object sender, EventArgs e)
        {
            if (num_pc_box.Text == "pc_00")
            {
                num_pc_box.Text = "";
                num_pc_box.ForeColor = Color.Black;
            }
        }

        private void num_pc_box_Leave(object sender, EventArgs e)
        {
            if (num_pc_box.Text == "")
            {
                num_pc_box.Text = "pc_00";
                num_pc_box.ForeColor = Color.Gray;
            }
        }

        private void button_auth_Click(object sender, EventArgs e)
        {
            if (login_reg_box.Text == "test")
            {
                MessageBox.Show("Введите имя");
                return;
            }

            if (num_pc_box.Text == "pc_00")
            {
                MessageBox.Show("Введите номер, указанный на блоке или мониторе вашего компьютера");
                return;
            }

            if (password_reg_box.Text == "password")
            {
                MessageBox.Show("Введите пароль");
                return;
            }

            if (password_reg_retry_box.Text == "password")
            {
                MessageBox.Show("Введите пароль повторно в поле 'Подтвердите пароль'");
                return;
            }

            if (password_reg_retry_box.Text != password_reg_box.Text)
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }

            string login = login_reg_box.Text;
            string password = password_reg_box.Text;
            string numpc = num_pc_box.Text;
            dbGet dbget = new dbGet();

            if (dbget.dbExist(login))
                return;

            dbget.dbReg(login, password, numpc);
        }

        private void check_show_password_CheckedChanged(object sender, EventArgs e)
        {
            if (check_show_password.Checked == true)
            {
                password_reg_box.UseSystemPasswordChar = false;
                password_reg_retry_box.UseSystemPasswordChar = false;
            }
            else
            {
                password_reg_box.UseSystemPasswordChar = true;
                password_reg_retry_box.UseSystemPasswordChar = true;
            }
        }

        private void alr_register_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginform = new LoginForm();
            loginform.ShowDialog();
        }

        private void alr_register_MouseHover(object sender, EventArgs e)
        {
            alr_register.Font = new Font("Verdana", 11, FontStyle.Regular);
            alr_register.Location = new Point(13, 355);
        }

        private void alr_register_MouseLeave(object sender, EventArgs e)
        {
            alr_register.Font = new Font("Verdana", 10, FontStyle.Regular);
            alr_register.Location = new Point(23, 355);
        }
    }
}
