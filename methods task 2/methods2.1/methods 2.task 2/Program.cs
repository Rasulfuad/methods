using System;

namespace methods_2.task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Repeat deyə bir method olsun və iki parametr qəbul etsin biri "word" digəri "count" yəni bu şəkildə "Repeat(string word, int count)" bu method göndərilən word-ü göndərilən count qədər yan-yana yazdırıb geri qaytarsın. Məsələn:
Repeat("Ha!") //Ha!
Repeat("Ha!", 2) //Ha!Ha!
Repeat("Ha!", 3) //Ha!Ha!Ha! */



            string info = (repeat("word" ,2));

            Console.Write(info);




        }

        static string repeat(string word, int count)
        {
            

            for (int i = 0; i < count; i++)
            {
                
                 Console.Write(word);
                

            }

             return word ;
        }

    }
}
