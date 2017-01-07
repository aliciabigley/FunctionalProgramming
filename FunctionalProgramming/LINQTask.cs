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

        public void RemoveDublicates(List<string> words, List<int> numbers)
        {
            
            List<string> removeDuplicates = words.Distinct().ToList();
            List<int> removeDublicates = numbers.Distinct().ToList();           
        }
        public void FindAverage(List<string> grades) 
        {

            List<string> averagedGrades = grades.Average().ToList();


    }

    // public char[] FindLetterFrequency(string randomLetters)
    //{
    //    int[] letterFrequency = new int[(int)char.MaxValue];
    //    foreach (char number in randomLetters)
    //    {
    //        letterFrequency[(int)number]++;
    //    }
    //        for (int i = 0; i < (int)char.MaxValue; i++)
    //        {
    //            if (letterFrequency[i] > 0 && char.IsLetterOrDigit((char)i))
    //            {

    //             Console.WriteLine("{0} {1}",(char)i, letterFrequency[i]);
    //            }
    //        }        
    //    return nowAlphabetize;

    //}

    public void AlphabeticalOrder()
        {
            //string randomLetters = "Llewellyn";
            //string lowerLetters = randomLetters.ToUpper();

            //char[] alphabetize = lowerLetters.ToCharArray();
            ////Array.Sort<char>(alphabetize);

            //var letterCount = alphabetize.OrderBy()

            //Console.WriteLine(alphabetize);
            ////return new string(scrambledLetters);
        }
        //public void TestMethod()
        //{
        //    {
        //        // Input array.
        //        string[] array = { "the", "glass", "bead", "game" };

        //        // Order alphabetically by reversed strings.
        //        var result = array.OrderBy(a => new string(a.ToCharArray().Reverse().ToArray()));

        //        // Display results.
        //        foreach (var item in result)
        //        {
        //            Console.WriteLine(item);
        //        }
        //   }
        //}

    }
}
