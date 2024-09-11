using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    delegate int Calculations(int a, int b);
    class Operations2
    {
        public  int add(int a, int b)
        {
            return a + b;
        }
        public  int subtract(int a, int b)
        {
            return a - b;
        }
        public  int mul(int a, int b)
        {
            return a * b;
        }
        public  int div(int a, int b)
        {
            return (a / b);
        }
    }
}
