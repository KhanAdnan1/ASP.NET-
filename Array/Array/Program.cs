using Array;

class MainClass
{
    static void Main(string[] args)
    {
        Arr obj = new Arr();
        obj.Array();
        obj.Array2();

        var emp=new List<Emp>();
        emp.Add(new Emp(03,"Sadan",02358632,12500));
        emp.Add(new Emp(04, "Rehan", 02358632, 12500));
        emp.Add(new Emp(05, "Faizan", 02358632, 12500));

        foreach(var item in emp)
        {
            Console.WriteLine(item.Name);
        }

        Dict dict=new Dict();
        dict.Dictonary();

        Par par=new Par();
        par.Add(4, 2);
        par.Sub(7, 1);
        par.Mul(3, 2);

    }
}