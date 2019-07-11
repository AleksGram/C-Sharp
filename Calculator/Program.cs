using System;
using System.Data;

namespace Calculator
{
    class Claculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose operation: ");
            Console.WriteLine("+ : ");
            Console.WriteLine("- : ");
            Console.WriteLine("/ : ");
            Console.WriteLine("* : ");
            var operation = Console.ReadLine();

            Console.WriteLine("Please type first number: ");
            var number1 = Console.ReadLine();

            Console.WriteLine("Please type second number: ");
            var number2 = Console.ReadLine();

            var resExpres = $"{number1}{operation}{number2}";

            object value = new DataTable().Compute(resExpres , null);
            string res=value.ToString();//res=6
            Console.WriteLine($"Res exp: {resExpres} = {res}");
        }
    }
}

