using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Org.BouncyCastle.Asn1.Utilities;
using System.Data;
using System.Net.Sockets;

namespace FormTCPChat_Client
{
    
    public class TSettings
    {
        private Dictionary<string, string> settings;
        private string filePath;

        public string loggin {get; set;} = "";
        public bool send_check {get; set;} = true;
        public TcpClient client {get; set;} = new TcpClient();
        public StreamReader? Reader {get; set;} = null;
        public StreamWriter? Writer {get; set;} = null;

        public TSettings(string filePath)
        {
            this.filePath = filePath;
            this.settings = ReadSettingsFromFile(filePath);
        }

        public string? GetHost()
        {
            // Получение значения "host" из настроек
            return settings.ContainsKey("host") ? settings["host"] : null;
        }

        public int GetPort()
        {
            // Получение значения "port" из настроек
            if (settings.ContainsKey("port") && int.TryParse(settings["port"], out int port))
            {
                return port;
            }
            else
            {
                // Обработка ошибки, например, возвращение значения по умолчанию
                return -1;
            }
        }

        private Dictionary<string, string> ReadSettingsFromFile(string filePath)
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
                // Обработка ошибки, например, запись в лог
                Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
            }

            return settings;
        }
    }
}
