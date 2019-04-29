using Game.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Characters
{
    class Mage : Character, IFighter
    {

        public Mage(string name, int power) : base(name, power)
        {
            Alive();
        }

        public bool Forward(int distance)
        {
            if (Position <= 100)
            {
                Position += distance;
                return true;
            }

            return false;
        }

        public bool Backward(int distance)
        {
            if (Position != 0 && distance <= Position)
            {
                Position -= distance;
                return true;
            }
            
            return false;
        }

        public bool Defence()
        {
            Console.WriteLine("Defenced Mage");
            return true;
        }

    }
}
