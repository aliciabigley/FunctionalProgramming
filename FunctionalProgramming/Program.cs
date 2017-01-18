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
            List<string> classGrades = new List<string>{ "80,100,92,89,65","93,81,78,84,69","73,88,83,99,64", "98,100,66,74,55"};
            string[] classGrades2 = new string[] { "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55" };
           

            //working functions:
           //learnLINQ.RemoveDublicates(stringList, listOfInts);
           //learnLINQ.FindLetterFrequency("ttdvhyjmhgtesxghy");
           learnLINQ.AverageStudentGrades(classGrades);
            
            Console.ReadKey();
        }
    }
}
