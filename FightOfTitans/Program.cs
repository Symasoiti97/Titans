using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightOfTitans
{
    
    class Person
    {
        string Name;
        IWeapon weapon;
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
    interface IWeapon
    {
        string typeWeapon();
        int damageWeapon();
        int maxdmg { get;}
        int mindmg { get;}
    }
    class WBow : IWeapon
    {
        static Random rand = new Random();
        public string typeWeapon()
        {
            return "I'm BowMan";
        }
        public int damageWeapon()
        {
            
            return rand.Next(mindmg, maxdmg + 1);
        }
        public int maxdmg
        {
            get
            {
                return 20;
            }
        }
        public int mindmg
        {
            get
            {
                return 9;
            }
        }

    }
    class WSward : IWeapon
    {
        static Random rand = new Random();
        public string typeWeapon()
        {
            return "I'm SwardMan";
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
    class WMagic : IWeapon
    {
        static Random rand = new Random();
        public string typeWeapon()
        {
            return "I'm Mag";
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
    class Program
    {
        static void Main(string[] args)
        {
            Person Player1 = new Person("StupidMan", new WBow());
            Person Player2 = new Person("AzazaMan", new WSward());
            Person Player3 = new Person("Star4Man", new WMagic());
            Player1.attack();
            Player3.attack();
            Player2.attack();
            Player1.attack();
            Player3.attack();
            Player2.attack();
            Console.ReadKey();
        }
    }
}
