using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraSeptemberBatch
{
    internal class PolymorphismExample
    {
        public int a;

        public static int b;

        public void Sum()
        {
            Console.WriteLine("I am sum method");

            a = 100;
            b = 200;

        }

        public static void testMethod()
        {
            b = 100;
        }

        public void Sum(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Sum of two numbers are " + result);
        }

        public void Sum(string a, string b)
        {
            string result = a + b;
            Console.WriteLine("Sum of two numbers are " + result);
        }

        public void Sum(int a, string b, int c)
        {
            int result = a + c;
            Console.WriteLine("Sum of two numbers are " + result);
        }

       
    }
}
