using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Org.BouncyCastle.Asn1.Utilities;
using System.Data;

namespace FormTCPChat_Client
{
    internal class DB
    {
        MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);


        public void openConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
    
    internal class dbGet
    {
        public void dbCheck(string login, string password, string namepc, string typeuser)
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `databased` WHERE `login` = @uL AND `password` = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                db.openConnection();
                MySqlCommand getInfo = new MySqlCommand("SELECT * FROM `databased` WHERE `login` = @logUser ORDER BY login", db.getConnection());
                getInfo.Parameters.Add("@logUser", MySqlDbType.VarChar).Value = login;
                MySqlDataReader reader = getInfo.ExecuteReader();
                while (reader.Read())
                {
                    login = reader.GetString("login");
                    password = reader.GetString("password");
                    namepc = reader.GetString("numpc");
                    typeuser = reader.GetString("type");
                }
                db.closeConnection();
                MessageBox.Show("Пользователь авторизован");
                LoginForm loginForm = new LoginForm();
                loginForm.Close();
                TehChat tehchat = new TehChat(login, namepc, typeuser);
                tehchat.ShowDialog();
            }
            else
                MessageBox.Show("Логин или пароль введены неправильно. Либо такого пользователя не существует");
        }

        public void dbReg(string login, string password, string numpc)
        {
            DB dB = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `databased` (`login`, `password`, `numpc`, `type`) VALUES (@reg_log, @reg_pass, @num_pc, 'user')", dB.getConnection());

            command.Parameters.Add("@reg_log", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@reg_pass", MySqlDbType.VarChar).Value = password;
            command.Parameters.Add("@num_pc", MySqlDbType.VarChar).Value = numpc;

            dB.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт зарегистрирован");
                RegisterForm registerForm = new RegisterForm();
                registerForm.Hide();
                LoginForm loginform = new LoginForm();
                loginform.ShowDialog();
            }
            else
                MessageBox.Show("Аккаунт не зарегистрирован, проверьте поля");

            dB.closeConnection();
        }

        public Boolean dbExist(string login)
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `databased` WHERE `login` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже существует. Введите другой");
                return true;
            }
            else
                return false;
        }
    }
}
