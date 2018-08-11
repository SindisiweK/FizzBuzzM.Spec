using System;
namespace MSpectationLesson1
{
    public class FizzBuzzer
    {
        public string Fizz(int number)
        {
            if (number == 2)
            {
                return "Whiz";
            }
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }
            if (number % 3 == 0)
            {
                return "Fizz";
            }
            if(number % 5 == 0)
            {
                return "Buzz";
            }
            return number.ToString();
        }
    }
}