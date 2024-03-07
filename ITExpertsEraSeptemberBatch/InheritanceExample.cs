using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraSeptemberBatch
{
    public  class Parent
    {
        public void ParentMethod()
        {
            Console.WriteLine("I am Parent Method");
        }
    }

    public class Child : Parent
    {
        public void ChildMethod()
        {
            Console.WriteLine("I am child class method");
        }
    }

    public class GrandChild : Child
    {
        public void GrandChildMethod()
        {
              Console.WriteLine("I am grand child method");
        }
    }

    public class Child2 : Parent
    {
        public void Child2Method()
        {
            Console.WriteLine("I am child 2 method");
        }
    }



}
