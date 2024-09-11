using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Array
{
    class Arr
    {
        public void Array()
        {
            ArrayList item = new ArrayList();
            item.Add(01);
            item.Add("Adnan");
            item.Add(1234567890);
            item.Add(12500.30);
            foreach( var i in item)
            {
                Console.WriteLine(i);
            }
        }
        public void Array2() 
        { 
            ArrayList item=new ArrayList() { 02,"Arsk",0987654321,50000023};
            foreach( var i in item)
            {
                Console.WriteLine(i);
            }
        }

    }
}
