using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hello_and_Name___1st_console
{
    class Program
    {
        static void Main(string[] args)
        {
            string strName = string.Empty;
            
            Console.WriteLine("Hello, what is your name?");
            strName = Console.ReadLine();
            Console.WriteLine("Hi " + strName + "!");

            int i = 0;

            string temporaryNumber = string.Empty;
            string userSetNumber = string.Empty;

            double Counter = 0;
            double gradeTotal = 0;
            double Average = 0;

            Console.WriteLine("how many grades are you going to add");
            userSetNumber = Console.ReadLine();

            Counter = Convert.ToDouble(userSetNumber);


            while (i < Counter)
            {
                Console.WriteLine("Enter a grade.");
                temporaryNumber = Console.ReadLine();

                try
                {
                    gradeTotal += Convert.ToDouble(temporaryNumber);
                }//try

                catch
                {
                    Console.WriteLine("enter a number" + "\n");
                    i = i - 1;
                }//catch
                i++;
            }//while 

            Average = gradeTotal / Counter;

            Console.WriteLine("Your average for this semester is " + Average.ToString("##.##"));

            Console.ReadLine();
        }
    }
}
