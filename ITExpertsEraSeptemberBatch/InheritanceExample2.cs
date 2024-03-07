using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraSeptemberBatch
{
    public class A
    {
        public A()  // 1
        {
            Console.WriteLine(" I am A class non static constructor");
        }

        static A() //2
        {
            Console.WriteLine(" I am A class  static constructor");
        }

    }

    public class B : A
    {
        public B() //3
        {
            Console.WriteLine(" I am B class non static constructor");
        }

        static B() //4
        {
            Console.WriteLine("I am B class static constructor");
        }
    }
}
