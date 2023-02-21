using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_17DataStructureSortingSerchingAlgorithm
{
    internal class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Choice 1.Bubblesort \n 2.InsertionSort \n 3.MergeSort" +
                "\n 4.AnanagramNo \n5.PrimeNo \n6.PalindromNo \n7.BinarySerch");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    BubbleSort bubble = new BubbleSort(); //O(n)
                    int[] arr1 = { 13, 33, 24, 44 };
                    bubble.BubbleSortingAlgorithm(arr1);
                    bubble.Display(arr1);
                    Console.ReadLine();
                    break;
                case 2:
                    InsertionSort insertion = new InsertionSort();
                    int[] arr2 = { 13, 14, 15, 12 };
                    insertion.InsertionSortElement(arr2);
                    insertion.Display(arr2);
                    Console.ReadLine();
                    break;
                case 3:
                    MergeSort merge = new MergeSort(); //time compilicity =nlogn
                    int[] arr = { 19, 12, 13 };
                    int n = arr.Length;
                    MergeSort.divide(arr, 0, n - 1);
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.WriteLine(arr[i] + " ");
                    }
                    Console.ReadLine();
                    break;
                case 4:
                    Anagram anagram = new Anagram();
                    anagram.AnagramWord("earth", "heart");
                    Console.ReadLine();
                    break;
                case 5:
                    PrimeNo primeNo = new PrimeNo();
                    primeNo.Prime();
                    Console.ReadLine();
                    break;
                case 6:
                    Palindrome palindrome = new Palindrome();
                    palindrome.FindPalindromNumber();
                    Console.ReadLine();
                    break;
                case 7:
                    BinarySerch binarySerch = new BinarySerch();
                    binarySerch.Search("C:\\Users\\SHIVNERI\\source\\repos\\Day16-17DataStructureSortingSerchingAlgorithm\\Day16-17DataStructureSortingSerchingAlgorithm\\TextFile1.txt");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
