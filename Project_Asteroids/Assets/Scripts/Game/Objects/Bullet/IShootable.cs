using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Objects
{
    interface IShootable
    {
        int Score { get; }
        void Hit();
    }
}
