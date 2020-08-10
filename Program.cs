// Write a program that will generate a random number between 1 and 10, prompt two users for a guess, and output the winner 
// (closest to the number). If both guesses are equidistant from the target or both players guess the same number, it is a draw.

using System;

namespace PracticeProblem10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generate = new Random();             // https://stackoverflow.com/questions/46665006/c-sharp-guess-random-number -> Line 12/13 to RNG a # between 1 to 10
            int testValue = generate.Next(1, 10);      // Generates a new instance of the random method which we save into an integer known as testValue. 


            Console.WriteLine($"Player 1 - What do you think the number is?");
            int userInput1 = Convert.ToInt32(Console.ReadLine());                    

            Console.WriteLine($"Player 2 - What do you think the number is?");
            int userInput2 = Convert.ToInt32(Console.ReadLine());   

            int player1Score = Math.Abs(testValue - userInput1);

            int player2Score = Math.Abs(testValue - userInput2);
              //  if (player1Score == player2Score);
             //   {
             //        Console.WriteLine($"The game is a draw! The RNG value was {testValue} and Player 1 picked {userInput1}, while Player 2 picked {userInput2}!");
//
           //     Console.WriteLine($"Player 1 Wins! The RNG value was {testValue} and they picked {userInput1}!");

                //    Console.WriteLine($"Player 2 Wins! The RNG value was {testValue} and they picked {userInput2}!");

                }
        }
    }

