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
            SwardMan Player2 = new SwardMan("AzazaMan", new WSward());
            Mag Player3 = new Mag("Star4Man", new WMagic());
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
