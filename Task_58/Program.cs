//Задача 58: Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.

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

void ArrayMultiplication(int[,] arrayA, int[,] arrayB)
{

    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    
    if (arrayA.GetLength(1) == arrayB.GetLength(0))
    {

        for (int i = 0; i < arrayA.GetLength(0); i++)
        {
            for (int j = 0; j < arrayB.GetLength(1); j++)
            {
                for (int k = 0; k < arrayB.GetLength(0); k++)
                {
                    arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
                }
            }
        }
        Console.WriteLine("Matrix multiplication:");
        Console.WriteLine();
        PrintArray(arrayC);
    }
    else Console.Write("Matrix multiplication is not possible");

}

Console.Clear();

Console.WriteLine("Array A:");
int[,] arrA = NewArray(3, 2, 1, 3);
Console.WriteLine();
PrintArray(arrA);
Console.WriteLine();

Console.WriteLine("Array B:");
int[,] arrB = NewArray(2, 3, 1, 3);
Console.WriteLine();
PrintArray(arrB);
Console.WriteLine();

ArrayMultiplication(arrA, arrB);
// Console.WriteLine("Matrix multiplication:");
// Console.WriteLine();
// PrintArray(arrC);
