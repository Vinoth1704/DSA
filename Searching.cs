using System.Diagnostics;

namespace DSA
{
    public class Searching
    {
        private static Stopwatch _stopWatch = new Stopwatch();
        public static void searching()
        {

            int[] SortedArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };

        sorting:
            Console.WriteLine("\nSEACRHING:");
            Console.WriteLine("1.Linear Search");
            Console.WriteLine("2.Binary Search");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        LinearSearch(SortedArray);
                        break;
                    }
                case 2:
                    {
                        BinarySearch(SortedArray);
                        break;
                    }
            }
            Console.WriteLine("Press Y to continue (Y/N)");
            char Continue = char.Parse(Console.ReadLine()!);
            if (Continue == 'Y' || Continue == 'y') goto sorting;
        }

        //Binary Search 
        //Only possible in sorted array.
        public static void BinarySearch(int[] array)
        {
            int low = 0, high = array.Length - 1, mid = 0, flag = 0;
            Array.PrintArray(array);
            Console.WriteLine("Enter a value to be find in the array ");
            int target = Convert.ToInt32(Console.ReadLine());
            _stopWatch.Start();
            while (high >= low)
            {
                mid = (low + high) / 2;
                Console.WriteLine($"low:{array[low]}, high:{array[high]}, mid:{array[mid]}");
                if (target == array[mid])
                {
                    flag = 1;
                    break;
                }
                else if (target < array[mid])
                    high = mid - 1;
                else
                    low = mid + 1;
            }
            if (flag == 1) Console.WriteLine($"The target is present in {mid} position");
            else Console.WriteLine("Target not found");
            _stopWatch.Stop();
            Console.WriteLine($"Total time elapsed {_stopWatch.Elapsed}");
        }

        //Linear Search
        public static void LinearSearch(int[] array)
        {
            bool flag = false;
            int i = 0;
            Array.PrintArray(array);
            Console.WriteLine("Enter a value to be find in the array ");
            int target = Convert.ToInt32(Console.ReadLine());
            _stopWatch.Start();
            for (i = 0; target != array[i] && i < array.Length; i++)
            {
                flag = true;
            }
            if (flag) Console.WriteLine($"The target is present in {i} position");
            else Console.WriteLine("Target not found");
            _stopWatch.Stop();
            Console.WriteLine($"Total time elapsed {_stopWatch.Elapsed}");
        }
    }
}