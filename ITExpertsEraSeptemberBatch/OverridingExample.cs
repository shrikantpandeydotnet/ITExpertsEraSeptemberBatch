using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraSeptemberBatch
{
    public class A1
    {
        public virtual void TestMethod()
        {
            Console.WriteLine("I am parent class method");
        }

        public void TestMethod2()
        {
            Console.WriteLine("I am parent class testmethod2");
        }
    }

    public class B1 : A1
    {
        public override void TestMethod()
        {
            Console.WriteLine("I am overrided method");
        }

        public new void TestMethod2()
        {
            Console.WriteLine("I am new method of child class with same name as parent class method");
        }
    }

}
