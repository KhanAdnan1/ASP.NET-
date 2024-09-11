using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Dict
    {
        public void Dictonary()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(102, "David");
            dict.Add(103, "Raj");
            dict.Add(104, "Sam");

            foreach (KeyValuePair<int, string> kvp in dict)
            {
                Console.WriteLine(kvp.Key+": " + kvp.Value);
            }
        }
    }
}
