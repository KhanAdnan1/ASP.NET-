using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Handling
{
    class ReadData
    {
        public void Read()
        {
            FileStream fs = new FileStream("D://File/file.txt", FileMode.OpenOrCreate);
            StreamReader sm = new StreamReader(fs);
            string data = "";
            while ((data= sm.ReadLine())!=null)
            {
                Console.WriteLine(data);

            }
            sm.Close();
            fs.Close();
        }
    }
}
