using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenge_Console
{
    class Program
    {
        static void Main(string[] args)
        {

            int flag = 0;
            int counter = 0;

            string tempGrade = string.Empty;

            double totalValue = 0;
            double averageValue = 0;

            do
            {
                
                Console.WriteLine("Add grades until you stop at -1");
                tempGrade = Console.ReadLine();
                try
                {
                    if (Convert.ToDouble(tempGrade) == -1)
                    {
                        flag = -1;
                        
                        averageValue = totalValue / counter;
                        Console.WriteLine("your average is " + averageValue.ToString("##.##"))
                            ;

                        Console.ReadLine();
                    }
                    else
                    {
                        totalValue += Convert.ToDouble(tempGrade);
                        counter++;
                    }

                    
                }

                catch
                {
                    Console.WriteLine("enter a number");
                }

            } while (flag != -1);

           
        }
    }
}
