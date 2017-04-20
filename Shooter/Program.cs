using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooter
{
    class Program
    {
        static void Main()
        {
            int strength;
            int life = 100;
            int newStrength;

            while (life > 0)
            {               
            Console.WriteLine("Give strength....");
            newStrength = Int32.Parse(Console.ReadLine());
            if(newStrength <= 100 && newStrength >=50)
            {
                strength = newStrength;
                    for (; strength > 50; strength--)
                    {
                        Console.WriteLine("--->");
                    }
                    life = life - 5;
                }
            else
            {
                Console.WriteLine("Strength should less than 100 and higher than 50.");
            }
                
            }
            Console.WriteLine("You can't shoot anymore.....");
            Console.ReadKey();
        }
    }
}
