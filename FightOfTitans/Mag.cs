using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightOfTitans
{
    class Mag : Person
    {
        public Mag(string name, IWeapon weapon) : base(name, weapon)
        {

        }

        public void attack()
        {
            Console.WriteLine($"Name player: {Name} | Person: Mag | Gived damage: " +
                $"{weapon.damageWeapon()} | Type Weapon: {weapon.typeWeapon()}");
        }
    }
}
