using System;
using Merge_e_Algoritmos;

Sort sort = new Sort();
int[] array = [0, 5, 3, 1];
int[] array_2 = [5, 12, 2, 0, 1, 6, 7];

sort.PrintArray(array); 
sort.PrintArray(array_2);

sort.Merge(array);
sort.Quick(array_2, 0, array_2.Length - 1);

sort.PrintArray(array); 
sort.PrintArray(array_2);