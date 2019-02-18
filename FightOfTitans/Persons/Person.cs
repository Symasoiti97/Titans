using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightOfTitans
{
    abstract class Person
    {
        protected string Name;
        protected string TypePerson;

        protected IWeapon weapon;

        //public Person(string Name)
        //{
        //    this.Name = Name;
        //}

        public void Attack()
        {
            Console.WriteLine($"Name player: {this.Name} | Person: {this.TypePerson} | Gived damage: " +
                $"{this.weapon.damageWeapon()} | Type Weapon: {this.weapon.typeWeapon()}");
        }

        public static Person CreatePerson()
        {
            Console.WriteLine("Your name: ");
            string Name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Your person:");
            List<Person> persons = new List<Person> { new BowMan(Name), new SwordMan(Name), new Mag(Name) };

            for (int i = 0; i < persons.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {persons[i].TypePerson}");
            }

            ConsoleKeyInfo key = Console.ReadKey(true);
            string TypePerson = persons[Convert.ToInt16(key.KeyChar.ToString()) - 1].TypePerson;
            Console.WriteLine($"You chose: {TypePerson}");

            return persons[Convert.ToInt16(key.KeyChar.ToString())-1];
        }

        public void ChangeWeapon()
        {
            Console.WriteLine("Change weapon");
            List<Weapon> weapons = new List<Weapon> { new WBow(), new WSword(), new WMagic() };

            for (int i = 0; i < weapons.Count; i++)
            {
                Console.WriteLine($"{i+1}. {weapons[i].typeWeapon()}");
            }
            
            ConsoleKeyInfo key = Console.ReadKey(true);
            this.weapon = weapons[Convert.ToInt16(key.KeyChar.ToString())-1];
            Console.WriteLine($"You chose: {weapon.typeWeapon()}");
        }
    }
}
