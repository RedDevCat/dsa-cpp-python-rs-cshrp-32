using System;

class Program
{
    static void BinarySearch(int[] myarr, int targetValue)
    {
        int low = 0, high = myarr.Length - 1;
        int middle = 0;

        while (low <= high)
        {
            middle = (low + high) / 2;

            if (myarr[middle] == targetValue)
            {   
                Console.WriteLine("Binary Search");
                Console.WriteLine("Value found at index: " + middle);
                return;
            }
            else if (myarr[middle] < targetValue)
            {
                low = middle + 1;
            }
            else
            {
                high = middle - 1;
            }
        }

        Console.WriteLine("Target not in array");
        Console.ReadLine();
    }

    static void Main(string[] args)
    {
        int[] myarr = {1, 3, 5, 7, 9, 11, 13};
        int target = 7;

        BinarySearch(myarr, target);
    }
}

//visualization: https://www.cs.usfca.edu/~galles/visualization/Search.html