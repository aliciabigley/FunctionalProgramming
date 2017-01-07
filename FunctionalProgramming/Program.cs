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
            LINQTask learnLINQ = new LINQTask();
            List<string> stringList = new List<string> { "The", "The", "dog", "runs", "fast" };
            List<int> listOfInts = new List<int> { 1, 2, 3, 4, 1, 2, 3, 4 };

            learnLINQ.RemoveDublicates(stringList,listOfInts);
            //learnLINQ.FindLetterFrequency("Llewellyn");
            //learnLINQ.AlphabeticalOrder();
           //learnLINQ.TestMethod();
            Console.ReadKey();
        }
    }
}
