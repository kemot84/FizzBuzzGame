using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Witaj w grze FizzBuzz! Wpisz liczbę i zobacz swój wynik. Gotowa/y? Wciśnij ENTER:");
            Console.ReadLine();
            
            var fizzBuzz = new FizzBuzz();
        
            while (true)
            {
                Console.WriteLine("Twoja liczba to: (jeśli chcesz wyjśc z aplikacji wciśnij klawisz E)");
                var number = GetNumber();
                Console.WriteLine(fizzBuzz.GetData(number));
                Console.WriteLine();
            }
        }
        private static int GetNumber()
        {
            while (true)
            {
                //var val = Console.ReadLine();
                //if (val.ToUpper() == "T")
                //    Environment.Exit(0);

                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("\nPodałeś nieprawidłową wartość. Spróbuj ponownie i wpisz liczbę (lub jeśli chcesz wyjśc z aplikacji wciśnij klawisz E)");
                    continue;
                }
                return number;
            }
        }
    }
}
