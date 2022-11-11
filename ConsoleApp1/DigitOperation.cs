using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class DigitOperation
    {
        public static int[] GetRndArray(int length)
        {
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = new Random().Next(100);
            }

            Array.Sort(array);

            return array;
        }

        public static int[] ShiftArray(int[] arr)
        {
            int rnd = new Random().Next(10);
            int[] array = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                array[i] = arr[(i + rnd) % arr.Length];
            }

            return array;
        }

        public static int MaxElemSearch(int[] arr)
        {
            return BinarySearch(arr);
        }


        private static int BinarySearch(int[] arr)
        {
            int result = 0;

            if (arr[0] < arr[arr.Length / 2])
            {

            }
            else if (arr[arr.Length - 1] < arr[arr.Length / 2])
            {

            }

            return result;
        }
    }
}
