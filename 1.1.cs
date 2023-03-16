using System;

namespace OOP_LB_1._1
{ 
    
    class Program
    {
        delegate int Operation(int x, int y);
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            Operation operation1 = Add;
            int Add(int x, int y) => x + y;
            int result = operation1(x, y);
            Console.WriteLine(result);

            Operation operation2 = Sub;
            int Sub(int x, int y) => x - y;
            result = operation2(x, y);
            Console.WriteLine(result);

            Operation operation3 = Mul;
            int Mul(int x, int y) => x * y;
            result = operation3(x, y);
            Console.WriteLine(result);

            Operation operation4 = Div;
            int Div(int x, int y) =>  y == 0 ? x / y : 0 ;
            result = operation4(x, y);
            Console.WriteLine(result);
        }
    }
}