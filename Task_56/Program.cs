//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку 
//с наименьшей суммой элементов.

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

void CheckRowSum(int[,] array)
{
    int sum = 0, sumMin = 0, rowNum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        Console.WriteLine($"Sum of {i} row: {sum}");
        if(i==0) sumMin = sum;
        if (sum < sumMin)
        {
            sumMin = sum;
            rowNum = i;
        }
        sum = 0;
    }
    Console.Write($"Number of the row with minimum sum: {rowNum}");
}

Console.Clear();

int[,] newArray = NewArray(5, 5, 0, 101);
PrintArray(newArray);
Console.WriteLine();
CheckRowSum(newArray);