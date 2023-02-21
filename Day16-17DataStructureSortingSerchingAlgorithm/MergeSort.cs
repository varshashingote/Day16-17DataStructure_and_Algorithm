using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_17DataStructureSortingSerchingAlgorithm
{
    internal class MergeSort
    {
        public static void divide(int[] arr, int si,int ei)
        {
            if(si>=ei)         //single element end of divide
            {
                return;
            }
            int mid = si + ei / 2;      //find middle
             divide(arr, si, mid);     //first arry start with si and ends with mid
             divide(arr, mid+1, ei);   //second array start with mid+1 ends with ei
            Conqure(arr, si, mid, ei);   //for conqure array  

        }
        public static void Conqure(int[] arr, int si, int mid, int ei)
        {
            int[] merge = new int[ei - si + 1];     //array to conqure ending index are always tot-1
            int index1 = si;                       //index1 start with si its a first array
            int index2 = mid + 1;                  //index2 start with mid +1 its second array
            int x = 0;                             //merge index track 
            while (index1 <= mid && index2 <= ei)
            {
                if (arr[index1] <= arr[index2])
                {
                    merge[x++] = arr[index1++];      

                }
                else
                {
                    merge[x++] = arr[index2++];
                }
            }
            while (index1 <= mid)            //already sorted elements
            {
                merge[x++] = arr[index1++];
            }
            while (index2 <= ei)           // only 1 while loop run
            {
                merge[x++] = arr[index2++];
            }
            
            for (int i = 0, j=si; i < merge.Length; i++,j++)   //copy element in merge  array
            { 
            
                    arr[j] = merge[i];
                }
            }
        }
       

    }

