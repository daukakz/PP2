using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine()); 

            int[] a = new int[n];           //Создали массив
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());           //В консоли вводим элементы массива
            }
            Console.WriteLine("Array: ");
            Console.WriteLine(n);
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Two times:");   

            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " " + a[i] + " ");         //Дублировали
            }

        }
    }
}