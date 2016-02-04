﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace saEdu
{
    class ComboboxValue
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public ComboboxValue(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
