using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarynumberConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("input a number: ");
            //int number = int.Parse(Console.ReadLine());
            //int max = 0;
            //int count = 0;
            //int reminder = 0;

            //while(number>0)
            //{
            //    reminder = number % 2;
            //    number /= 2;
            //    if (reminder==1)
            //    {
            //        count++;
            //        max = Math.Max(max, count);
            //    }
            //    else
            //    {
            //        count = 0;
            //    }
            //}

            //Console.WriteLine(max);


            int number = Convert.ToInt32(Console.ReadLine());
            int reminder = 0;

            
            reminder = number % 2;
            number /= 2;
            
            Console.WriteLine(number);
            Console.ReadLine();
        }
    }
}
