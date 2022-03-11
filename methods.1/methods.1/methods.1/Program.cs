using System;

namespace methods._1
{
    internal class Program
    {


        static void Main(string[] args)
        {

            //  int result = Sum(19, 7, 8);
            //  Console.WriteLine(result);

            //   string info = information("sari", 20, "toyota", 2020);
            //  Console.WriteLine(info);

            // print();

            // Console.WriteLine(academy(8,7));

            int result = fb(1, 2, 3, 7, 8);
            Console.WriteLine(result);




        }
        static int Sum(int sum1, int sum2, int sum3)
        { return sum1 + sum2 + sum3; }

        static string information(string reng, int olcu, string marka, int il)
        {

            return $"{reng} { olcu} {marka} {il}";

        }
        static void print()

        {
            Console.WriteLine("void ishleyirmi");

        }
        static int academy(int num1, int num2)
        {
            if (num2 > num1)
                return num1;

            else
                return num2;
        }

        static int fb (params int[]arr)
        {
            int sum = 0;
            foreach (int item in arr)
            {

                sum += item;
            }
            return sum;
        }

    }
            
            

            



        
        
        
            

    }

