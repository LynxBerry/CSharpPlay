using System;
using System.Collections.Generic;
using System.Linq;
namespace _2019_08_19_Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = {2, 3, 4, 5};
            IEnumerable<int> query = testArray.Take(2);
            int res = Array.BinarySearch(testArray,3);
            query.Select(x=>"xx").ToList().ForEach(x=>Console.WriteLine($"{x}"));
            
            bool test = testArray.Any();

            Console.Write("");
        }
    }
}
