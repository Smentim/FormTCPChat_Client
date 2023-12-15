using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using SimpleTCP;
using System.Xml.Linq;

namespace FormTCPChat_Client
{
    public partial class TehChat : Form
    {
        string loggin;
        string host = "127.0.0.1";
        int port = 8888;
        bool send_check = true;
        TcpClient client = new TcpClient();
        StreamReader? Reader = null;
        StreamWriter? Writer = null;

        public TehChat(string name, string namepc, string typeuser)
        {
            InitializeComponent();
            loggin = $"{ namepc} | { name} ({ typeuser})";
        }

        private void TehChat_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginform = new LoginForm();
            loginform.ShowDialog();
        }

        public async void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add($"Добро пожаловать, {loggin}");
            try
            {
                client.Connect(host, port);
                Reader = new StreamReader(client.GetStream());
                Writer = new StreamWriter(client.GetStream());
                if (Reader is null || Writer is null) return;
                await Writer.WriteLineAsync(loggin.ToString());
                await Writer.FlushAsync();
            }
            catch (Exception ex)
            {
                listBox1.Items.Add(ex.Message);
            }
        }

        public async void button_auth_Click(object sender, EventArgs e)
        {
            Task.Run(() => ReceiveMessageAsync(Reader));
            await SendMessageAsync(Writer);
            send_mess_box.Text = "";
        }

        async Task SendMessageAsync(StreamWriter writer)
        {
            if (send_check == true)
            {
                string? message = send_mess_box.Text;
                await writer.WriteLineAsync(message);
                await writer.FlushAsync();
                listBox1.Items.Add($"{loggin} : {message}");
            }
        }


        async Task ReceiveMessageAsync(StreamReader reader)
        {
            while (true)
            {
                try
                {
                    // считываем ответ в виде строки
                    string? message = await reader.ReadLineAsync();
                    // если пустой ответ, ничего не выводим на консоль
                    if (string.IsNullOrEmpty(message)) continue;
                    listBox1.Items.Add($"{message}");//вывод сообщения
                }
                catch
                {
                    break;
                }
            }
        }
    }
}
