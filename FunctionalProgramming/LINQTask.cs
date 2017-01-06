using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class LINQTask
    {
        char [] nowAlphabetize;

        public void RemoveDublicates()
        {
            List<string> stringList = new List<string>{ "The", "The", "dog", "runs", "fast" };
            List<string> removeDuplicates = stringList.Distinct().ToList();

            List<int> listOfInts = new List<int> { 1, 2, 3, 4, 1, 2, 3, 4 };
            List<int> removeDublicates = listOfInts.Distinct().ToList();
        }
        public void FindAverage()
        {

        }

        public string[] FindLetterFrequency(string randomLetters)
        {
            int[] letterFrequency = new int[(int)char.MaxValue];
            foreach (char number in randomLetters)
            {
                letterFrequency[(int)number]++;
            }
                for (int i = 0; i < (int)char.MaxValue; i++)
                {
                    if (letterFrequency[i] > 0 && char.IsLetterOrDigit((char)i))
                    {
                        //Console.WriteLine("{0} {1}",(char)i, letterFrequency[i]);
                    }
                }        
            return nowAlphabetize;
            
        }

        public void AlphabeticalOrder()
        {
            char[] alphabetize = nowAlphabetize;
            Array.Sort<char>(alphabetize);
            Console.WriteLine(alphabetize);
            //return new string(scrambledLetters);
        }

    }
}
