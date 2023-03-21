namespace DSA
{
    class Program
    {
        public static void Main()
        {
            int[] sortedArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] unSortedArray = { 2, 5, 7, 6, 3, 9, 8, 4, 1 };
            Boolean exit = false;


        Menu:
            Console.WriteLine("\t\t\t\t\t\tWelcome to Data Structures and Algorithms");
            Console.WriteLine("Choose any one of the following");
            Console.WriteLine("1.Sorting");
            Console.WriteLine("2.Searching");
            Console.WriteLine("3.Exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        Sorting.sorting();
                        break;
                    }
                case 2:
                    {
                        Searching.searching();
                        break;
                    }
                case 3:
                    {
                        exit = true;
                        break;
                    }
            }
            if (!exit) goto Menu;
        }
    }
}