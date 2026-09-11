using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Merge_e_Algoritmos
{
    internal class Sort
    {
        public void PrintArray<T>(T[] array)
        {
            Console.Write("[");
            int ind_i = 0;

            foreach (int i in array)
            {
                if (ind_i == 0)
                {
                    Console.Write($"{i}");
                }
                else
                {
                    Console.Write($", {i}");
                }
                ind_i++;
            }

            Console.Write("]");
            Console.WriteLine();
        }
        private static void Swap<T>(T[] array, int index1, int index2)
        {
            T aux_int = array[index1];
            array[index1] = array[index2];
            array[index2] = aux_int;
        }
        public static void Selection<T>(T[] array, Func<T, T, bool> compare)
        {
            T[] arraySorted = new T[array.Length];
            for (int i = 0; i < array.Length - 1; i++)
            {
                int selected_int = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (compare(array[i], array[i + 1]))
                    {
                        Console.WriteLine("Int 1: " + array[i] + " | Int 2: " + array[i + 1]);
                        selected_int = j;
                    }
                }

                Swap(array, i, selected_int);
            }
        }
        public void Merge<T>(T[] array)
        {
            if (array.Length <= 1)
            {
                return;
            }

            int halfLen = array.Length / 2;
            int[] left = new int[halfLen];
            int[] right = new int[array.Length - halfLen];

            for (int i = 0; i < halfLen; i++)
            {
                left[i] = array[i];
            }
            for (int i = 0; i < right.Length; i++)
            {
                right[i] = array[halfLen + i];
            }

            Merge(left);
            Merge(right);

            int ind_left = 0;
            int ind_right = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (ind_left < left.Length
                    && (ind_right >= right.Length || left[ind_left] < right[ind_right]))
                {
                    array[i] = left[ind_left];
                    ind_left++;
                }
                else
                {
                    array[i] = right[ind_right];
                    ind_right++;
                }
            }
        }
        public void Quick(int[] array, int left, int right)
        {
            if (left >= right)
            {
                return;
            }

            int pivot = left;
            int mid = pivot;
            for (int i = pivot + 1; i <= right; i++)
            {
                if (array[i] < array[pivot])
                {
                    mid++;
                    // Swap
                    int aux = array[i];
                    array[i] = array[mid];
                    array[mid] = aux;
                }
            }

            // Indíce Final do Pivot
            int aux2 = array[mid];
            array[mid] = array[pivot];
            array[pivot] = aux2;

            // Ordenar Partições
            Quick(array, left, mid - 1);
            Quick(array, mid + 1, right);
        }
    }
}
