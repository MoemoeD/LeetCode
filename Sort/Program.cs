using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 53, 25, 99, 22, 21, 5, 63, 46 };
            int[] output = QuickSort(input);

            foreach (var i in output)
            {
                Console.Write(i.ToString() + ",");
            }

            Console.ReadKey();
        }

        public static int[] BubbleSort(int[] input)
        {
            int temp = 0;
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 1; j < input.Length - i; j++)
                {
                    if (input[j - 1] > input[j])
                    {
                        temp = input[j - 1];
                        input[j - 1] = input[j];
                        input[j] = temp;
                    }
                }
            }
            return input;
        }

        public static int[] SelectionSort(int[] input)
        {
            int temp = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int index = i;
                for (int j = i; j < input.Length; j++)
                {
                    if (input[index] > input[j])
                    {
                        index = j;
                    }
                }
                temp = input[i];
                input[i] = input[index];
                input[index] = temp;
            }
            return input;
        }

        public static int[] InsertionSort(int[] input)
        {
            int temp = 0;
            for (int i = 1; i < input.Length; i++)
            {
                int j = i;
                temp = input[j];
                while (j >= 1 && input[j - 1] > temp)
                {
                    input[j] = input[j - 1];
                    j--;
                }
                input[j] = temp;
            }
            return input;
        }

        public static int[] QuickSort(int[] input)
        {
            qs(input, 0, input.Length - 1);

            return input;
        }

        public static void qs(int[] input, int l, int r)
        {
            if (l < r)
            {
                int i = l;
                int j = r;
                int num = input[l];
                while (i < j)
                {
                    while (i < j && num < input[j])
                    {
                        j--;
                    }
                    if (i < j)
                    {
                        input[i] = input[j];
                        i++;
                    }

                    while (i < j && num > input[i])
                    {
                        i++;
                    }
                    if (i < j)
                    {
                        input[j] = input[i];
                        j--;
                    }
                }
                input[i] = num;

                qs(input, l, i - 1);
                qs(input, i + 1, r);
            }
        }
    }
}
