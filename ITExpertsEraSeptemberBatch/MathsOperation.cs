using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraSeptemberBatch
{
    public class MathsOperation
    {
        // Method with void return type and no parameter
        public void TestMethod()
        {
            Console.WriteLine("I am a test method with no return type and no parameter");
            Console.WriteLine("This is a test sentence");

            int i = 10;
            int j = 20; 
            int k = 100;

            Console.WriteLine(i+ j);
        }

        // Method with void return type and some parameters.
        public void Sum(int num1, int num2)
        {
            int result = num1 + num2;   

            Console.WriteLine("The sume of two numbers is " + result);
        }

        // Method with return type and some parameters 

        public int Subtract(int num1, int num2)
        {
            int result = num1 - num2;

            return result;
        }

        // method with array as a parameter.
        public int SumOfArray(int[] arrayTest)
        {
            int result = 0; 

            foreach (int val in arrayTest)
            {
                result = result + val;
            }

            return  result; 
        }


        // method that returns array

        public int[] Sonu(int firstNum, int secondNum, int thirdNum)
        {
            int[] result = new int[3];

            result[0] = firstNum;
            result[1] = secondNum;
            result[2] = thirdNum;

            return result;
        }
    }
}
