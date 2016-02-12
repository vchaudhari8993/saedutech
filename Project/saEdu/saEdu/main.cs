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
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login());
        }
    }
}
