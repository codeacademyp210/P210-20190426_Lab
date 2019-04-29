using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Characters
{
    class Character
    {

        public Character(string name, int power)
        {
            Name = name;
            Power = power;
        }


        public string Name { get; set; }
        public int Power { get; set; }
        public int HP { get; set; }
        public int Position { get; set; }

        public void Death()
        {
            HP = 0;
            Power = 0;
        }

        public void DecreaseHP(int i)
        {
            HP -= i;
            Console.WriteLine("HP: " + HP);
        }

        protected void Alive()
        {
            HP = 100;
            Position = 0;
        }

    }
}
