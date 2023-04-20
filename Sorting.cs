using System.Diagnostics;

namespace DSA
{
    public class Sorting
    {
        private static Stopwatch _stopwatch = new Stopwatch();
        public static void sorting()
        {

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
                        BubbleSort(unSortedArray);
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
            PrintArray.Array(array);
            _stopwatch.Start();
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
                    PrintArray.Array(array);
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
            _stopwatch.Stop();
            Console.Write("\n\nAfter sorting : ");
            PrintArray.Array(array);
            Console.WriteLine($"\n\nTime Elasped {_stopwatch.Elapsed}");
        }


        //Selection Sort
        public static void SeletionSort(int[] array)
        {
            Console.Write("Before sorting : ");
            PrintArray.Array(array);
            _stopwatch.Start();
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
                PrintArray.Array(array);
            }
            _stopwatch.Stop();
            Console.Write("\n\nAfter sorting : ");
            PrintArray.Array(array);
            Console.WriteLine($"\n\nTime Elasped {_stopwatch.Elapsed}");
        }


        //Insertion Sort
        public static void InsertionSort(int[] array)
        {
            Console.Write("Before sorting : ");
            PrintArray.Array(array);
            _stopwatch.Start();
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
                PrintArray.Array(array);
            }
            _stopwatch.Stop();
            Console.Write("\n\nAfter sorting : ");
            PrintArray.Array(array);
            Console.WriteLine($"\n\nTime Elasped {_stopwatch.Elapsed}");
        }
    }
}
