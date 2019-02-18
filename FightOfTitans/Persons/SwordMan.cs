using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightOfTitans
{
    class SwordMan : Person
    {
        public SwordMan(string Name)// : base(Name)
        {
            this.Name = Name;
            TypePerson = "SwardMan";
            weapon = new WSword();
        }
    }
}
