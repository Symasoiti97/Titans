using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightOfTitans
{
    class WBow : Weapon, IWeapon
    {
        public WBow()
        {
            NameWeapon = "WBow";
            mindmg = 10;
            maxdmg = 20;
        }
    }
}
