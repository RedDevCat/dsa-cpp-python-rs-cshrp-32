//string[] abcde = new string[] { "asher", "ballman", "comcast", "daedra", "estrogen" };

//this is called bruteforce searching method

//for each version cleaner, no access to indexes
// foreach (int i in myarr)
// {
//     if (i == targetValue)
//     {
//         Console.WriteLine("Found at:" + i);
//         found = true;
//         break;
//     }
// }
// if (!found) // means if found bool is still false after this whole ass loop
// {
//     Console.WriteLine("Not Found");
// }

//for loop version

using System;

class Program
{
    public static void LinearSearch(int[] myarr, int targetValue)
    {
        for (int i = 0; i < myarr.Length; i++)
        {
            if (myarr[i] == targetValue)
            {
                Console.WriteLine("Linear Search");
                Console.WriteLine(targetValue + " Found at index " + i);
                return;
            }
        }
        Console.WriteLine("Not Found");
    }

    public static void Main(string[] args)
    {
        int[] myarr = new int[5] { 10, 20, 30, 40, 50 };
        int targetValue = 30;
        LinearSearch(myarr, targetValue);
    }
}

// visualization: https://www.cs.usfca.edu/~galles/visualization/Search.html
