using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        public override void Play(Player other) //method for playing the game
        {
            // Call roll for "this" object and for the "other" object
            int myRoll = Roll();
            int otherRoll = other.Roll();
            List<string> insults = new List<string>(){
                "I have a smart brain attached to a smart mouth, you have been warned!",
                "Everyone has a dream, mine is to crush yours!",
                "Get Destroyed!",
                "Here, let me pour you a tall glass of get over it."
            };
            var random = new Random(); //generate random index for grabbing comment from insult list
            int index = random.Next(insults.Count);
            

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
                Console.WriteLine(insults[index]); //display random insult, if creative Smack talking player wins
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