// declare int
using System.Formats.Asn1;
using System.Globalization;

int testInt = 30;

// declare double
double testDouble = 6.7;

// declare string 
string testString = "Bader";

// declare boolean
bool testBool = false;

Console.WriteLine(testInt);
Console.WriteLine(testDouble);
Console.WriteLine(testString);      
Console.WriteLine(testBool);

Console.WriteLine("--------------------------------");

int number = 5; 

double result = Convert.ToDouble(number);

Console.WriteLine(number);
Console.WriteLine(result);

Console.WriteLine("--------------------------------");
// char data type is used to store a single character, for example storing 'B'. 

string studentName = "Bader Ali";
double pointAverage = 93.4;
string favoriteSubject = "Mathematics";

Console.WriteLine("Student Name:" + studentName + " " + "Point Average :" + " " + pointAverage + " " + "Favorite Subject:" + favoriteSubject);

Console.WriteLine("--------------------------------");

double width = 5.5;
double height = 3.2;

double Area = width*height;
Console.WriteLine("area of the rectangle is : " + Area);

// the difference between constants and variables is that constants do not have a change in value
// depending on the function, while variables can have a change in their value dependuing on the function. 

Console.WriteLine("what time is it");
string Time = Console.ReadLine();

int clock = (Convert.ToInt32(Time));
if (clock >11 && clock <14)
    {
    Console.WriteLine("its time for lunch");
    }