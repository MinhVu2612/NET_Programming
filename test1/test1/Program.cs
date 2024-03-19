// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello C# Programming ..!");

Console.WriteLine(1 + 2);
Console.WriteLine(1 - 2);
Console.WriteLine(1 * 2);
Console.WriteLine(1 / 2);

Console.WriteLine(1.0 + 2.0);
Console.WriteLine(1.0 - 2.0);
Console.WriteLine(1.0 * 2.0);
Console.WriteLine(1.0 / 2.0);

Console.WriteLine('A');
Console.WriteLine('가');
Console.WriteLine('나');

Console.WriteLine("한빛\t아카데미");
Console.WriteLine("한빛\n아카데미");
Console.WriteLine("\"\"\"");

Console.WriteLine("가나다" + "라마" + "바사아" + "자차카타" + "파하");

Console.WriteLine("안녕하세요"[0]);
Console.WriteLine("안녕하세요"[1]);
Console.WriteLine("안녕하세요"[2]);

Console.WriteLine(54 < 242);
Console.WriteLine(54 > 234);

Console.WriteLine(!false);
Console.WriteLine(!true);
Console.WriteLine(!(2 > 4));
Console.WriteLine(!(2 < 4));

Console.WriteLine(DateTime.Now.Hour < 3 || 8 < DateTime.Now.Hour);
Console.WriteLine(DateTime.Now.Hour > 3 && 8 > DateTime.Now.Hour);
Console.WriteLine(DateTime.Now.Hour);

int a = 273;
int b = 52;

Console.WriteLine(a + b);
Console.WriteLine(a - b);
Console.WriteLine(a * b);
Console.WriteLine(a / b);
Console.WriteLine(a % b);

int c = 2000000000;
int d = 1000000000;
Console.WriteLine(c + d);

double e = 52.273;
double f = 103.32;

Console.WriteLine(e + f);
Console.WriteLine(e - f);
Console.WriteLine(e * f);
Console.WriteLine(e / f);

char g = 'a';
Console.WriteLine(g);

Console.WriteLine(sizeof(int));
Console.WriteLine(sizeof(long));
Console.WriteLine(sizeof(float));
Console.WriteLine(sizeof(double));
Console.WriteLine(sizeof(char));

string message = "안녕하세요";
Console.WriteLine(message + "!");
Console.WriteLine(message[0]);
Console.WriteLine(message[1]);
Console.WriteLine(message[2]);

bool one = 10 < 0;
bool two = 10 > 0;
Console.WriteLine(one);
Console.WriteLine(two);

int output = 0;

output += 52;
output += 273;
output += 103;

Console.WriteLine(output);

string output1 = "hello ";

output1 += "world ";
output1 += "!";

Console.WriteLine(output1);

int number = 10;
number++;
Console.WriteLine(number);
number--;
Console.WriteLine(number);


Console.WriteLine(number);
Console.WriteLine(number++);
Console.WriteLine(number--);
Console.WriteLine(number);

Console.WriteLine(number);
Console.WriteLine(++number);
Console.WriteLine(--number);
Console.WriteLine(number);

int _int = 273;
long _long = 522721033265;
float _float = 52.273F;
double _double = 53.273;
char _char = '하';
string _string = "하하";

Console.WriteLine(_int.GetType());
Console.WriteLine(_long.GetType());
Console.WriteLine(_float.GetType());
Console.WriteLine(_double.GetType());
Console.WriteLine(_char.GetType());
Console.WriteLine(_string.GetType());

Console.WriteLine((273).GetType());
Console.WriteLine((522731033265L).GetType());
Console.WriteLine((53.273F).GetType());
Console.WriteLine((52.273).GetType());
Console.WriteLine(('하').GetType());
Console.WriteLine(("하하").GetType());

String input = Console.ReadLine();
Console.WriteLine("input: " + input);

