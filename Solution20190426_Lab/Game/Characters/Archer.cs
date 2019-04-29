using Game.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Characters
{
    class Archer : Character, IFighter, IAttack
    {

        public Archer(string name, int power) : base(name, power)
        {
            Alive();
        }

        public int AttackKelle()
        {
            Console.WriteLine("Kelle");
            return 10;
        }

        public int AttackSoyush()
        {
            Console.WriteLine("Soyush muveffeqiyyetle soyuldu");
            return 50;
        }

        public int AttackTepik()
        {
            Console.WriteLine("Tepik");
            return 20;
        }

        public int AttackYumruq()
        {
            Console.WriteLine("Yumruq");
            return 15;
        }

        public bool Backward(int distance)
        {
            if (Position != 0 && distance <= Position && distance < 5)
            {
                Position -= distance;
                return true;
            }

            return false;
        }

        public bool Defence()
        {
            Console.WriteLine("Defenced Archer");
            return true;
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
    }
}
