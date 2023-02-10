// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите первое число");
string example1 = Console.ReadLine();
int a = Convert.ToInt32(example1);
Console.WriteLine("Введите второе число");
string example2 = Console.ReadLine();
int b = Convert.ToInt32(example2);
Console.WriteLine("Введите третье число");
string example3 = Console.ReadLine();
int c = Convert.ToInt32(example3);
int maximal = 0;
if (a > b)
{
    maximal = a;
}
else
{
    maximal = b;
}
if (c > maximal)
{
    maximal = c;
}
Console.WriteLine(maximal);