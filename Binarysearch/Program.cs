using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace Binarysearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Taulukon luonti
            int[] taul = new int[99999999];
            for (int i = 0; i < 99999999; i++)
            {
                taul[i] = i + 1;
            }
            /*Random rnd = new Random();
            for (int i = taul.Length; i > 1; i--)
            {
                int pos = rnd.Next(i);
                var x = taul[i - 1];
                taul[i - 1] = taul[pos];
                taul[pos] = x;
            }*/

            int mid, first = 0, last = taul.Length - 1;
            Console.WriteLine("Enter number:");
            int target = int.Parse(Console.ReadLine());
            var timer = System.Diagnostics.Stopwatch.StartNew();
            while (first <= last)
            {
                mid = (first + last) / 2;
                if (target < taul[mid])
                    first = mid + 1;
                if (target > taul[mid])
                    last = mid - 1;
                else
                    Console.WriteLine("Target " + target + " was found at index " + taul[mid]);
            }
            var elapsed = timer.ElapsedMilliseconds.ToString();
            Console.WriteLine("time: " + elapsed + " ms");
        }
    }
}