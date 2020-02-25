using System;

namespace guess_the_number
{
    class Program
    {
        static int number = 0; 
        static int randomNumber = 0;
        static int guessedNumber = 0;
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
        static void CheckGuessNumber(){
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
        static void Main(string[] args)
        {
            Console.WriteLine("Hola, vamos a jugar a que adivines un número que nosotros generaremos");
            UserInput();
            GenerateDelimitedRandomNumber();
            CheckGuessNumber();
            
        }
    }
}
