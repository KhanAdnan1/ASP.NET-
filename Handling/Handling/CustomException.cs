using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handling
{
    class InvalidAgeException: Exception
    {
        public InvalidAgeException()
        {
            Console.WriteLine("Invalid age Exception");
        }
    }
    class CustomException 
    {
        public void CheckAge()
        {
            int a = 16;
            try
            {
                if (a <= 18)
                {
                    throw new InvalidAgeException();
                }
                else
                {
                    Console.WriteLine("You are elligible");
                }
            }
            catch(InvalidAgeException )
            {
                //
            }
            
        }
    }
}
