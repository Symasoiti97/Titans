using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightOfTitans
{
    class WSword : Weapon, IWeapon
    {
        public WSword()
        {
            NameWeapon = "WSword";
            mindmg = 13;
            maxdmg = 17;
        }
    }
}
