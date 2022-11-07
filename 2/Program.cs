// Показать числа Фибоначчи
Console.WriteLine("До какого числа считать фибоначчи? ");
int a = int.Parse(Console.ReadLine() ?? "0");
int p = 1;
int v = 1;
int sum = 0;
while (a>=sum)
{
 sum = p+v;
 p = v;
 v = sum; 
 Console.Write($"{sum}, ");  
}