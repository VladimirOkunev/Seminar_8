//Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки 
//двумерного массива.

int[,] NewArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {

            array[i, j] = new Random().Next(minValue, maxValue);

        }

    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],7} |");
            else Console.Write($"{array[i, j],7}");
        }
        Console.WriteLine(" ");
    }

}

void ArraySort(int[,] array)
{
    int temporaryValue = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)

                if (array[i, k] > array[i, j])
                {
                    temporaryValue = array[i, k];
                    array[i, k] = array[i, j];
                    array[i, j] = temporaryValue;
                }

        }

    }
}

Console.Clear();

Console.WriteLine("Enter size of 2D array");
Console.Write("Numbers of rows: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Numbers of columns: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter minimum value of range of the array: ");
int min = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter maximum value of range of the array: ");
int max = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("");
int[,] array = NewArray(m, n, min, max);
PrintArray(array);
ArraySort(array);
Console.WriteLine("");
PrintArray(array);

