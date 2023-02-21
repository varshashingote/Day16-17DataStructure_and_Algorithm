using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_17DataStructureSortingSerchingAlgorithm
{
    public class InsertionSort
    {
        public void InsertionSortElement(int[] arr2)
        {
            for(int i=1;i<arr2.Length;i++)
            {
                int Current = arr2[i];
                int j = i - 1;
                while(j >=0 && Current < arr2[j])
                {
                    arr2[j + 1] = arr2[j];
                    j--;
                }
                arr2[j+1]=Current;

            }

        }
        public void Display(int[] arr2)
        {
            Console.WriteLine("Sorted Element:");
            for(int i=0;i<arr2.Length;i++)
            {
                Console.WriteLine(arr2[i]+"");
            }
        }
    }

}
