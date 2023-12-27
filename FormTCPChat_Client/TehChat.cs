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
        private Dictionary<string, string> settings;

        public TehChat(string name, string namepc, string typeuser)
        {
            InitializeComponent();
            LoadSettingsFromFile();
            tsettings = new TSettings();
            FormData.loggin = $"{ namepc} | { name} ({ typeuser})";
        }

        private void LoadSettingsFromFile()
        {
            // Путь к текстовому файлу
            string filePath = "ConnectSettings.txt";

            // Чтение данных из файла в словарь
            settings = ReadSettingsFromFile(filePath);
        }

        public TSettings FormData
        {
            get { return tsettings; }
        }

        static Dictionary<string, string> ReadSettingsFromFile(string filePath)
        {
            Dictionary<string, string> settings = new Dictionary<string, string>();

            try
            {
                // Чтение строк из файла
                string[] lines = File.ReadAllLines(filePath);

                // Обработка каждой строки и добавление в словарь
                foreach (string line in lines)
                {
                    string[] keyValue = line.Split('=');
                    if (keyValue.Length == 2)
                    {
                        string key = keyValue[0].Trim();
                        string value = keyValue[1].Trim();
                        settings[key] = value;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
            }

            return settings;
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
                if (settings.ContainsKey("host") && settings.ContainsKey("port"))
                {
                    string host = settings["host"];
                    string portString = settings["port"];
                    host = host.Trim('\"', ' ');
                    portString = portString.Trim('\"', ' ');
                    if (int.TryParse(portString, out int port)) 
                    {
                        FormData.client.Connect(host, port);
                    }
                    else 
                    {
                        MessageBox.Show($"Ошибка при преобразовании строки порта в число. {portString}, {host}");
                    }
                }
                else
                {
                    MessageBox.Show("Неверный формат файла настроек.");
                }
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
