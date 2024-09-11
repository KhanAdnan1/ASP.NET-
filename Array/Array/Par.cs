using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Array
{
    partial class Par
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
    partial class Par
    {
        public void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
    }
    partial class Par
    {
        public void Mul(int a, int b)
        {
            Console.WriteLine(a*b);
        }
    }
}
