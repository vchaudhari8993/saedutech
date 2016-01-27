using System;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace saEdu
{
    class Program
    {
        

        const int PORT_NO = 8000;
        const string SERVER_IP = "192.168.1.123";
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login());
            //---data to send to the server---
            //string textToSend = DateTime.Now.ToString();

            //---create a TCPClient object at the IP and port no.---
            /*
            TcpClient client = new TcpClient(SERVER_IP, PORT_NO);
            NetworkStream nwStream = client.GetStream();
            byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes("hello");

            //---send the text---
            //Console.WriteLine("Sending : " + textToSend);
            //nwStream.Write(bytesToSend, 0, bytesToSend.Length);

            //---read back the text---
            byte[] bytesToRead = new byte[client.ReceiveBufferSize];
            int bytesRead = nwStream.Read(bytesToRead, 0, client.ReceiveBufferSize);
            Console.WriteLine("Received : " + Encoding.ASCII.GetString(bytesToRead, 0, bytesRead));
            Console.ReadLine();
            client.Close();*/
        }
    }
}
