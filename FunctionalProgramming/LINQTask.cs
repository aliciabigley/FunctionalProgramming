using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FunctionalProgramming
{
    public class LINQTask
    {

        List<string> removeDuplicates;
        List<int> removeDublicates;
        double averageGrades;
        double classAverage;

        //Problem 1
        public void RemoveDublicates(List<string> words, List<int> numbers)
        {

            removeDuplicates = words.Distinct().ToList();
            removeDublicates = numbers.Distinct().ToList();
        }

        //Problem 2
        public void AverageStudentGrades(List<string> studentGrades)
        {
            List<double> averageAverages = new List<double>();
            //int gradesInt;
            foreach (string value in studentGrades)
            {
                List<double> studentAverage = value.Split(new[] { ',' }).Select(double.Parse).ToList();
                
                    var gradesInts = studentAverage;
                    var dropMinAve = gradesInts.OrderBy(s => s).Skip(1).Average();
                    averageAverages.Add(dropMinAve);

                
            }
            classAverage = averageAverages.Average();
            Console.WriteLine(classAverage);
        }

        //Problem 3
        public void FindLetterFrequency(string randomLetters)
        {
            string upperLetters = String.Concat(randomLetters.ToUpper().OrderBy(alphabetical => alphabetical));
            string[] array = {upperLetters};
            var letterFrequency = from i in upperLetters.ToArray() group i by i into groupLetters select groupLetters;
            foreach (var letter in letterFrequency)
                Console.Write($"{letter.Key}{letter.Count()}");
        }
    }    
}





