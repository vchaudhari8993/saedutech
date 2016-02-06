using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace saEdu
{
    public class comboTest
    {
        
        string name;
        int id;
        long created_at;

        //Constructor
        public comboTest(int Id, string Name,long created_yr)
        {
            id = Id;
            name = Name;
            created_at = created_yr;
        }

        //Accessor
        public int ID
        {
            get
            {
                return id;
            }
        }
       
        public string year
        {
            get
            {
                return (Convert.ToString(created_at));
            }
        }
        public string acc_name
        {
            get
            {
                return (name);
            }
        }
        //Override ToString method
        public override string ToString()
        {
            return name;
        }
    }
}
