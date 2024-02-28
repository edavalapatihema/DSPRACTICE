using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPRACTICE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] selection_sort_numbers = { 5, 62, 5, 16, 4, 10 };

            Console.WriteLine("Here is the original array that will be used to execute the Bubble Sort Algorithm: ");
            for (int i = 0; i < selection_sort_numbers.Length; i++)
            {
                Console.Write("  " + selection_sort_numbers[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("Here is the array after the execution of the Bubble Sort Algorithm: ");
            Selection_Sort(selection_sort_numbers);
            for (int i = 0; i < selection_sort_numbers.Length; i++)
            {
                Console.Write("  " + selection_sort_numbers[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("Press any key to exit the program ...");
            Console.ReadKey(true);
        }

        private static void Selection_Sort(int[] bs_arr)
        {

            for (int i = 0; i < bs_arr.Length - 1; i++)
            {
                for (int x = 0; x < bs_arr.Length - i - 1; x++)
                {

                    if (bs_arr[x] > bs_arr[x + 1])
                    {

                        int temp = bs_arr[x];
                        bs_arr[x] = bs_arr[x + 1];
                        bs_arr[x + 1] = temp;
                    }
                }
            }

        }
    }
}
