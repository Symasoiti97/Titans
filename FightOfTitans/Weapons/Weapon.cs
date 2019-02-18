using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightOfTitans
{
    abstract class Weapon : IWeapon
    {
        private Random rand = new Random();

        protected string NameWeapon;
        protected int mindmg;
        protected int maxdmg;

        public string typeWeapon()
        {
            return NameWeapon;
        }

        public int damageWeapon()
        {
            return rand.Next(mindmg, maxdmg + 1);
        }
    }
}
