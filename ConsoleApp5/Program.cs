using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your overall score(0-100): "); // Askking a user for a score 
            double grade = double.Parse(Console.ReadLine()); // Reading user input then changing it to a doudble and storing it into variable "grade"
            char LetterGrade; // Declaring the LetterGrade as char

            if (grade > 89.5) // if grade is greater than 89.5 then letterGrade is "A"
            {
                LetterGrade = 'A';
            }
            else
            {
                if (grade > 79.5)// if grade is greater than 79.5 then letterGrade is "B"
                {
                    LetterGrade = 'B';
                }
                else
                {
                    if (grade > 69.5)// if grade is greater than 69.5 then letterGrade is "C"
                    {
                        LetterGrade = 'C';
                    }
                    else
                    {
                        if (grade > 59.5)// if grade is greater than 59.5 then letterGrade is "D"
                        {
                            LetterGrade = 'D';
                        }
                        else
                        {
                            LetterGrade = 'F';// if grade is less or equal to 59.5 then letterGrade is "F"
                        }
                    }
                }
            }
            Console.WriteLine("Your letter grade for score " + grade + " is: " + LetterGrade);// This Displays the grade and letter into one sentence to let you known score and the lettergrade u get.
            Console.ReadLine();
        }
    }
}