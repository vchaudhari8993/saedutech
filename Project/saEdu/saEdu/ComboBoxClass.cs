using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace saEdu
{
    class ComboboxValue
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public long created_at { get; private set; }

        public ComboboxValue(int id, string name,long created_year)
        {
            Id = id;
            Name = name;
            created_at = created_year;
        }

        public override string ToString()
        {
            return Name;
        }
        public int getId(int index)
        {
            return (Id);
        }
        public string getAccDetail(int Id)
        {
            return (Convert.ToString(created_at) + Name);
        }
    }
}
