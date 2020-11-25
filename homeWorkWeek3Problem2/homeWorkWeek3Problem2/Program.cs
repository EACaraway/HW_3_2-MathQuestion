using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkWeek3Problem2
{
    class Program
    {   //Evan Caraway, Srinivas Reddy Doma, Kipack Jeong

        static void Main(string[] args)
        {
            int i;                                              // variable to keep track of 3 iterations (3 questions)
            for (i = 0; i < 3; i++)
            {
                if (GenerateQuestion())                             // Conditonal statements based on bool value returened by GenerateQuestion() method.
                {
                    Console.WriteLine("Congratulations!");
                }
                else
                {
                    Console.WriteLine("You answered incorrectly, pleaes try again!");
                }
            }
        }
        
        /// <summary>
        /// Generates two random integers between 100 and 999 and displays them as a formated question.
        /// </summary>
        /// <returns> bool value true or false for user input.</returns>
        static bool GenerateQuestion()                                   
        {
            Random number = new Random();
            int num1 = number.Next(100, 1000);
            int num2 = number.Next(100, 1000);

            Console.Write($@"
 {num1}
+{num2}
=====
 ");

            int.TryParse(Console.ReadLine(), out int result);   // parse user input to int.

            bool a = (result == num1 + num2);                   // Check the result and return true or false.
            return a;
                        
        }
    }
}
