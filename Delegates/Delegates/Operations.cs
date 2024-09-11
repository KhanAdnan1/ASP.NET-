using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    delegate int Calculation(int a, int b);
    class Operations
    {
        public static int add(int a, int b) 
        {
            return a + b;
        }

        public static int subtract(int a, int b) 
        {
            return a - b;
        }

        public static int mul(int a, int b) 
        { 
            return a * b;
        }

        public static int div(int a, int b) 
        {
            return (a / b); 
        }
    }
}
