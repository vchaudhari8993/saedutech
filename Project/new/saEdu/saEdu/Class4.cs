using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace saEdu
{
    public static class GlobalClass
    {
        public static OleDbDataReader or;
        public static string s;
        public static string database = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Educational 1\Projects\Project HMS\Project HMS\saEdu.accdb;Persist Security Info=False;";
        public static string url = "http://mudra.mahasoftball.webfactional.com/";
        public static string session;
        public static long start_date;
        public static long end_date;
        public static int acc_id;
        public static DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
    }
}