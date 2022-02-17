using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_OOP_10_02_2022.Exercises
{
    public class Question1
    {
        public Question1()
        {

        }

        
        /* Write a program for a package delivery service. The program contains an array that holds the 
        ten zip codes to which the company delivers packages.Prompt a user to enter a zip code and
       display a message indicating whether the zip code is one to which the company delivers. */ 
        
        public void packageDeliveryservice()

        {
            Console.WriteLine("THIS IS QUESTION 1");

            string[] Eircode = { "D01", "D02", "D03", "D04", "D05", "D06", "D07", "D08", "D09", "D10"};
            int[] code = { 1,2,3,4,5,6,7,8,9,10};

            Console.WriteLine("Enter the Eircode to search for");
            string EircodeInput = Console.ReadLine();

            bool contains = false;
            int EircodeCodes = 0;
            for (int i = 0; i < Eircode.Length; i++)
            {
                if (EircodeInput == Eircode[i])
                {
                    contains = true;
                    EircodeCodes = code[i];
                    break;
                }
            }

            if (contains == true)
            {
                Console.WriteLine("Good news! We are able to deliver the package for your area :) ");
              //  Console.WriteLine("The student's grade is {0}", EircodeCodes);
            }
            else
            {
                Console.WriteLine("I'm sorry! Unfortunately at the moment we are not be able to deliver for your area");
            }
            //Console.ReadLine();

        }

    }
}
