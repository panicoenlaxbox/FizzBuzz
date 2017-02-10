using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzParser
    {
        public string Parse(int i)
        {
            if (IsFizzBuzz(i))
            {
                return "fizzbuzz";
            }
            if (IsFizz(i))
            {
                return "fizz";
            }
            if (IsBuzz(i))
            {
                return "buzz";
            }
            return i.ToString();
        }

        private static bool IsBuzz(int i) => i % 5 == 0;
        private static bool IsFizz(int i) => i % 3 == 0;
        private static bool IsFizzBuzz(int i) => IsBuzz(i) && IsFizz(i);
    }
}
