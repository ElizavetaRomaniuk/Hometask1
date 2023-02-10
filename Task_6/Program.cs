// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число");
string example1 = Console.ReadLine();
int a = Convert.ToInt32(example1);

if (a % 2 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
    