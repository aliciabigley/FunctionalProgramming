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
        //Problem 2
        public void  FindAverageOneStudent(string student1)
        {
           var gradesStringToInt = (student1.Split(',').Select(int.Parse).ToList());
            var averageGrades = (from i in gradesStringToInt where i > gradesStringToInt.Min() select i).Average();
            Console.WriteLine(averageGrades);
            this.averageGrades = averageGrades;
            //return this.averageGrades;
        }

        public void AverageGradeMultipleStudents()
        {
            //double studentA = FindAverageOneStudent(string student1);
            //double studentB = FindAverageOneStudent(student2);
            //double[] collectStudentsGrades = { studentA, studentB };
            // double averageStudentGrades = collectStudentsGrades.Average();
        }
        //Problem 2 (after getting more details on the requirements)
        public void FindAverageOneStudentList(List<string> studentGrades)
        {
            foreach (string value in studentGrades)
            {
                //List<int> numberGrades = studentGrades.Select(int.Parse).ToList();// gets to Parse and throws an exception
                //var gradesStringToInt = value.Split(new[] { ',' }).Select(int.Parse).ToList();
                List<int> gradeNumbers = new List<int>();
                    foreach (int grade in gradeNumbers)
                    {
                        gradeNumbers.Add(Convert.ToInt32(gradeNumbers));
                    }
                var dropMinGrade = (from i in gradeNumbers where i > gradeNumbers.Min() select i);
            }
            //List<int> numberGrades = studentGrades.Select(int.Parse).ToList();
            ////var gradesStringToInt = student1.Split(',').Select(int.Parse).ToList();)

            //Console.WriteLine(averageGrades);
            //this.averageGrades = averageGrades;
            //return this.averageGrades;
        }
       
        //Problem 3
        public void FindLetterFrequency(string randomLetters)
        {
            string upperLetters = String.Concat(randomLetters.ToUpper().OrderBy(alphabetical => alphabetical));
            //string[] array = {upperLetters};
            var letterFrequency = from i in upperLetters.ToArray() group i by i into groupLetters select groupLetters;
            foreach (var letter in letterFrequency)
                Console.WriteLine($"Letter: {0} {letter.Key} Frequency: {letter.Count()}");
        }
        //public void AlphabeticalOrder(string randomLetters)
        //{

        //    string lowerLetters = randomLetters.ToUpper();
        //    char[] alphabetize = lowerLetters.ToCharArray();
        //    Array.Sort<char>(alphabetize);
        //    var letterCount = alphabetize.OrderBy();
        //    Console.WriteLine(letterCount);

        //}

        public void FindLetterFrequencyAlone(string randomLetters)
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

                    Console.WriteLine("{0} {1}", (char)i, letterFrequency[i]);
                }
            }
            return;
        }
    }
}

