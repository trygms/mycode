using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace metot_enbuyuk_enkucuk
{
    class Program
    {
        
       private int Min(int[] sayilar)
       {
        int kucuk = sayilar[0];
 
        for (int i = 0; i < sayilar.Length; i++)
        {
            if (kucuk > sayilar[i])
            { kucuk = sayilar[i]; }
        }
        return kucuk;
       }
 
        private int Max(int[] sayilar)
        {//www.yazilimkodlama.com
         int buyuk = sayilar[0];
 
         for (int i = 0; i < sayilar.Length; i++)
         {
             if (buyuk < sayilar[i])
             { buyuk = sayilar[i]; }
         }
          return buyuk;
        }
        static void Main(string[] args)
         {//www.yazilimkodlama.com
         int[] numbers = { 54,36,25,55,88,96,32,15,17,2,100 };
         Program b = new Program();
         Console.WriteLine("Dizinin en küçük elemanı = {0}", b.Min(numbers));
         Console.WriteLine("Dizinin en büyük elemanı = {0}", b.Max(numbers));
         Console.WriteLine("======================================");
         Console.WriteLine("www.yazilimkodlama.com");
         Console.ReadKey();
         }
 
        }
    }