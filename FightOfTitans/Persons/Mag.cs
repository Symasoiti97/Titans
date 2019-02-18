using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightOfTitans
{
    class Mag : Person
    {
        public Mag(string Name)// : base(Name)
        {
            this.Name = Name;
            TypePerson = "Mag";
            this.weapon = new WMagic();
        }
    }
}
