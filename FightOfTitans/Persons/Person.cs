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
        protected IWeapon weapon;
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
        public void ChangeWeapon()
        {
            Console.WriteLine("Change weapon");
            Console.WriteLine("1. Bow\n2. Sward\n3. Magica" );
            ConsoleKeyInfo key = Console.ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.D1: this.weapon = new WBow();break;
                case ConsoleKey.D2: this.weapon = new WSward();break;
                case ConsoleKey.D3: this.weapon = new WMagic();break;
                default: break;
            }
            Console.WriteLine($"You chose: {weapon.typeWeapon()}");
        }
    }
}
