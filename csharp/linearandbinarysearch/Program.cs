using System;

public class Program
{   
    //Linear Search
    public static void LinearSearch(int[] myarr, int targetValue){
        for (int i = 0; i < myarr.Length; i++){
            if (myarr[i] == targetValue)
            {
                Console.WriteLine("Linear Search");
                Console.WriteLine(targetValue + " found at " + i);
                return;
            }
        }
        Console.WriteLine("not found in linear search");
    }
    
    //Binary Search
    public static void BinarySearch(int[] myarr, int targetValue){
        int low = 0;
        int high = myarr.Length - 1;
        int middle = 0;
        
        while (low <= high)
        {
            middle = (low + high) / 2;
            if (myarr[middle] == targetValue)
            {   
                Console.WriteLine("Binary Search");
                Console.WriteLine(targetValue + " found at " + middle);
                return;
            }
            else if (myarr[middle] <= targetValue)
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
    
    public static void Main(string[] args)
    {   
        // int[] myarr = {10, 20, 30, 40, 50, 60, 70, 80, 90, 110};
        // int targetValue = 70;
        
        Console.WriteLine("Enter Array values seperated by space: ");
        string myarrinput = Console.ReadLine();
        //convert myarrinput from string to int
        int[] myarr = Array.ConvertAll(myarrinput.Split(' '), int.Parse); 
        //now for single int targetValue
        Console.WriteLine("Enter the number to search for:");
        int targetValue = int.Parse(Console.ReadLine());
        // Sort the array so Binary Search works
        Array.Sort(myarr);
        
        LinearSearch(myarr, targetValue);
        BinarySearch(myarr, targetValue);
    }
}