//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.WriteLine("ВВедите начальное число");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите конечное число");
int z = Convert.ToInt32(Console.ReadLine());
if (x < z)
{
    int b = z;
    z = x;
    x = b;
}
int vivo(int y, int i)
{
        if (y == i) return (y);
        return vivo(y - 1,i)+y;
}
Console.WriteLine(vivo(x,z));