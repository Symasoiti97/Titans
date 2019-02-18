using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightOfTitans
{
    class WMagic : Weapon, IWeapon
    {
        public WMagic()
        {
            NameWeapon = "WMagic";
            mindmg = 10;
            maxdmg = 30;
        }
    }
}
