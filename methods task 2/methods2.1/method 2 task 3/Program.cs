using System;

namespace method_2_task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir method olsun göndərilən "n" sayda ədədin hamsını toplayıb geri qaytarsın.
            int result = coxluq(new int[] { 3, 5, 8, 11 });

            Console.WriteLine(result);



        }

        static int coxluq(int[] array)
        {
            int num = 0;
            foreach (int item in array)
             num += item;
            return num; 
        }
         
    } 
}
