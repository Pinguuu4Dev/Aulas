using System;
using Merge_e_Algoritmos;

Merge merge = new Merge();
int[] array = [0, 5, 3, 1];
int[] array_2 = [5, 12, 2, 0, 1, 6, 7];

merge.PrintArray(array); 
merge.PrintArray(array_2);

merge.Sort(array);
merge.Quick(array_2, 0, array_2.Length - 1);

merge.PrintArray(array); 
merge.PrintArray(array_2);