using System;

namespace guess_the_number
{
    class Program
    {
        static int number = 0; 
        static void UserInput(){
            Console.WriteLine("Por favor escribe un número positivo");
            Console.WriteLine("Y presiona enter");
            string userInputNumber = Console.ReadLine();
            number = Convert.ToInt32(userInputNumber);

        }
        static void Main(string[] args)
        {
            UserInput();
        }
    }
}
