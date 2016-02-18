using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Web.Script.Serialization;

namespace saEdu
{
    class groupList
    {
        string jsonobj;
        JObject jo;
        //public comboAcc(int Id, string choice_name, string is_selected)
        //{
        //    id = Id;
        //    acc_type = choice_name;
        //    status = is_selected;
        //}

        public groupList(string jobj)
        {
            jsonobj = jobj;
        }
        public override string ToString()
        {
            JObject jo = JObject.Parse(jsonobj);
            string str2 = (Convert.ToString(jo["choice_name"]));
            return str2;
        }
        public string acc_obj
        {
            get
            {
                jo = JObject.Parse(jsonobj);
                jo["is_selected"] = true;
                jsonobj = Convert.ToString(jo);
                //status= Convert.ToString(jo["is_selected"]);
                //status = "true";
                return (jsonobj);
            }
        }
    }
}
