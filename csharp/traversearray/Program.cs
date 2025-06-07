// array can have any freaking name
int[] fiveguys = new int[5];

// int[] balls; is for just declaring [arr exists but isn’t pointing anywhere yet]
// balls = new int[5] is for initilization ie memory reservation
// [Now memory is reserved for 5 ints (all 0 by default)]

//Index: 0   1   2   3   4
//Value: 0   0   0   0   0

int[] ballsarray = new int[5] { 11, 12, 13, 14, 15 }; // do this when all values are already known, like adding specifier

int[] fiveguysbutvalues = new int[] { 10, 20, 30, 40, 50 }; //compiler auto assumes array elements == 5

string[] abcde = new string[] { "asher", "ballman", "comcast", "daedra", "estrogen" };

int[] myarr = new int[5] { 1, 2, 3, 4, 5 };

//using forloop index + values

for (int i = 0; i < ballsarray.Length; i++)
{
    Console.WriteLine($"ballsarray[{i}]"); // $"myarr[{i}]" for index
    Console.WriteLine($"{ballsarray[i]}"); // $"{myarr[i]}" for value
    // Console.WriteLine($"ballsarray[{i}] = {ballsarray[i]}");
}

//for each values only

foreach (int j in myarr)
{
    Console.WriteLine(j);
}

for (int a = 0; a < myarr.Length; a++)
{
    Console.WriteLine($"myarr[{a}] is index, and value is {myarr[a]}");
}

foreach (int m in ballsarray)
{
    Console.WriteLine(m);
}

int arrlength = ballsarray.Length;
//length

//sum of values in array
int normalsum = 0;
foreach (int q in ballsarray)
{
    normalsum += q;
}

Console.WriteLine($"Sum of Values in ballsarray: {normalsum}");

