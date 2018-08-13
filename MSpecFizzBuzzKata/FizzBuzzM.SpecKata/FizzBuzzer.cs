using System;
namespace MSpectationLesson1
{
    public class FizzBuzzer
    {
        public string FizzBuzz(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }

            if (number % 3 == 0)
            {
                return "FizzBuzz";
            }

            if(number % 5 == 0)
            {
                return "Buzz";
            }
            return number.ToString();
        }

        public string FizzWhiz(int number)
        {
            if (number % 3 == 0 && GetPrime(number))
            {
                return "FizzWhiz";
            }

            if (number % 5 == 0 && GetPrime(number))
            {
                return "BuzzWhiz";
            }

            if (GetPrime(number))
            {
                return "Whiz";
            }
            return number.ToString();
        }

        private static bool GetPrime(int number)
        {
            for (var i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}