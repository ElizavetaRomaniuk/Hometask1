// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите первое число");
string example1 = Console.ReadLine();
int a = Convert.ToInt32(example1);
Console.WriteLine("Введите второе число");
string example2 = Console.ReadLine();
int b = Convert.ToInt32(example2);
int maximal = a;
int minimal = b;
if (a > b)
{
    Console.WriteLine(maximal + " - максимальное, " + minimal + " - минимальное");
}
else
{
    maximal = b;
    minimal = a;
    Console.WriteLine(maximal + " - максимальное, " + minimal + " - минимальное");
}

