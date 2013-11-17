using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace ConsoleArrayListPractice
{
    class Program
    {
        static void Main(string[] args) 
        {
            //Declare variables
            String sUserResp = String.Empty;
            Double dIndivGrade = 0.0;
            Double dAverage = 0.0;
            Double dSum = 0.0;
            ArrayList oGradesList = new ArrayList(); /* o Declares it's an object */

            //Get the first grade
            Console.Write("\nEnter a grade in 00.0 format (press <enter> by itself to exit): "); /* As long as there is a response we want the loop to continue */
            sUserResp = Console.ReadLine();

            while (sUserResp != String.Empty) /*While the string that we've declared empty is not empty the program will repeat */
            {
                try
                {
                    dIndivGrade = Convert.ToDouble(sUserResp); /*Converts what the user has enter to a Double, and assigns it to dIndivGrade */
                }
                catch (Exception ex) /*Catches errors in dIndivGrade (such as not entering a number and enter a letter instead) */
                {
                    Console.WriteLine("I'm sorry, but an error has occcurred: \n" + ex.Message);
                    Console.WriteLine("This program will exit. Press the <enter> key to close this window.");
                    Console.WriteLine();
                    return;
                }

                dIndivGrade /= 100.0; /*Takes the value in dIndivGrade, divides it by 100.0, and then assigns back into dIndivGrade */
                oGradesList.Add(dIndivGrade); /*Add dIndivGrade into the array list as a generic object */

                Console.Write("\nPlease enter another grade: (Press <enter> by itself to end grade entry): ");
                sUserResp = Console.ReadLine();
            } //end of the while loop allowing grades to be entered

            if (oGradesList.Count == 0) /*If the number of grades equals 0, closes out the program*/
            {
                Console.WriteLine("You have entered no grades to be averaged.");
                Pause("Press the enter key to close this window.");
                return;
            }
            else if (oGradesList.Count == 1) /*If the number of grades entered equals 1 averages the one grade and is the same as the grade entered */
            {
                dAverage = (Double)oGradesList[0];
            }
            else
            {
                for (Int32 i = 0; i < oGradesList.Count; i++) /*Count the grades that you've entered */
                {
                    dIndivGrade = (Double)oGradesList[i]; /*An explicit cast to double, the program won't let you not do it, Takes the number oGradesList and puts in dIndivGrade */
                    dSum += dIndivGrade; /*Adds the value in dSum to dIndividualGrade, then assigns it back to dSum */
                }
                dAverage = dSum / (Double)oGradesList.Count; /*dSum hold the sum of all grades, then divdes dSum by oGradesList, then assigns to dAverage */
            }

            Console.WriteLine("\nYour grade average is {0:P}:", dAverage); /*The 0 in {0:P} is the index pointing to dAverage, the P makes it show in percentage 0.00 */
            Pause("Press any key to exit this window. ");
        } //end of method main

        static void Pause(String strMessage)
        {
            Console.WriteLine(strMessage);
            Console.ReadLine();
        }
    }
}
