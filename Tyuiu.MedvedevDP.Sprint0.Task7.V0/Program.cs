using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MedvedevDP.Sprint0.Task7.V0.Lib;

namespace Tyuiu.MedvedevDP.Sprint0.Task7.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNums1 = new int[] { 1, 2, 3, 4, 5 };

            for (int i = 0; i < arrayNums1.Length; i++)
            {
                Console.WriteLine(arrayNums1[i]);
            }
            Console.WriteLine();
            int[] arrayNums2 = new int[] { 1, 2, 3, 4, 5 };

            for (int i = 0; i < arrayNums2.Length; i++)
            {
                Console.WriteLine(arrayNums2[i]);
            }
            if (arrayNums1.Length == arrayNums2.Length)
            {
                int[] resultArray = DataService.AdditionArrays(arrayNums1, arrayNums2);
                for (int i = 0; i < resultArray.Length;i++)
                {
                    Console.WriteLine(resultArray[i]);
                }
            }
            else
            {
                Console.WriteLine("Oshibka");
            }
        }
    }
}
