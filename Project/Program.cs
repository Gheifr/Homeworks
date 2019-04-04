using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            //for (; ; )
            //{
            //    Console.WriteLine("bla bla bla");
            //}

            int StartNum = int.Parse(Console.ReadLine());
            int EndNum = int.Parse(Console.ReadLine());

            if (StartNum > EndNum)
            {   
                return;
            }

            int Sum=0;

            for (int i =StartNum;i<=EndNum;i++)
            {
                if (i%2!=0)
                {
                    Sum += i;
                }

            }

            int[] myArray = new int [100];
            for(int i = 0; i < 100; i++)
            {
                myArray[i] = RandomNumber(-100,100);
            }

            
            Console.WriteLine("Average num is "+ Average(myArray));

            
                int maxVal = myArray[0];
                int minVal = myArray[0];

            for (int i = 0; i <= myArray.Length - 1; i++)
                {
                    if (maxVal > myArray[i])
                    {
                        maxVal = myArray[i];
                    }
                    if (minVal < myArray[i])
                    {
                        minVal = myArray[i];
                    }
                }
            Console.WriteLine("Max num is " + maxVal);
            Console.WriteLine("Min num is " + minVal);


            int Average(int [] arr)
            {
                int sum=0;

                for (int i=0;i<=arr.Length-1;i++)
                {
                    sum += arr[i];
                }
                return sum / (arr.Length);
            }

            int RandomNumber(int min, int max)
            {
                Random random = new Random();
                return random.Next(min, max);
            }
        }
    }
}
