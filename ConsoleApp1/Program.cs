// See https://aka.ms/new-console-template for more information
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string[] array = new string[7] { "123", "23", "hello", "track", "set","test","kek" };
        string[] array1 = new string[array.Length];
        SecondArrayWithIF(array, array1);
        PrintArray(array1);




    }
   
    public static void SecondArrayWithIF(string[] array1, string[] array2)
    {
        int count = 0;
        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i].Length <= 3)
            {
                array2[count] = array1[i];
                count++;
            }
        }
    }
    public static void PrintArray(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
    }
    


}

