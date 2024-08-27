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
            Console.Write("Enter your overall score(0-100): ");
            double grade = double.Parse(Console.ReadLine());
            char LetterGrade;

            if (grade > 89.5)
            {
                LetterGrade = 'A';
            }
            else
            {
                if (grade > 79.5)
                {
                    LetterGrade = 'B';
                }
                else
                {
                    if (grade > 69.5)
                    {
                        LetterGrade = 'C';
                    }
                    else
                    {
                        if (grade > 59.5)
                        {
                            LetterGrade = 'D';
                        }
                        else
                        {
                            LetterGrade = 'F';
                        }
                    }
                }
            }
            Console.WriteLine("Your letter grade for score " + grade + " is: " + LetterGrade );
            Console.ReadLine();
        }
    }
}