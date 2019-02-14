using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightOfTitans
{
    abstract class Person
    {
        public string Name;
        public IWeapon weapon;
        public Person(string Name, IWeapon weapon)
        {
            this.Name = Name;
            this.weapon = weapon;
        }
        public void attack()
        {
            Console.WriteLine($"Name player: {Name} | Gived damage: " +
                $"{weapon.damageWeapon()} | Type Weapon: {weapon.typeWeapon()}");
        }
    }
}
