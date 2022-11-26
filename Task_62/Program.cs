//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] NewArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    int dx = 1; //flag of direction x
    int dy = 1; //flag of direction y
    int endX = array.GetLength(1);
    int endY = array.GetLength(0);
    int position = 0;
    int startX = 0;
    int startY = 1;
    int value = 1;
    int additionalVariable = 0;

    while (value <= array.GetLength(0) * array.GetLength(1))
     {

        if (dx == 1 && value <= array.GetLength(0) * array.GetLength(1))
        {
            for (int i = startX; i < endX; i++)
            {
                array[position, i] = value;
                value++;
                additionalVariable = i;
            }
            dx = -1;
            position = additionalVariable;
            endX = startX;
            startX = additionalVariable - 1;

        }

        if (dy == 1 && value <= array.GetLength(0) * array.GetLength(1))
        {
            for (int j = startY; j < endY; j++)
            {
                array[j, position] = value;
                value++;
                additionalVariable = j;
            }
            dy = -1;
            position = additionalVariable;
            endY = startY;
            startY = additionalVariable - 1;
        }

        if (dx == -1 && value <= array.GetLength(0) * array.GetLength(1))
        {
            for (int m = startX; m >= endX; m--)
            {
                array[position, m] = value;
                value++;
                additionalVariable = m;
            }
            dx = 1;
            position = additionalVariable;
            endX = startX + 1;
            startX = additionalVariable + 1;
        }

        if (dy == -1 && value <= array.GetLength(0) * array.GetLength(1))
        {
            for (int n = startY; n >= endY; n--)
            {
                array[n, position] = value;
                value++;
                additionalVariable = n;
            }
            dy = 1;
            position = additionalVariable;
            endY = startY + 1;
            startY = additionalVariable + 1;
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

int[,] arr = NewArray(9, 8);
PrintArray(arr);