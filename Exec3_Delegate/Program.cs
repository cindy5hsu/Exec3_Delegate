using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec3_Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> items = new List<int> { 1, 5, 3, 22, 6, 8, 10, 11 };
            Func<int, bool> isEven = n => n % 2 == 0;

            List<int> EvenItems = GetEvenItems(items, isEven);
            foreach (var item in EvenItems)
            {
                Console.WriteLine(item);
            }
           
        }
        static List<int> GetEvenItems(List<int> source, Func<int, bool> func)
        {
            var result = new List<int>();

            foreach (int item in source)
            {
                if (func(item) == true)
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}
