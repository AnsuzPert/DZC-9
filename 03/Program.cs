//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.WriteLine("ВВедите первое число");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите второе число");
int y = Convert.ToInt32(Console.ReadLine());
int akk (int m, int n)
{
    if (m == 0) return n+1;
    if (m>0 && n==0) return akk(m-1, 1);
    if (m>0 && n>0) return akk(m-1,akk(m,n-1));
    return akk(m,n);
}
Console.WriteLine(akk(x,y));