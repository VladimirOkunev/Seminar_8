//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
//двузначных чисел. Напишите программу, которая будет построчно 
//выводить массив, добавляя индексы каждого элемента.

int[,,] NewArray(int x, int y, int z)
{
    int[,,] array = new int[x, y, z];
    int startValue = 10;
    for (int k = 0; k < z; k++)
    {
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
             array[i, j, k] = startValue;
             startValue++;
            }

        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j, k],7} ({i},{j},{k}) |");
                else Console.Write($"{array[i, j, k],7} ({i},{j},{k})");
            }
            Console.WriteLine(" ");
        }
    }

}

Console.Clear();
int [,,] arr = NewArray(2,2,2);
PrintArray(arr);