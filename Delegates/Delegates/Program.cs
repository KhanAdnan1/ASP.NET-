using Delegates;
class Test
{
    static void Main(string[] args)
    {
        Calculation add = new Calculation(Operations.add);
        Console.WriteLine(add(5, 2));

        Calculation sub = new Calculation(Operations.subtract);
        Console.WriteLine(sub(8,1));

        Calculation mul = new Calculation(Operations.mul);
        Console.WriteLine(mul(8,2));

        Calculation div = new Calculation(Operations.div);
        Console.WriteLine(div(4,2));

        Operations2 obj = new Operations2();

        Calculations c1 = new Calculations(obj.add);
        Console.WriteLine(c1(5, 6));

        Calculations c2 = new Calculations(obj.subtract);
        Console.WriteLine(c2(6,5));

        Calculations c3 = new Calculations(obj.mul);
        Console.WriteLine(c3(5, 6));

        Calculations c4 = new Calculations(obj.div);
        Console.WriteLine(c4(10,2));
    }
}