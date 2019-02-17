using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightOfTitans
{
    class SwardMan : Person
    {
        public SwardMan(string name, IWeapon weapon) : base(name, weapon)
        {

        }

        public void attack()
        {
            Console.WriteLine($"Name player: {Name} | Person: SwardMan | Gived damage: " +
                $"{weapon.damageWeapon()} | Type Weapon: {weapon.typeWeapon()}");
        }
    }
}
