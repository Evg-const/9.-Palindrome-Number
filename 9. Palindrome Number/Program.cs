using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Palindrome_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для поиска полиндрома:");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IsPalindrome(A));
            Console.Read();


             bool IsPalindrome(int x)
            {

                if (x < 0) { return false; }
                if (x == 0) { return true; }
                if (x % 10 == 0) { return false; }

                int a = 0;
                while (x > a)
                {
                    a = a * 10 + x % 10;
                    x /= 10;
                }
                return x == a || x == a / 10;
            }


    }
    }
}
