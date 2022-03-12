using System;

namespace method_2_task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Sahe deyə Method(lar) yaradılır.
Çevrənin sahəsi -S = p * r² (p = 3)
Düzbucaqlının sahəsi -S = a * b
Üçbucaqlının daxilinə çəkilmiş çevrənin sahəsi - S = p * r; p = (a + b + c) / 2 */


            //   int result = (DuzbucaqSahesi(8, 7));
            //  Console.WriteLine(result);

            //  int result = (cevreninsahesi(4));
            //  Console.WriteLine(result);


            int result = (ucbucaqcevresahesi(8, 6, 4));
            Console.WriteLine(result);


        }
        static int DuzbucaqSahesi(int num1, int num2)
        {
            return num1 * num2;
        }
        static int cevreninsahesi(int num1)
        {
            int num2 = 3;
            return num2 * num1 * num1;
        }

        static int ucbucaqcevresahesi(int num1,int num2,int num3)
        {
            int num4 = 3;
            return (num1 + num2 + num3) / 2 * num4;




        }





    }
}
