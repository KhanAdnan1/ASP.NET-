using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Handling
{
    [Serializable]
    class Emp
    {
        int empId;
        string name;
        string contact;
        double salary;

        public Emp(int empId, string name, string contact,double salary)
        {
            this.empId = empId;
            this.name = name;
            this.contact = contact;
            this.salary = salary;

        }

    }
}
