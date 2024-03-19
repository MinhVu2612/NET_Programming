// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*int[] intArray = { 52, 273, 32, 65, 103 };

intArray[0] = 0;

Console.WriteLine(intArray[0]);
Console.WriteLine(intArray[1]);
Console.WriteLine(intArray[2]);
Console.WriteLine(intArray[3]);

int[] IntArray1 = new int[100];

Console.WriteLine(IntArray1[0]);
Console.WriteLine(IntArray1[99]);

*//*int i = 0;
int[] IntArray2 = { 52, 273, 32, 65, 103 };

while (1 < IntArray2.Length )
{
    Console.WriteLine(i + "번째 출력: " + IntArray2[i]);

    i++;
}*//*

string input;

do
{
    Console.WriteLine("입력(exit 을 입력하면 정료): ");
    input = Console.ReadLine();
} while (input != "exit");

int output = 0;

for (int i =0; i <= 100; i++)
{
    output += i;
}

Console.WriteLine(output);

int output2 = 1;

for (int i = 1; i <= 5; i++)
{
    output2 *= i;
}

*//*Console.WriteLine(output2);

for (int i = '가'; i <= '힣'; i++)
{
    Console.Write((char)i);
}*//*

int[] IntArray4 = { 1, 2, 3, 4, 5, 6 };

for (int i = IntArray4.Length - 1 ; i >= 0; i--)
{
    Console.WriteLine(IntArray4[i]);
}

string[] stringArray1 = { "사과", "배", "포도", "딸기", "바나나" };

foreach(string item in stringArray1)
{
    Console.WriteLine(item);
}*/

for (int i = 1; i <= 10; i++)
{
    for(int j = 0; j < i; j++)
    {
        Console.Write('*');
    }
    Console.WriteLine();
}

for (int i = 1; i <= 10; i++)
{
    for (int j = 0; j < 10-i; j++)
    {
        Console.Write(' ');
    }
    for (int k = 0; k < i; k++)
    {
        Console.Write('*');
    }
    Console.WriteLine();
}
