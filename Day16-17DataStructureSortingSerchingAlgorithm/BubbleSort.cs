using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day16_17DataStructureSortingSerchingAlgorithm
{
    public class BubbleSort
    {

        public  void BubbleSortingAlgorithm(int[] arr1)
        {

            for (int i = 0; i < arr1.Length - 1; i++)
            {
                for (int j = 0; j < arr1.Length - 1 - i; j++)
                {
                    if (arr1[j] > arr1[j + 1])
                    {
                        //swap
                        int temp = arr1[j];
                        arr1[j] = arr1[j + 1];
                        arr1[j + 1] = temp;

                    }
                }
            }   
        }
        public void Display(int[] arr1)
        {
            Console.WriteLine("Sorted Element are using Bubble sort:");
            for (int i=0;i<arr1.Length;i++)
            { 
                Console.WriteLine(arr1[i]+"");
            }
         
        }
    }
}
         

       