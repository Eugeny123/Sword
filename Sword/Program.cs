using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Sword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SwordDamage swordDamage = new SwordDamage();
            Random random = new Random();

            int diceRoll = 0;
            for (int i = 0; i < 3; i++)
            {
                diceRoll += random.Next(1, 7);
            }
            Console.WriteLine("dice roll: " + diceRoll);
            swordDamage.Roll = diceRoll;

            Console.WriteLine("enter which sword: 0 for no magic/flaming," +
                " 1 for magic,2 for flaming, 3 for both," +
                " anything else to quit");

            int whichSword = int.Parse(Console.ReadLine());
            if (whichSword == 0)
            {
                swordDamage.CalculateDamage();
                Console.WriteLine($"Rolled for {swordDamage.Damage} HP");
                
            }
            else if (whichSword == 1)
            {
                swordDamage.SetMagic(true);
                Console.WriteLine($"Rolled for {swordDamage.Damage} HP");
            }
            else if (whichSword == 2)
            {
                swordDamage.SetFlaming(true);
                Console.WriteLine($"Rolled for {swordDamage.Damage} HP");
            }
            else if (whichSword == 3)
            {
                swordDamage.SetMagic(true);
                swordDamage.SetFlaming(true);
                Console.WriteLine($"Rolled for {swordDamage.Damage} HP");
            }
            else
            {
                Console.WriteLine("please, enter correct number");
                return;
            }

        }
    }
}
