int Stepen(int a, int b)
{
    int c = 1;    
    while (b!=0)
    {
    c = c * a;
    b = b - 1;
    }
    return c;
}
Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

if (b<1) Console.Write("Число B должно быть натуральным");


Console.WriteLine($"Число A в натуральной степени B равно {Stepen(a, b)}");
