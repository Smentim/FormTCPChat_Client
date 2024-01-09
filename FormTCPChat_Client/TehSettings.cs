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
    
    public static class TSettings
    {

        public static string Host { get; private set; } = "";
        public static int Port { get; private set; }
        public static string loggin {get; set;} = "";
        public static bool send_check {get; private set;} = true;
        public static TcpClient client {get; private set;} = new TcpClient();
        public static StreamReader? Reader {get; set;} = null;
        public static StreamWriter? Writer {get; set;} = null;

        public static void LoadSettings(string filePath)
        {
            try
            {
                // Чтение строк из файла
                string[] lines = File.ReadAllLines(filePath);

                // Обработка каждой строки
                foreach (string line in lines)
                {
                    string[] keyValue = line.Split('=');
                    if (keyValue.Length == 2)
                    {
                        string key = keyValue[0].Trim();
                        string value = keyValue[1].Trim();

                        if (key.Equals("host", StringComparison.OrdinalIgnoreCase))
                        {
                            Host = value;
                        }
                        else if (key.Equals("port", StringComparison.OrdinalIgnoreCase) && int.TryParse(value, out int parsedPort))
                        {
                            Port = parsedPort;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Обработка ошибки, например, запись в лог
                Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
            }
        }
    }
}
