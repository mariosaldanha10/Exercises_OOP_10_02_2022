using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program that allows a teacher to enter in a N-number of students. For each student
ask the teacher to enter in their name and final score for the class. When the teacher is done
entering the data, print the highest grade in the class, and the average grade for the class.*/

namespace Exercises_OOP_10_02_2022.Exercises
{
    public class Question2
    {
        public Question2()
        {

        }

        public void studentsScoreAverage()
        {
            Console.WriteLine("THIS IS QUESTION 2");

            
            double averageScore = 0;
            string student1, student2, student3;

            Console.WriteLine("Type students' name and their final score");
            Console.WriteLine();

            student1 = Console.ReadLine();
            int score1 = Convert.ToInt32(Console.ReadLine());

            student2 = Console.ReadLine();
            int score2 = Convert.ToInt32(Console.ReadLine());

            student3 = Console.ReadLine();
            int score3 = Convert.ToInt32(Console.ReadLine());

            if (score1 > score2)
            {

                if (score1 > score3)
                {
                    Console.WriteLine("The highest grade in the class is : " + score1);
                }
                else
                {
                    Console.WriteLine("The highest grade in the class is : " + score3);
                }
            }
            else
            {
                if (score2 > score3)
                {
                    Console.WriteLine("The highest grade in the class is : " + score2);
                }
                else
                {
                    Console.WriteLine($"The highest grade in the class is : " + score3);


                }
            }
            averageScore = (score1 + score2 + score3) / 3;

            Console.WriteLine($"The average grade for the class is : {averageScore} ");


        }

    }   
}
