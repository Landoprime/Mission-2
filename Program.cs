using System;

namespace Mission_2
{
    public class Program
    {
        private static void Main(string[] args)
        {// This is where we inititalize the DiceRoll class
            DiceRoll dr = new DiceRoll();
            // declare diceRolls
            int diceRolls = 0;
            // Opening messages
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How many dice rolls would you like to simulate: ");
            // in order to read the line it must be an integer like we declared
            diceRolls = int.Parse(Console.ReadLine());
            Console.WriteLine(diceRolls + " Rolls coming your way!");
            Console.WriteLine();
            //initializing the array results
            int[] rollResults = dr.PassDice(diceRolls);
            //This is the patient handing the pee cup through the window
            PrintHistogram(rollResults);
        }

        private static void PrintHistogram(int[] rollResults)// this is the guy who receives the pee cup
        {
            

            // this will count occurrences of each number
            int[] counts = new int[13]; // 2-12 are the only options possible with two dice

            foreach (var result in rollResults)
            {
                counts[result]++;
            }

            // Here you calculate and print the histogram
            for (int i = 2; i <= 12; i++)
            {
                double percentage = (double)counts[i] / rollResults.Length * 100;

                Console.Write($"{i}: {new string('*', (int)Math.Round(percentage))} ");
                Console.WriteLine();
                
            }
            Console.WriteLine();
            Console.WriteLine("Thank you for using the dice throwing simulator! Ciao!"); //Here I show how bilingual I am.
        }
    }
}