using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Scores Below. Any input outside of 1-10 will show results.");
            Console.WriteLine();
            DynamicArray studentArray = new DynamicArray();
            double input=25;
            int counter = 0;
            while (input != 0)
            { 

                Console.Write("Enter score #" + (counter+1) + ": ");

                input = Convert.ToDouble(Console.ReadLine());
                
                if (input < 1 || input > 10)
                { break; }
                //if (studentArray.Length <= counter+1)
                    studentArray.AddToArray(input);
                //else
                //{
                    studentArray[counter] = input;
                //}
                counter++;
                Console.WriteLine();
            }
            Console.WriteLine();
            
            for (int i = 0; i < studentArray.Length-1;i++)
            {
                Console.WriteLine("Score " + (i+1) + ": " + studentArray[i]);
            }

            Console.WriteLine("Lowest Score: " + studentArray.FindMinVal());
            Console.WriteLine("Highest Score: " + studentArray.FindMaxVal());
            Console.ReadKey();

            double total = 0;
            for (int i = 0; i <= studentArray.Length-1;i++)
            {
                total += studentArray[i];
            }
            total -= studentArray.FindMaxVal();
            total -= studentArray.FindMinVal();
            Console.WriteLine("total: " + total);
            Console.WriteLine("# scores: " + (studentArray.Length-3));
            Console.WriteLine("The Average without the Highest and Lowest grade is: " + (total / (studentArray.Length - 3)));
            Console.ReadKey();
        }
    }
}
