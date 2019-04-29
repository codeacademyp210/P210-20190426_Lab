using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Interface
{
    interface IFighter
    {
        bool Defence();
        bool Forward(int distance);
        bool Backward(int distance);
    }
}
