using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace FightOfTitans
{
    class Program
    {
        static void play()
        {
            Person person = Person.CreatePerson();
            Console.WriteLine("q: stop; w: change weapon; e: attack");

            bool stop = false;

            while (!stop)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.Q: stop = true; break;
                    case ConsoleKey.W: person.ChangeWeapon(); break;
                    case ConsoleKey.E: person.Attack(); break;
                    default: break;
                }
            }
        }

        static void Main(string[] args)
        {
            Thread thread = new Thread(play);
            thread.Start();
            //Person player = new Mag("Name");
            //player.Attack();
            //ConsoleKeyInfo key = Console.ReadKey(true);
            //Console.WriteLine(Convert.ToInt16(key.KeyChar.ToString()) + 5);
            //Console.ReadKey();
        }
    }
}
