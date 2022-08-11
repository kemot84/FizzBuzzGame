using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
    class FizzBuzz
    {
        public string GetData(int number)
        {
            if (number % 15 ==0)
                return "\nFizzBuzz! Gratulacje!";

            if (number % 3 == 0)
                return "\nFizz! Spróbuj ponownie. Twoja liczba to:";
            
            if (number % 5 ==0)
                return "\nBuzz! Spróbuj ponownie. Twoja liczba to:";
            
            return number.ToString();
        }
    }
}
