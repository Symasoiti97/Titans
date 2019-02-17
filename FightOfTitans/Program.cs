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
        }
        static void Main(string[] args)
        {
            Thread thread = new Thread(play);
            thread.Start();
            //Console.ReadKey();
        }
    }
}
