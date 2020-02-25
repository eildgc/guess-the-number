using System;

namespace guess_the_number
{
    class Program
    {
        static int number = 0; 
        static int randomNumber = 0;
        /// <summary>
        /// In this method we generate a random number and multiply it by the user's input number plus one
        /// so the random number generated is between the range we need for this program.
        /// </summary>
        static void GenerateDelimitedRandomNumber(){
            Random r = new Random();
            randomNumber = (int)Math.Floor(r.NextDouble() * (number+1));
            }
            /// <summary>
            /// In this method we ask to the user to enter a positive number.
            /// </summary>
        static void UserInput(){
            Console.WriteLine("Por favor escribe un número positivo");
            Console.WriteLine("Y presiona enter");
            string userInputNumber = Console.ReadLine();
            number = Convert.ToInt32(userInputNumber);

        }
        static void Main(string[] args)
        {
            UserInput();
            GenerateDelimitedRandomNumber();
            Console.WriteLine(randomNumber);
        }
    }
}
