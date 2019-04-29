using Game.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {

            Random r = new Random();

            Console.WriteLine(r.Next(5, 10));

            bool CharChoosen;
            string name;
            int pow;
            bool isConverted;



            do
            {
                CharChoosen = true;
                Console.WriteLine("Character secin:");
                Console.WriteLine("1 - Archer");
                Console.WriteLine("2 - Mage");

                string inputChar = Console.ReadLine();



                switch (inputChar)
                {
                    case "1":
                        Console.Write("Ad daxil edin: ");
                        name = Console.ReadLine();
                        Console.Write("Power daxil edin: ");
                        isConverted = Int32.TryParse(Console.ReadLine(), out pow);

                        Archer archer1 = new Archer(name, pow);

                        archer1.AttackTepik();
                        archer1.AttackYumruq();
                        archer1.DecreaseHP(10);
                        archer1.AttackSoyush();
                        archer1.Forward(10);
                        Console.WriteLine(archer1.Position);

                        archer1.Backward(4);
                        Console.WriteLine(archer1.Position);

                        archer1.Death();

                        break;
                    case "2":
                        Console.Write("Ad daxil edin: ");
                        name = Console.ReadLine();
                        Console.Write("Power daxil edin: ");
                        isConverted = Int32.TryParse(Console.ReadLine(), out pow);
                       
                        Mage mage1 = new Mage(name, pow);
                        mage1.Forward(20);
                        mage1.DecreaseHP(50);

                        break;

                    default:
                        CharChoosen = false;
                        break;
                }

                
            } while (!CharChoosen);
            
            Console.ReadLine();
            
        }
    }
}
