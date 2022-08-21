// See https://aka.ms/new-console-template for more information
using System.Text;

class Program
{
    public static int[,] numbers = new int[5, 5];
    public static int[,] numbers1 = new int[3, 5];
    public static int size = 4;
    static void Main(string[] args)
    {
        Task54();
        Task56();
        Task58();

       




    }
    public static void Task54() {
        Console.WriteLine("Задача 54: Задайте двумерный массив.Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
        FillArrayRandomNumbers(numbers);
        Console.WriteLine();
        Console.WriteLine("Массив до изменения");
        PrintArray(numbers);
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1) - 1; j++)
            {
                for (int z = 0; z < numbers.GetLength(1) - 1; z++)
                {
                    if (numbers[i, z] < numbers[i, z + 1])
                    {
                        int temp = 0;
                        temp = numbers[i, z];
                        numbers[i, z] = numbers[i, z + 1];
                        numbers[i, z + 1] = temp;
                    }
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine("Массив с упорядоченными значениями");
        PrintArray(numbers);
    }
    public static void Task56()
    {
        Console.WriteLine("Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
        FillArrayRandomNumbers(numbers1);
        PrintArray(numbers1);
        int minsum = Int32.MaxValue;
        int indexLine = 0;

        for (int i = 0; i < numbers1.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < numbers1.GetLength(1); j++)
            {
                sum = sum + numbers1[i, j];
            }
            if (sum < minsum)
            {
                minsum = sum;
                indexLine++;
            }
        }

        Console.WriteLine("Cтрока с наименьшей суммой елементов под номером: " + (indexLine) + ", с суммой елементов равной: " + (minsum)+"\n");
    }
    public static void Task58() {
            
            var result = new int[size, size];
            for (int currentChar = 1, padding = 0; padding < size / 2; padding++)
            {
                for (int j = padding; j < size - padding; j++)
                    result[padding, j] = currentChar;
                for (int j = padding; j < size - padding; j++)
                    result[size - padding - 1, j] = currentChar;
                for (int i = padding + 2; i < size - padding - 1; i++)
                    result[i, padding] = currentChar;
                for (int i = padding + 1; i < size - padding - 1; i++)
                    result[i, size - padding - 1] = currentChar;
                currentChar = 1 - currentChar;
                result[padding + 1, padding] = currentChar;
            }
            if (size % 2 != 0 && result[0, 0] == 1)
                result[size / 2, size / 2] = 1;
            PrintArray(result);
   
    }
    public static void FillArrayRandomNumbers(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(0, 10);
            }
        }
    }

    public static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write("[ ");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.Write("]");
            Console.WriteLine("");
        }
    }
}

