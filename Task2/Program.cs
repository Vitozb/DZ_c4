int Summa(int a)
{
int s = 0;
            while (a > 0)
            {
 
                s = s + a % 10;
                a = a /10 ;
 
            }
return s;            
}



System.Console.WriteLine("Введите число сумму которого надо посчитать");
int a = int.Parse(Console.ReadLine());
            
 Console.WriteLine(Summa(a));