using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraSeptemberBatch
{
    public interface IMaths
    {
        void Add(int a, int b);
        void TestMethod();

        void IMathTestMethod();
    }

    public interface ITEstInterface
    {
        void TestInterfaceMethod();
        void TestMethod();

        void TestMethod2();

    }

    public class ParentTestClass
    {
        public void ParentTestMethod()
        {
            Console.WriteLine("I am parent class test method");
        }
    }

    public class ParentTestClass2
    {
        public void ParentTestMethod2()
        {
            Console.WriteLine("I am parent class test method");
        }
    }

    public class TestClass : ParentTestClass, IMaths, ITEstInterface
    {
        public void Add(int a, int b)
        {
            int result = a + b;

            Console.WriteLine(result);
        }

        public void IMathTestMethod()
        {
            throw new NotImplementedException();
        }

        public void TestInterfaceMethod()
        {
            Console.WriteLine("I am Test INterface Method");
        }

        void IMaths.TestMethod()
        {
           Console.WriteLine("this is a Imaths test method");
        }

        void ITEstInterface.TestMethod()
        {
            Console.WriteLine("this is a ITestInterface test method");
        }

        public void TestMethod2()
        {
            throw new NotImplementedException();
        }
    }
}
