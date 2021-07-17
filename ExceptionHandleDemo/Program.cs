using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //continuously accepting 2 int....find sum
            int fno, sno, sum;
            while(true)
            {
                try
                {
                    System.Console.Write("enter first number");
                    fno = int.Parse(Console.ReadLine());

                    System.Console.Write("enter second number");
                    sno = int.Parse(Console.ReadLine());

                    sum = fno + sno;

                    Console.WriteLine($"the sum of {fno} and {sno} is {sum}");
                }
                catch(FormatException ex)
                {
                    //execute only if FormatException
                    Console.WriteLine("Please enter only integer");
                }
                //catch(OverflowException ex)
                //{
                //    Console.WriteLine("Please enter small integer number");
                //}
                catch(Exception ex) //catch All remaining error
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    //clean up code
                }
            }
        }
    }
}
