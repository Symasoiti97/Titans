using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightOfTitans
{
    class WMagic : IWeapon
    {
        static Random rand = new Random();
        public string typeWeapon()
        {
            return "Magica";
        }
        public int damageWeapon()
        {

            return rand.Next(mindmg, maxdmg + 1);
        }
        public int maxdmg
        {
            get
            {
                return 24;
            }
        }
        public int mindmg
        {
            get
            {
                return 7;
            }
        }

    }
}
