﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightOfTitans
{
    class BowMan : Person
    {
        public BowMan(string Name) //: base(Name)
        {
            this.Name = Name;
            TypePerson = "BowMan";
            this.weapon = new WBow();
        }
    }
}
