using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfInts = new List<int> { 1, 2, 3, 4, 1, 2, 3, 4 };
            List<int> removeDublicates = listOfInts.Distinct().ToList();

            List<string> stringList = new List<string>(); //{ "The", "The", "dog", "runs", "fast" };
            List<string> removeDuplicates = stringList.Distinct().ToList();
        }
    }
}
