using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FunctionalProgramming
{
    public class LINQTask
    {
        //char [] nowAlphabetize;
        List<string> removeDuplicates;
        List<int> removeDublicates;
        double averageGrades;

        public void RemoveDublicates(List<string> words, List<int> numbers)
        {
            
            removeDuplicates = words.Distinct().ToList();
            removeDublicates = numbers.Distinct().ToList();           
        }
        public double  FindAverageOneStudent(string student1)
        {
           var gradesStringToInt = (student1.Split(',').Select(int.Parse).ToList());
            var averageGrades = (from i in gradesStringToInt where i > gradesStringToInt.Min() select i).Average();
            Console.WriteLine(averageGrades);
            this.averageGrades = averageGrades;
            return this.averageGrades;
        }

        //public void AverageGradeMultipleStudents(double this.averageGrade, int studentB)
        //{
        //    double[] collectStudentsGrades = { studentA, studentB };
        //    double averageStudentGrades = collectStudentsGrades.Average();
        //}


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

        //public void AlphabeticalOrder()
        //    {
        //string randomLetters = "Llewellyn";
        //string lowerLetters = randomLetters.ToUpper();

        //char[] alphabetize = lowerLetters.ToCharArray();
        ////Array.Sort<char>(alphabetize);

        //var letterCount = alphabetize.OrderBy()

        //Console.WriteLine(alphabetize);
        ////return new string(scrambledLetters);
        // }
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
