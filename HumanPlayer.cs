using System;
namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override void Play(Player other) //method for playing the game
        {
            int otherRoll = other.Roll();
            if (other.Roll() > 6){
                DiceSize = 20;
                Console.WriteLine($"Enter the number you rolled at home...between 1-20.");
                int myRoll = int.Parse(Console.ReadLine());
                // Call roll for "this" object and for the "other" object
                // int myRoll = Roll();
                

                Console.WriteLine($"{Name} rolls a {myRoll}");
                Console.WriteLine($"{other.Name} rolls a {otherRoll}");
                if (myRoll > otherRoll)
                {
                    Console.WriteLine($"{Name} Wins!");
                }
                else if (myRoll < otherRoll)
                {
                    Console.WriteLine($"{other.Name} Wins!");
                }
                else
                {
                    // if the rolls are equal it's a tie
                    Console.WriteLine("It's a tie");
                }    
                }
            else{
                Console.WriteLine($"Enter the number you rolled at home...between 1-6.");
                int myRoll = int.Parse(Console.ReadLine());
                // Call roll for "this" object and for the "other" object
                // int myRoll = Roll();
                

                Console.WriteLine($"{Name} rolls a {myRoll}");
                Console.WriteLine($"{other.Name} rolls a {otherRoll}");
                if (myRoll > otherRoll)
                {
                    Console.WriteLine($"{Name} Wins!");
                }
                else if (myRoll < otherRoll)
                {
                    Console.WriteLine($"{other.Name} Wins!");
                }
                else
                {
                    // if the rolls are equal it's a tie
                    Console.WriteLine("It's a tie");
                }
            }
        }

    }
}