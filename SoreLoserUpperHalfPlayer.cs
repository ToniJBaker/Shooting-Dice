using System;
namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always rolls in the upper half of their possible role and
    //  who throws an exception when they lose to the other player
    public class SoreLoserUpperHalfPlayer : Player
    {
        public override void Play(Player other) //method for playing the game
        {
            // Call roll for "this" object and for the "other" object
            int myRoll = new Random().Next(4,7); //upper half of the roll options
            // int myRoll = Roll();
            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < otherRoll)
            {
                Console.WriteLine($"{other.Name} Wins!");
                Console.WriteLine($"I rarely loose!  I can't believe you beat me.");
            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");

            }
        }
    }
}