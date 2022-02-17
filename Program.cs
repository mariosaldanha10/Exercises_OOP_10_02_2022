using System;
using Exercises_OOP_10_02_2022.Exercises;

namespace Exercises_OOP_10_02_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Question1 question1 = new();
            question1.packageDeliveryservice();

            Question2 question2 = new();
            question2.studentsScoreAverage();


            Question3 question3 = new();
            question3.gaming();
        }
    }
}
