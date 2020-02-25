using System;

namespace guess_the_number
{
    class Program
    {
        static int number = 0; 
        static int randomNumber = 0;
        static void GenerateDelimitedRandomNumber(){
            Random r = new Random();
            randomNumber = (int)Math.Floor(r.NextDouble() * (number+1));
            }
        static void UserInput(){
            Console.WriteLine("Por favor escribe un número positivo");
            Console.WriteLine("Y presiona enter");
            string userInputNumber = Console.ReadLine();
            number = Convert.ToInt32(userInputNumber);

            Console.WriteLine("El número que escribiste fue " + number);
        }
        static void Main(string[] args)
        {
            UserInput();
            GenerateDelimitedRandomNumber();
            Console.WriteLine(randomNumber);
        }
    }
}
