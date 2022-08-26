// See https://aka.ms/new-console-template for more information
using System.Text;

class Program
{
    public static int summ;
    static void Main(string[] args)
    {
        Console.WriteLine("Задача 64: Задайте значения M и N.Напишите рекурсивный метод, который выведет все натуральные числа кратные 3 - ём в промежутке от M до N.");
        Task64(1,20);
        Console.WriteLine("Задача 66: Задайте значения M и N. Напишите рекурсивный метод, который найдёт сумму натуральных элементов в промежутке от M до N.");
        Task66(1,15);
        Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
        Task68(3,2);

       




    }
    public static void Task66(int n,int m) {
        int start = n;
        summ=summ+start;
        if ((start + 1) <= m) Task66(start + 1, m); else Console.WriteLine(summ);
    }
    public static void Task64(int n, int m)
    {
        int start = n;
        if (start % 3 == 0) Console.WriteLine(start);
        if ((start + 1) <= m) Task64(start + 1, m);
    }
    public static void Task68(int n, int m)
    {
        int functionAkkerman = Ack(m, n);

        Console.Write($"Функция Аккермана = {functionAkkerman} ");
    }
    public static int Ack(int m, int n)
    {
        if (m == 0) return n + 1;
        else if (n == 0) return Ack(m - 1, 1);
        else return Ack(m - 1, Ack(m, n - 1));
    }



}

