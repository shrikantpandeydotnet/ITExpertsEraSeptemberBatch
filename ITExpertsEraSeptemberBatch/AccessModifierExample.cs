using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraSeptemberBatch
{
    public class AccessModifierExample
    {
        public int pubicVariable = 10;
        private int privateVariable = 20;
        internal int internalVariable = 40;
        protected int protectedVariable = 50;

        int testAbc = 100;


        protected internal int protectedinternal = 60;

        public void TestMethod(int var1)
        {
            pubicVariable = 20;
            privateVariable = 200;
            internalVariable = 500;
            protectedVariable = 100;

            protectedinternal = 100;

            testAbc = 1000;

            int test = 100;

            int abc = 200;

        }

        public void TestMethod2()
        {
            pubicVariable = 20;
            privateVariable = 200;
            internalVariable = 400;
            protectedVariable = 100;
            protectedinternal = 100;

            testAbc = 2000;


        }

    }

    public class childClass : AccessModifierExample
    {

        public void TestMethod()
        {
            protectedVariable = 1000;
        }
    }
}
