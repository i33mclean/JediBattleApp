using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JediBattleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize Combatant Objects
            Combatant darthVader = new Combatant() { name = "Darth Vader", health = 100};
            Combatant lukeSkywalker = new Combatant() { name = "Luke Skywalker", health = 100};

            // Character select and Enter combat phase
            Console.WriteLine("Type 'Darth' to play as Darth Vader.. Type 'Luke' to play as Luke Skywalker.");
            string charSelect = Console.ReadLine();
            if (charSelect == "Darth")
            {
                Console.WriteLine("Now entering combat as Darth Vader...");
            }
            else if (charSelect == "Luke")
            {
                Console.WriteLine("Now entering combat as Luke Skywalker...");
            }

            // Attacks
            Console.WriteLine("Press 1 to cast a basic attack, 2 for a slash attack, 3 for a heavy attack");
            while (true) 
            {
                // Random number generator for Basic Attack
                Random basicRandom = new Random();
                int basicAttackRandom = basicRandom.Next(10, 15);

                Random slashRandom = new Random();
                int slashAttackRandom = slashRandom.Next(20, 25);

                Random heavyRandom = new Random();
                int heavyAttackRandom = heavyRandom.Next(35, 45);

                char combatInput = Console.ReadKey(true).KeyChar;
                if (combatInput == '1')
                {
                    Console.WriteLine("Casting basic attack...");
                    lukeSkywalker.health -= basicAttackRandom;
                    Console.WriteLine("Darth Vader health = " + darthVader.health);
                    Console.WriteLine("Luke Skywalker health = " + lukeSkywalker.health);
                }
                else if (combatInput == '2')
                {
                    Console.WriteLine("Casting slash attack...");
                    lukeSkywalker.health -= slashAttackRandom;
                    Console.WriteLine("Darth Vader health = " + darthVader.health);
                    Console.WriteLine("Luke Skywalker health = " + lukeSkywalker.health);
                }
                else if (combatInput == '3')
                {
                    Console.WriteLine("Casting heavy attack...");
                    lukeSkywalker.health -= heavyAttackRandom;
                    Console.WriteLine("Darth Vader health = " + darthVader.health);
                    Console.WriteLine("Luke Skywalker health = " + lukeSkywalker.health);
                }
            }

        }
    }
}
