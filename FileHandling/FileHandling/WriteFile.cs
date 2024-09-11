using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Handling
{
    class  WriteFile
    {
       public void CreatData()
        {
            FileStream fs = new FileStream("D://File/file.txt", FileMode.Create);
            StreamWriter sm = new StreamWriter(fs);
            sm.WriteLine("I'M Adnan Khan");
            Console.WriteLine("File created successfully");
            sm.Close();
            fs.Close();
        }

      

    }
}
