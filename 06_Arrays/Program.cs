using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region temel dizi örnekleri
            //değişkentürü[] diziadı =new değişkentürü[elemansayısı]
            //string[] colors = new string[4];
            //colors[0] = "kırmızı";
            //colors[1] = "sarı";
            //colors[2] = "beyaz";
            //colors[3] = "mavi";
            //Console.WriteLine(colors[2]);  

            //int[] numbers=new int[10];
            //numbers[0] = 100;
            //numbers[1] = 10;
            //numbers[2] = 20;
            //numbers[3] = 30;
            //numbers[7] = 70;
            //Console.WriteLine(numbers[7]);

            //string[] cities = { "ist", "ankara", "esk", "kocaeli" };
            //Console.WriteLine(cities[3]);
            #endregion

            #region dizideki elemanları listeleme

            //string[] colors = { "sarı", "kırmızı", "siyah", "beyaz", "yeşil", "pembe", "turuncu" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };

            //int maxNumber = myArray[0];
            //for (int i = 0; i <= myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber) 
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);????

            //string[] person = { "ali", "ayşe", "ahmet", "mehmet" };
            //Console.WriteLine(person.Length);

            //int[] numbers = { 45, 85, 52, 41, 86 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 45, 85, 52, 41, 86 };
            //Array.Reverse(numbers);// komple tersten 864152
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}



            #endregion


            #region dizi metodları
            //string[] customers = { "ali", "buse", "ayşe", "merve", "çınar", "kaya" };
            //int index = Array.IndexOf(customers, "merve"); //index sırası
            //Console.WriteLine(index);   

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            //Console.WriteLine("en büyük eleman :"+ numbers.Max() + "en küçük:"+numbers.Min());



            #endregion

            #region kullanıcıdan değer al
            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++) 
            //{
            //    Console.WriteLine($"lütfen {i+1}.şehri giriniz:");//

            //    cities[i] = Console.ReadLine();

            //}
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------");
            //for (int i = 0;i < cities.Length; i++) 
            //{
            //    Console.WriteLine(cities[i]);
            //}


            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{ 
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            //int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 746, 39, 220 };
            //Console.WriteLine("çiftler");
            // for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }

            //}

            //Console.WriteLine("tekler");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2==1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }

            //}



            #endregion


            Console.Read();
        }
    }
}
