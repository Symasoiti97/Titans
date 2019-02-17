using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightOfTitans
{
    class Program
    {
        static void Main(string[] args)
        {
            BowMan Player1 = new BowMan("StupidMan", new WBow());
            Console.WriteLine("q: stop; w: change weapon; e: attack");
            bool stop = false;
            while (!stop)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.Q: stop = true; break;
                    case ConsoleKey.W: Player1.ChangeWeapon(); break;
                    case ConsoleKey.E: Player1.attack(); break;
                    default: break;
                }
            }
            //Console.ReadKey();
        }
    }
}
