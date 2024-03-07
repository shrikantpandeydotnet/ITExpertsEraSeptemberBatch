using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraSeptemberBatch
{
    internal class ExceptionHandlingExample
    {

        public void TestMethod(int var1)
        {
            try
            {

                int i = 10;

                int j = 0;

                if (var1 > 100)
                {
                    throw new Exception("I am boss exception");
                }

                try
                {
                    int var10 = 10;

                    if (var1 > 100)
                    {
                        throw new ArgumentException("There is an issue in argument. Please correct the argument value");
                    }

                    Console.WriteLine(var10);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                

                int result = i / j;

                Console.WriteLine(result);

                Console.WriteLine("This is a test method");
            }
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("You are attempting to divide by zero. Please correct your value");
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine($"There is wrong argument pass in the method");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Website is currently down. Please contact system adminstration");
            //}
            finally
            {
                Console.WriteLine("I am finally. I will always get called.");
            }

        }
    }
}
