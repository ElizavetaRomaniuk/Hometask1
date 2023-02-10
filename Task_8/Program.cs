// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input number");
string example1 = Console.ReadLine();
int a = Convert.ToInt32(example1);

int i = 0;
while (i < a)
{
    i += 2;
        if (i <= a) 
        {
            Console.Write(i + " ");
}
}
