using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightOfTitans
{
    class WSward : IWeapon
    {
        static Random rand = new Random();
        public string typeWeapon()
        {
            return "Sward";
        }
        public int damageWeapon()
        {

            return rand.Next(mindmg, maxdmg + 1);
        }
        public int maxdmg
        {
            get
            {
                return 17;
            }
        }
        public int mindmg
        {
            get
            {
                return 13;
            }
        }

    }
}
