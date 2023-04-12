////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////
//
// Project: Lab 3 – Arrays and Lists
// File Name: Driver.cs
// Description: Creates array of grades per user request, then demonstrates the same with list
// Course: CSCI 1260-001 – Introduction to Computer Science II
// Author: Justin Dubin
// Created: Tuesday, October 17, 2022
// Copyright: Justin Dubin, 2022
//
////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////
using System.Diagnostics;

namespace _1260_DubinJustin_Lab3
{
   /// <summary>
   /// Main Class of program. Holds Methods for array and list, and main method too display both
   /// </summary>
    public class Driver
    {
        /// <summary>
        ///  Method that creates array of grades, then has user enter amount of grades
        ///  they would like, displays it, and asks user for more grade before  displaying them a final time.
        ///  (Creates a copy array to have user enter more grades)
        ///  User can also change one grade to 1000 and remove one grade. 
        /// </summary>
      public static void ArrayGrades()
        {
            int GradeNumber;
            Console.WriteLine("----------------ARRAY GRADES----------------");
            Console.Write("How many grades would you like to enter? ");
            GradeNumber = Convert.ToInt32(Console.ReadLine());

            double[] ArrayGrades = new double[GradeNumber];                  //Creates new array for Grades
            double Grade = 1;
            for (int i = 0; i < GradeNumber; i++)
            {
                Console.Write("Please enter grade " + (i+1) + ": ");         //For Loop allows user to enter 
                Grade = Convert.ToDouble(Console.ReadLine());                //grades amount of time they specified
                ArrayGrades[i] = Grade;
            }
            Console.WriteLine("-------------------------------------------");

            for (int i = 0; i < GradeNumber; i++)
            {
                Console.WriteLine("Grade " + (i+1) + ": " + ArrayGrades[i]); //Displays Grades
            }
            Console.WriteLine("-------------------------------------------");

            int SecondGradeNumber;
            Console.Write("How many more grades would you like to add? ");
            SecondGradeNumber = Convert.ToInt32(Console.ReadLine());        

            double[] SecondArrayGrades = new double[ArrayGrades.Length + SecondGradeNumber];    //Creates new array
            for (int i = 0; i < ArrayGrades.Length; i++)                                        //with length of the first
            {
                SecondArrayGrades[i] = ArrayGrades[i];                      //Creates deep copy of array
            }

            int count = 0;
            for (int i = 0; i < SecondGradeNumber; i++)
            {
                Console.Write("Please enter grade " + (ArrayGrades.Length + count + 1) + ": ");
                Grade = Convert.ToDouble(Console.ReadLine());
                SecondArrayGrades[count + ArrayGrades.Length] = Grade;      //Allows user to enter more grades for amount
                count++;                                                    //of grades specified by them
            }
            Console.WriteLine("-------------------------------------------");

            int SecondCount = 0;
            for (int i = 0; i < SecondGradeNumber + GradeNumber; i++)
            {
                Console.WriteLine("Grade " + (i+1) + ": " + SecondArrayGrades[i]);  //Displays Grades
                SecondCount++;
            }
            Console.WriteLine("-------------------------------------------");

            int Index;
            Console.Write("Please enter the zero-based index of the position of the array to remove the value: ");
            Index = Convert.ToInt32(Console.ReadLine());
            SecondArrayGrades[Index] = 0;                                   //Replaces grade with 0 at user specified index

            for (int i = 0; i < SecondGradeNumber + GradeNumber; i++)
            {
                Console.WriteLine("Grade " + (i + 1) + ": " + SecondArrayGrades[i]); //Displays Grades
                SecondCount++;
            }
            Console.WriteLine("-------------------------------------------");

            Console.Write("Please enter the zero-based index of the position of the array to overwrite a value with the value 1000: ");
            Index = Convert.ToInt32(Console.ReadLine());
            SecondArrayGrades[Index] = 1000;                                //Replaces grade with 1000 at user specified index

            for (int i = 0; i < SecondGradeNumber + GradeNumber; i++)
            {
                Console.WriteLine("Grade " + (i + 1) + ": " + SecondArrayGrades[i]); //Displays Grades
                SecondCount++;
            }
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        /// <summary>
        ///  Method that creates List of grades, then has user enter as many grades as they would like, displays it,
        ///  and asks user for one more grade before displaying them a final time.
        ///  User can also change one grade to 1000, one to 2000 and remove one grade. 
        /// </summary>
        public static void ListGrades()
        {
            Console.WriteLine("----------------LIST GRADES----------------");
            Console.WriteLine("Please enter grades, or -1 to stop");

            List<double> ListGrades = new List<double>(); //Creates new list of grades
            double Grade = 1;

            while(Grade != -1)
            {
                Console.Write("Please enter grade " + (ListGrades.Count + 1) + ": ");
                Grade = Convert.ToDouble(Console.ReadLine());
                if(Grade != -1)     //If Statement allows user to enter grades until Grade = -1 through the while loop
                {
                    ListGrades.Add(Grade);
                }
                else
                {
                    //Exits while loop if Grade = -1 without adding -1 as a grade
                }
                
            }

            Console.WriteLine("-------------------------------------------");

            for (int i = 0; i < ListGrades.Count; i++)
            {
                Console.WriteLine("Grade " + (i + 1) + ": " + ListGrades[i]);   //Displays Grades
            }
            Console.WriteLine("-------------------------------------------");

            double SecondGradeNumber;
            Console.Write("Please enter another grade to add: ");
            SecondGradeNumber = Convert.ToDouble(Console.ReadLine());
            ListGrades.Add(SecondGradeNumber);                                  //Allows user to add one more grade

            Console.WriteLine("-------------------------------------------");

            for (int i = 0; i < ListGrades.Count; i++)
            {
                Console.WriteLine("Grade " + (i + 1) + ": " + ListGrades[i]);   //Displays Grades
            }
            Console.WriteLine("-------------------------------------------");
            int Index;
            Console.Write("Please enter the zero-based index of the list to remove the item: ");
            Index = Convert.ToInt32(Console.ReadLine());    //User prompted index of list
            ListGrades.RemoveAt(Index);                     //Removes Grade at user prompted index

            for (int i = 0; i < ListGrades.Count; i++)
            {
                Console.WriteLine("Grade " + (i + 1) + ": " + ListGrades[i]);   //Displays Grades
            }

            Console.WriteLine("-------------------------------------------");

            Console.Write("Please enter the zero-based index of the list to overwrite the item with the value 1000: ");
            Index = Convert.ToInt32(Console.ReadLine());
            ListGrades[Index] = 1000;                       //Changes Grade to 1000 at user prompted index

            Console.WriteLine("-------------------------------------------");

            for (int i = 0; i < ListGrades.Count; i++)
            {
                Console.WriteLine("Grade " + (i + 1) + ": " + ListGrades[i]);   //Displays Grades
            }

            Console.WriteLine("-------------------------------------------");

            Console.Write("Please enter the zero-based index of the list to overwrite the item with the value 2000: ");
            Index = Convert.ToInt32(Console.ReadLine());
            ListGrades[Index] = 2000;                       //Changes Grade to 1000 at user prompted index

            Console.WriteLine("-------------------------------------------");

            for (int i = 0; i < ListGrades.Count; i++)
            {
                Console.WriteLine("Grade " + (i + 1) + ": " + ListGrades[i]);   //Displays Grades
            }

            Console.WriteLine("-------------------------------------------");
        }
        
        /// <summary>
        /// main method calls ArrayGrades and ListGrades methods to display them to user
        /// </summary>
        public static void Main()
        {
            Driver.ArrayGrades();
            Driver.ListGrades();
        }
    }
}