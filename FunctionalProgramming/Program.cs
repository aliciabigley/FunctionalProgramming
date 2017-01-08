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
            string student1 = "90,100,82,89,55";


            //working functions:
            learnLINQ.RemoveDublicates(stringList, listOfInts);
            learnLINQ.FindAverageOneStudent(student1);
            learnLINQ.FindLetterFrequency("Llewellyn");
            Console.ReadKey();
        }
    }
}
