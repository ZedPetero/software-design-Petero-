using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5OOPBubbleSort
{
    internal class SorterClass
    {
        public int[] BubbleSort(int[] numbers)
        {
            int size = numbers.Length;
            int[] ints = new int[size];
            ints = numbers;

            for (int i = 0; i < size - 1; i++)
            {
                for (int j = 0; j < size - 1; j++)
                {
                    if (ints[j] < ints[j + 1])
                    {
                        int temp = ints[j];
                        ints[j] = ints[j + 1];
                        ints[j + 1] = temp;
                    }
                }
            }

            return ints;
        }
    }
}
