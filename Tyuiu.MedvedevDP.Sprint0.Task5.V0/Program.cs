using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MedvedevDP.Sprint0.Task5.V0.Lib;

namespace Tyuiu.MedvedevDP.Sprint0.Task5.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(1, 5));
            Console.WriteLine(DataService.Substraction(1, 5));
            Console.WriteLine(DataService.Multiplication(1, 5));
            Console.WriteLine(DataService.Division(1, 5));
            Console.WriteLine(DataService.Division(1, 0));
        }
    }
}
