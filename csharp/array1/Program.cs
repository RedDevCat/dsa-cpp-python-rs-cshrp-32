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

//reading specific elements

//reading string 
string readsingleelement = abcde[3];
//reading int element
int inttypevar = myarr[3];

Console.WriteLine(readsingleelement);
Console.WriteLine(inttypevar);

//changing/updating an array element
fiveguysbutvalues[2] = 69;
//now this array is 10, 20, 69, 40, 50

