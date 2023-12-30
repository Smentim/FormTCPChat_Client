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
using System.IO;
using System.Net;

namespace FormTCPChat_Client
{
    public partial class TehChat : Form
    {
        private TSettings tsettings;

        public TehChat(string name, string namepc, string typeuser)
        {
            InitializeComponent();
            tsettings = new TSettings("ConnectSettings.txt");
            FormData.loggin = $"{ namepc} | { name} ({ typeuser})";
        }


        public TSettings FormData
        {
            get { return tsettings; }
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
            listBox1.Items.Add($"Добро пожаловать, {FormData.loggin}");
            try
            {
                FormData.client.Connect(tsettings.GetHost(), tsettings.GetPort());
                FormData.Reader = new StreamReader(FormData.client.GetStream());
                FormData.Writer = new StreamWriter(FormData.client.GetStream());
                if (FormData.Reader is null || FormData.Writer is null) return;
                await FormData.Writer.WriteLineAsync(FormData.loggin.ToString());
                await FormData.Writer.FlushAsync();
            }
            catch (Exception ex)
            {
                listBox1.Items.Add(ex.Message);
            }
        }

        public async void button_auth_Click(object sender, EventArgs e)
        {
            Task.Run(() => ReceiveMessageAsync(FormData.Reader));
            await SendMessageAsync(FormData.Writer);
            send_mess_box.Text = "";
        }

        async Task SendMessageAsync(StreamWriter writer)
        {
            if (FormData.send_check == true)
            {
                string? message = send_mess_box.Text;
                await writer.WriteLineAsync(message);
                await writer.FlushAsync();
                listBox1.Items.Add($"{FormData.loggin} : {message}");
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
