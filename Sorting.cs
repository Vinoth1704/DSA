using System.Diagnostics;

namespace DSA
{
    public class Sorting
    {
        public static void sorting()
        {
            Stopwatch stopwatch = new Stopwatch();

            int[] unSortedArray = { 2, 5, 7, 6, 3, 9, 8, 4, 1 };

        sorting:
            Console.WriteLine("\nSORTING:");
            Console.WriteLine("1.Bubble Sort");
            Console.WriteLine("2.Insertion Sort");
            Console.WriteLine("3.Selection Sort");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        stopwatch.Start();
                        BubbleSort(unSortedArray);
                        stopwatch.Stop();
                        Console.WriteLine($"\n\nTime Elasped {stopwatch.Elapsed}");
                        break;
                    }
                case 2:
                    {
                        SeletionSort(unSortedArray);
                        break;
                    }
                case 3:
                    {
                        InsertionSort(unSortedArray);
                        break;
                    }
            }
            Console.WriteLine("Press Y to continue (Y/N)");
            char Continue = char.Parse(Console.ReadLine()!);
            if (Continue == 'Y' || Continue == 'y') goto sorting;
        }


        //Bubble Sort
        public static void BubbleSort(int[] array)
        {
            Console.Write("\nBefore sorting : ");
            Array.PrintArray(array);
            int temp = 0, size = array.Length - 1, loop = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        loop++;
                    }
                    Console.Write($"\nArray with outer loop : {i} and inner loop : {j} = ");
                    Array.PrintArray(array);
                }
                if (loop != 0)
                {
                    loop = 0;
                }
                else
                {
                    break;
                }
            }
            Console.Write("\n\nAfter sorting : ");
            Array.PrintArray(array);
        }


        //Selection Sort
        public static void SeletionSort(int[] array)
        {
            Console.Write("Before sorting : ");
            Array.PrintArray(array);
            int temp = 0, size = array.Length, smallest = 0;
            for (int i = 0; i < size; i++)
            {
                smallest = i;
                for (int j = i + 1; j < size; j++)
                {
                    if (array[j] < array[smallest])
                    {
                        smallest = j;
                    }
                }
                temp = array[i];
                array[i] = array[smallest];
                array[smallest] = temp;
                Console.Write($"\nArray with outer loop : {i} = ");
                Array.PrintArray(array);
            }
            Console.Write("\nAfter sorting : ");
            Array.PrintArray(array);
        }


        //Insertion Sort
        public static void InsertionSort(int[] array)
        {
            Console.Write("Before sorting : ");
            Array.PrintArray(array);
            int smallestValue = 0;
            for (int i = 1; i <= array.Length - 1; i++)
            {
                smallestValue = array[i];
                int j = i - 1;
                while (j >= 0 && smallestValue < array[j])
                {
                    array[j + 1] = array[j];
                    --j;
                }
                array[j + 1] = smallestValue;
                Console.Write($"\nArray with outer loop : {i} = ");
                Array.PrintArray(array);
            }
        }
    }
}
