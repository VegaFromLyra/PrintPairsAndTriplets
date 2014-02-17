using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Given an array of unsorted integers, and a value k,
// print out all pairs that add up to k
// O(nlogn)

// Given an array of unsorted integers, and a value k,
// print out all triplets that add up to k
// O(n * n)

namespace PrintPairsAndTriplets
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 1, 2, 3, 5, 6, 8, 11, 12 };

            int k = 11;

            Console.WriteLine("Pairs with sum of {0}", k);
            PrintPairs(input, k);

            Console.WriteLine("Triplets with sum of {0}", k);
            PrintTriplets(input, k);
        }

        static void PrintPairs(int[] arr, int k)
        {
            Array.Sort(arr);

            int left = 0;
            int right = arr.Length - 1;

            while (left < right)
            {
                int sum = arr[left] + arr[right];
                if (sum == k)
                {
                    Console.WriteLine(arr[left] + " " + arr[right]);
                    left++;
                    right--;
                }
                else if (sum < k)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
        }


        static void PrintTriplets(int[] arr, int k)
        {
            Array.Sort(arr);

            int left = 0;
            int right = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int first = arr[i];

                left = i + 1;
                right = arr.Length - 1;

                while (left < right)
                {
                    int sum = first + arr[left] + arr[right];

                    if (sum == k)
                    {
                        Console.WriteLine(first + " " + arr[left] + " " + arr[right]);
                        left++;
                        right--;
                    }
                    else if (sum < k)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }
        }

    }
}
