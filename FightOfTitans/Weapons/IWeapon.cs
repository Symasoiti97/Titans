using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightOfTitans
{
    interface IWeapon
    {
        string typeWeapon();
        int damageWeapon();
        int maxdmg { get; }
        int mindmg { get; }
    }
}
