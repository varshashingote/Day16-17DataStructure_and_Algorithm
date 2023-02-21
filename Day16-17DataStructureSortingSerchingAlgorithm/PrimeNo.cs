using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_17DataStructureSortingSerchingAlgorithm
{
    public class PrimeNo
    {
        public void Prime()
        {
            int i = 2;
            Console.WriteLine("Print prime number 0-1000 \n");
            while (i < 1000)
            {
                bool count = false;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        count = true;
                        break;
                    }
                }
                if (count == false)
                {
                    Console.Write(i + " ");
                }
                i++;
            }
        }
    }
}
