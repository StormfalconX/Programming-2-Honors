using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Password_Generator_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Generate();
            Console.ReadLine();
            Environment.Exit(0);
        }

        public static void Generate()
        {
             string strPassword = string.Empty;
            Random rPick = new Random();
                Random rUpper = new Random();
                Random rLower = new Random();
                Random rNum = new Random();

            string length = string.Empty;
            int lengthNum = 0;
            Console.WriteLine("how long do you want your password");
            length = Console.ReadLine();
            lengthNum = Convert.ToInt16(length);

            bool blnUpper = false;
            bool blnLower = false;
            bool blnNum = false;

            do
            {
                int i = rPick.Next(1, 4);

                if (i == 1)
                {
                    strPassword += (char)('A' + rUpper.Next(0, 26));
                    blnUpper = true;
                }
                else if (i == 2)
                {
                    strPassword += (char)('a' + rLower.Next(0, 26));
                    blnLower = true;
                }
                else
                {
                    strPassword += (int)('1' + rNum.Next(1, 10));
                    blnNum = true;
                }
            } while (strPassword.Length < lengthNum);

            if (blnLower == true & blnNum == true & blnUpper == true)
            {
                Console.WriteLine("the password is " + strPassword);
            }

            else
            {
                Generate();
            }
            
        }
    }
}

