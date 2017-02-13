using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Password_Generator_v1
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rNum = new Random();
            string strPassword = string.Empty;

            while (strPassword.Length < 8)
            {
                //strPassword += rNum.Next(1, 10).ToString();

                strPassword += (char)('a' + rNum.Next(1,10));
            }

            Console.WriteLine("Your password is " + strPassword);
            
            Console.ReadLine();

        }
    }
}
