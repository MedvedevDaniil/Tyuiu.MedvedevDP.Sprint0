using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MedvedevDP.Sprint0.Task6.V0.Lib;


namespace Tyuiu.MedvedevDP.Sprint0.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(DataService.AdditionArray(numsArray));
            Console.WriteLine(DataService.SubstractionArray(numsArray));
            Console.WriteLine(DataService.MultiplicationArray(numsArray));
        }
    }
}
