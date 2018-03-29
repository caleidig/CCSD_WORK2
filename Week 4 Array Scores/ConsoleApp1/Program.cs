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
            MultFactor< double >.Instance.SetFactor(10.0);
            Point2D<int> pt = new Point2D<int>( 1, 2 );
            Point2D<double> pt2 = new Point2D<double>( 1.0001, 2.0001 );
            Point2D<float> pt3 = new Point2D<float>( 1.0f, 2.0f );

            Console.WriteLine(pt);
            //Console.WriteLine("Mult factor = " + MultFactor<double>.Instance.GetFactor());
            int x = pt.X;
            Console.WriteLine("x = " + x);

            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Console.Write( (char)1421 );
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
                    //studentArray[counter] = input;
                //}
                counter++;
                Console.WriteLine();
            }
            Console.WriteLine();
            
            for (int i = 0; i < studentArray.Length;i++)
            {
                Console.WriteLine("Score " + (i+1) + ": " + studentArray[i]);
            }

            Console.WriteLine("Lowest Score: " + studentArray.FindMinVal());
            Console.WriteLine("Highest Score: " + studentArray.FindMaxVal());
            Console.ReadKey();

            double total = 0;
            for (int i = 0; i < studentArray.Length;i++)
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
