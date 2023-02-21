using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_17DataStructureSortingSerchingAlgorithm
{
    public class Palindrome
    {
        public void FindPalindromNumber()
        { 
            int r, sum = 0, temp;
            Console.WriteLine("Enter The Number Do You Want Check its is Palindrom or Not");
            int n = Convert.ToInt32(Console.ReadLine());
            temp = n;
            while (n > 0) {
                r = n % 10;  //getting remainder  
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if (temp == sum)
                Console.WriteLine("palindrome number ");
            else
                Console.WriteLine("not palindrome");
        }
    }

}