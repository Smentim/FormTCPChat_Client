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
        public string loggin {get; set;} = "";
        public string host {get; set;} = "127.0.0.1";
        public int port {get; set;} = 8888;
        public bool send_check {get; set;} = true;
        public TcpClient client {get; set;} = new TcpClient();
        public StreamReader? Reader {get; set;} = null;
        public StreamWriter? Writer {get; set;} = null;
    }
}
