using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaPrimeNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            List<int> list = FetchListOfMegaPrimeNos(number);
            for(int i=0;i<list.Count;i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadLine();
        }

        public static List<int> FetchListOfMegaPrimeNos(int maxNumber)
        {
            List<int> megaPrimes = new List<int>();
            for(int i=1;i<=maxNumber;i++)
            {
                if(IsMegaPrime(i))
                    megaPrimes.Add(i);
            }
            return megaPrimes;
        }

        public static bool IsPrimeNumber(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
            if ((number % 2) == 0) return false;
            var squareroot = (int)Math.Sqrt(number);
            for (int i = 3; i <= squareroot; i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        public static bool checkDigits(int n)
        {
            // check all digits are prime or not
            while (n > 0)
            {
                int dig = n % 10;

                // check if digits are prime or not
                if (dig != 2 && dig != 3 &&
                    dig != 5 && dig != 7)
                    return false;

                n /= 10;
            }

            return true;
        }
        public static bool IsMegaPrime(int n)
        {
            return (checkDigits(n) && IsPrimeNumber(n));
        }
    }
}
