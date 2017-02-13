using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            bool check = false;

            Console.WriteLine("enter the password");

            do 
            {
            
            string strPassword = Console.ReadLine();

            counter++;

            if (strPassword == "Example")
            {
                Console.WriteLine("correct");
                check = true;
                Console.ReadLine();
            }

            else
            {

                if (counter == 3)
                {
                    Console.WriteLine("Locked out. See admin");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Password is incorrect. Try again......");
                }
            }
            
            } while (counter < 3 & check == false);

        }
    }
}
