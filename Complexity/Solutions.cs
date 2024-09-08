using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures
{
    internal class Solutions
    {
        //O(n)
        public int CalculateOddSum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }
        //O(n)
        public Tuple<int, int> FindMaximumTwo(int[] array)
        {
            int index = 0;
            int max = array[0] + array[1];
            for (int i = 1; i < array.Length - 1; i++)
            {
                int tmp = array[i] + array[i + 1];
                if (tmp > max)
                {
                    max = tmp;
                    index = i;
                }
            }
            Tuple<int, int> nums = new(array[index], array[index + 1]);
            return nums;
        }

        //O(n)
        public bool ContainsNumber(int[] array, int number)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                    return true;
            }
            return false;
        }

        //O(n**3)
        public int SumOfAllTriplets(int[] array)
        {
            if (array == null || array.Length < 3)
            {
                return int.MinValue;
            }
            int sum = array[0] + array[1] + array[2];

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 1; j < array.Length; j++)
                {
                    for (int k = 2; k < array.Length; k++)
                    {
                        int tmp = (array[i] + array[j] + array[k]);
                        if (tmp > sum)
                        {
                            sum = tmp;
                        }
                    }
                }
            }
            return sum;
        }

        //O(n)
        public Tuple<int, int> FindLastPairWithProduct(int[] array, int product)
        {
            int a = 0;
            int b = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                int multi = array[i] * array[i + 1];
                if (multi == product)
                {
                    a = array[i];
                    b = array[i + 1];
                }
            }
            return Tuple.Create<int, int>(a, b);
        }

        //O(n)
        public int CountEvenNumbers(int[] array)
        {
            int evenNums = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    evenNums++;
                }
            }
            return evenNums;
        }

        //O(n)
        public int[] MergeSortedArraysUnique(int[] array1, int[] array2)
        {

            int x = 0;
            int y = 0;
            int z = 0;
            int[] arr3 = new int[array1.Length + array2.Length];
            while (x < array1.Length && y < array2.Length)
            {
                if (array1[x] < array2[y])
                {
                    arr3[z++] = array1[x++];

                }
                else if (array1[x] > array2[y])
                {
                    arr3[z++] = array2[y++];

                }
                else
                {
                    arr3[z++] = array1[x++];
                    y++;
                }
            }
            while (x < array1.Length)
            {
                arr3[z++] = array1[x++];
            }

            while (y < array2.Length)
            {
                arr3[z++] = array2[y++];
            }
            return arr3;
        }

        //O(n) - 1
        public void FindPairsWithSum(int[] array, int sum)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int tmp = array[i] + array[i + 1];
                if (tmp == sum)
                {
                    Console.WriteLine(array[i] + " " + array[i + 1]);
                }
            }
        }

        //O(n**2)
        public int[] CountFrequency(int[] array)
        {
            int[] ints1 = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                ints1[i] = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        ints1[i]++;
                    }
                }
            }
            return ints1;
        }

        public int FindMaxSubarraySum(int[] array)
        {
            int maxSum = 0;
            int tmpSum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] + tmpSum > maxSum)
                {
                    maxSum += array[i];
                }
            }
            return maxSum;
        }


        public static int SumOfAllTriplets5(int[] array)
        {
            if (array == null || array.Length < 3)
            {
                return int.MinValue;
            }
            int max1 = int.MinValue;
            int max2 = int.MinValue;
            int max3 = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max3)
                {
                    if (array[i] > max1)
                    {
                        max3 = max2;
                        max2 = max1;
                        max1 = array[i];
                    }
                    else if (array[i] > max2)
                    {
                        max3 = max2;
                        max2 = array[i];
                    }
                    else
                    {
                        max3 = array[i];
                    }
                }
            }
            return max1 + max2 + max3;
        }
    }
}
