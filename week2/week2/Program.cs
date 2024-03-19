// See https://aka.ms/new-console-template for more information
using System.Runtime.ConstrainedExecution;

Console.WriteLine("Hello, World!");

Console.WriteLine("Ex1");
long longNumber = 2147483647l + 2147483647l;
int intNumber = (int)longNumber;
Console.WriteLine(intNumber);

Console.WriteLine("E2");
double doubleNumber = 52.27310332;
int doubleToInt = (int)doubleNumber;
Console.WriteLine(doubleToInt);

Console.WriteLine("Ex3");
int IntNumber3 = 2147483647;

long intToLong = IntNumber3;
Console.WriteLine(intToLong);

double intToDouble = IntNumber3;
Console.WriteLine(intToDouble);

Console.WriteLine("Ex4");
Console.WriteLine(int.Parse("52"));
Console.WriteLine(long.Parse("273"));
Console.WriteLine(float.Parse("52,273"));
Console.WriteLine(double.Parse("103.32"));

Console.WriteLine(int.Parse("52").GetType());
Console.WriteLine(long.Parse("273").GetType());
Console.WriteLine(float.Parse("52,273").GetType());
Console.WriteLine(double.Parse("103.32").GetType());

Console.WriteLine("Ex5");

Console.WriteLine((52).ToString());
Console.WriteLine((52.273).ToString());
Console.WriteLine(('a').ToString());
Console.WriteLine((true).ToString());
Console.WriteLine((false).ToString());

Console.WriteLine((52).ToString().GetType());
Console.WriteLine((52.273).ToString().GetType());
Console.WriteLine(('a').ToString().GetType());
Console.WriteLine((true).ToString().GetType());
Console.WriteLine((false).ToString().GetType());

Console.WriteLine("Ex6");
double number = 52.273103;

Console.WriteLine(number.ToString("0.0"));
Console.WriteLine(number.ToString("0.00"));
Console.WriteLine(number.ToString("0.000"));
Console.WriteLine(number.ToString("0.0000"));

Console.WriteLine("Ex7");

Console.WriteLine(54 + 273);
Console.WriteLine("52" + 273);
Console.WriteLine(52 + "273");
Console.WriteLine("52" + "273");

Console.WriteLine("Ex8");

Console.WriteLine(bool.Parse("true"));
Console.WriteLine(bool.Parse("True"));
Console.WriteLine(bool.Parse("false"));
Console.WriteLine(bool.Parse("False"));

Console.WriteLine("Chap 03 =========================================");

Console.Write("enter a number: ");
int input = int.Parse(Console.ReadLine());

Console.WriteLine("Ex1 ===========================");
if(input % 2 == 0)
{
    Console.WriteLine("even number");
}
if (input % 2 == 1)
{
    Console.WriteLine("odd number");
}

Console.WriteLine("EX2 ===========================");

Console.WriteLine(DateTime.Now.Year);
Console.WriteLine(DateTime.Now.Month);
Console.WriteLine(DateTime.Now.Day);
Console.WriteLine(DateTime.Now.Hour);
Console.WriteLine(DateTime.Now.Minute);
Console.WriteLine(DateTime.Now.Second);

if (DateTime.Now.Hour < 12)
{
    Console.Write("morning");
}
if (DateTime.Now.Hour > 12)
{
    Console.WriteLine("afternoon");
}

Console.WriteLine("EX3 ===========================");

Console.Write("enter a number:");
int input2 = int.Parse(Console.ReadLine());

if ( input % 2 == 0)
{
    Console.WriteLine("Even number");
}
else
{
    Console.WriteLine("odd number");
}

Console.WriteLine("Ex4 ===========================");

if (DateTime.Now.Hour < 12)
{
    Console.Write("morning");
}
else
{
    Console.WriteLine("afternoon");
}

Console.WriteLine("Ex5 ===========================");

if (DateTime.Now.Hour < 11)
{
    Console.WriteLine("breakfast time");
}
else
{
    if (DateTime.Now.Hour < 15)
    {
        Console.WriteLine("lunch time");
    }
    else
    {
        Console.WriteLine("Dinner time");
    }
}
Console.WriteLine("Ex6 ===========================");

if (DateTime.Now.Hour < 11)
{
    Console.WriteLine("breakfast time");
}
else if (DateTime.Now.Hour < 15)
{
    Console.WriteLine("lunch time");
}
else
{
    Console.WriteLine("Dinner time");
}

Console.WriteLine("Ex 7 ======================");

Console.Write("enter a number:");
int input3 = int.Parse(Console.ReadLine());

switch(input3 % 2)
{
    case 0:
        Console.WriteLine("even number");
        break;
    case 1:
        Console.WriteLine("odd number");
        break;
}

Console.WriteLine("Ex 7 ======================");

Console.Write("What month is now?");
int input4 = int.Parse(Console.ReadLine());

switch (input4)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("winter");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("spring");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("summer");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("fall");
        break;
    default:
        Console.WriteLine("Where are you living? ");
        break;
}

Console.WriteLine("Ex9====================");
string input5 = Console.ReadLine();
int number5 = int.Parse(input5);

Console.WriteLine(number > 0 ? "Natural number" : "Not Natural number!");