using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightOfTitans
{
    class BowMan : Person
    {
        public BowMan(string name, IWeapon weapon) : base(name, weapon)
        {

        }

        public void attack()
        {
            Console.WriteLine($"Name player: {Name} | Person: BowMan | Gived damage: " +
                $"{weapon.damageWeapon()} | Type Weapon: {weapon.typeWeapon()}");
        }

    }
}
