using System;

namespace methods2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Bir method olsun iki parametr qəbul etsin və bu parametrlərdən birincini ikinciyə bölüb nəticəni geri qaytarsın. */
            int result = (Divide(24, 8));
            Console.WriteLine(result);
        }
    
    static int Divide(int bolunen,int bolen)
        {
            return bolunen /bolen;
        }
    
    
    
    
    
    
    }
}
