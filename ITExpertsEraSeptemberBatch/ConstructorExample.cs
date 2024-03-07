using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraSeptemberBatch
{
    public class ConstructorExample
    {
        public int var_int;
        public string var_string;

        public static int var_static_int;

        //Syntax of Constructor || Default Constructor
        public ConstructorExample()
        {
            var_int = 10;
            var_string = "Test String";
        }

        // Parameterized Constructor
        public ConstructorExample(int value)
        {
            var_int = value;
            var_string = "Test String";
        }

        public ConstructorExample(int value, string value2)
        {
            var_int = value;
            var_string = value2;
        }

        // Copy Constructor
        public ConstructorExample(ConstructorExample objCE)
        {
            var_int = objCE.var_int;
            var_string = "Rajeev";
        }

        static ConstructorExample()
        {
            var_static_int = 10000;
        }
    }
}
