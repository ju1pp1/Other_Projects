﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLibrary
{
    public class PersonPlus
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public int IkäEnsiVuonna()
        {
            return Age + 1;
        }

        public virtual string Tulosta()
        {
            return Name;
        }
    }
}
