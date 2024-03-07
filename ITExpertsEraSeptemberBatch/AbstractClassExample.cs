using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraSeptemberBatch
{
    public abstract class AbstractClassExample
    {

        public AbstractClassExample()
        {
            Console.WriteLine(" I am constructor");   
        }

        public abstract void TestMethod();

        public abstract void TestMethod2();
    }

    public class Child20 : AbstractClassExample
    {
        public Child20()
        {
            Console.WriteLine("I am child class constructor");
        }
        public override void TestMethod() 
        {
            Console.WriteLine(" I am override method of an abstract method");
        }

        public override void TestMethod2()
        {
            Console.WriteLine(" I am override method of an abstract method");
        }
    }

}
