using System;

namespace guess_the_number
{
    class Program
    {   
        /// <summary>
        /// Variable to declare the user's input number 
        /// </summary>
        static int number = 0; 
        /// <summary>
        /// Variable to store the random number we generate in GenerateDelimitedRandomNumber
        /// </summary>
        static int randomNumber = 0;
        /// <summary>
        /// Variable to store the user's guessed number 
        /// </summary>
        static int guessedNumber = 0;
        /// <summary>
        /// Variable to store how many tries has had the user trying to guess the number we generated.
        /// </summary>
        static int countTries = 0;
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
            Console.WriteLine();
            Console.WriteLine("Primero, por favor escribe un número entero positivo");
            Console.WriteLine("Y presiona enter");
            string userInputNumber = Console.ReadLine();
            number = Convert.ToInt32(userInputNumber);
            Console.WriteLine();
        }
        /// <summary>
        /// Here we check if the guessed number is correct or not, until it is correct we repeat this method
        /// until the bool is true and the user wins.
        /// </summary>
        static void CheckGuessNumber(){
            //Variable that is false until this and the guessedNumber are the same.
            bool guessedNumberIsCorrect = false;

            Console.WriteLine("Ahora debes adivinar el número que generamos entre 0 y el número que ingresaste");
            Console.WriteLine("El número que debes adivinar esta entre 0 y " + number);
            
            string userGuessedNumber = Console.ReadLine();
            guessedNumber = Convert.ToInt32(userGuessedNumber);
            
            Console.WriteLine();

            while (!guessedNumberIsCorrect) {
                if (guessedNumber == randomNumber)
                {
                    Console.WriteLine("Felicidades, acertaste!");
                    Console.WriteLine("Intentaste " + countTries + " veces");
                    guessedNumberIsCorrect = true;

                }else if (guessedNumber > randomNumber){
                    Console.WriteLine("El número que ingresaste es demasiado alto, ingresa nuevamente otro número ");
                    countTries++;
                    userGuessedNumber = Console.ReadLine();
                    guessedNumber = Convert.ToInt32(userGuessedNumber);
                    Console.WriteLine();
                }
                else if (guessedNumber < randomNumber){
                    Console.WriteLine("El número que ingresaste es demasiado bajo, ingresa nuevamente otro número ");
                    countTries++;
                    userGuessedNumber = Console.ReadLine();
                    guessedNumber = Convert.ToInt32(userGuessedNumber);
                    Console.WriteLine();
                }
            }
        }
        /// <summary>
        /// Main method where we start the guess the number program.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hola, vamos a jugar a que adivines un número que nosotros generaremos");
            UserInput();
            GenerateDelimitedRandomNumber();
            CheckGuessNumber();
            
        }
    }
}
