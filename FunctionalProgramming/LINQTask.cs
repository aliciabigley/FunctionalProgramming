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

        //Problem 1
        public void RemoveDublicates(List<string> words, List<int> numbers)
        {
            
            removeDuplicates = words.Distinct().ToList();
            removeDublicates = numbers.Distinct().ToList();           
        }
        //string[] records = new[] { record1, record2 };
        //string record = records.FirstOrDefault(r => r.Split(',').Any(s => s == "1"));

        //Problem 2
        public void AverageStudentGrades(List<string> studentGrades)
        {
            List<double> averageAverages = new List<double>();
            int gradesInt;
            
            foreach (string value in studentGrades)
            {
                var gradesToInteger = value.Split(new[] { ',' }).ToList();
                //list of ints 
                List<int> studentAverage = studentGrades.Select(int.Parse).ToList();
                foreach (int x in value)
                {
                    int gradesInts = studentAverage.OrderBy(s => s.value).Skip(1).Average();
                   
                    //split at comma
                    //= gradesString.OrderBy().Skip(1).Average();
                    //return gradesInts;
                    averageAverages.Add(gradesInts);
                }
                Console.WriteLine(averageAverages.Average()); 
                //Add.StudentAverage To AverageAverages.Average();
                //.ToList();
                //List<int> gradeNumbers = new List<int>();
                //foreach (int grade in gradeNumbers)
                //{
                //    gradeNumbers.Add(Convert.ToInt32(gradeNumbers));
                //}
                //var dropMinGrade = (from i in gradeNumbers where i > gradeNumbers.Min() select i);
            }
            //List<int> numberGrades = studentGrades.Select(int.Parse).ToList();
            //var gradesStringToInt = student1.Split(',').Select(int.Parse).ToList();


        }

        //Problem 3
        public void FindLetterFrequency(string randomLetters)
        {
            string upperLetters = String.Concat(randomLetters.ToUpper().OrderBy(alphabetical => alphabetical));
            //string[] array = {upperLetters};
            var letterFrequency = from i in upperLetters.ToArray() group i by i into groupLetters select groupLetters;
            foreach (var letter in letterFrequency)
                Console.Write($"{letter.Key}{letter.Count()}");
        }
       
    }
}


