using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Web.Script.Serialization;

namespace saEdu
{
    class comboAcc
    {
        JObject jo;
        string jsonobj;
        string str2;
        //int obj_index;

        public comboAcc(string jobj)
        {
            jsonobj = jobj;
        }
        public string acc_obj
        {
            get
            {
                jo = JObject.Parse(jsonobj);
                jo["is_selected"] = true;
                jsonobj = Convert.ToString(jo);
                return (jsonobj);
            }
        }
        public string get_acc_obj(int index)
        {
            //obj_index = index;
            jo = JObject.Parse(jsonobj);
            str2 = (Convert.ToString(jo["is_selected"]));
            str2 = "true";
            return jsonobj;
        }
        //Override ToString method
        public override string ToString()
        {
            jo = JObject.Parse(jsonobj);
            str2 = (Convert.ToString(jo["choice_name"]));
            return str2;
        }
    }
}
