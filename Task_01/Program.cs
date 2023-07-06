// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] Created2dArray(int rows, int columns, int minV, int maxV)
{
    int[,] createdArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            createdArray[i, j] = new Random().Next(minV, maxV + 1);
    return createdArray;
}

void ShowArray(int[,] printedArray)
{
    for (int i = 0; i < printedArray.GetLength(0); i++)
    {
        for (int j = 0; j < printedArray.GetLength(1); j++)
        {
            Console.Write(printedArray[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void OrderedArray(int[,] arrayToChange)
{
    for (int i = 0; i < arrayToChange.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToChange.GetLength(1); j++)
        {
            for (int z = 0; z < arrayToChange.GetLength(1) - 1; z++)
            {
                if (arrayToChange[i, z] < arrayToChange[i, z + 1])
                {
                    int temp = arrayToChange[i, z + 1];
                    arrayToChange[i, z + 1] = arrayToChange[i, z];
                    arrayToChange[i, z] = temp;
                }
            }
        }
    }
}

Console.Write("Input count of rows: ");
int userRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input count of columns: ");
int userColumns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min value: ");
int userMin = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max value: ");
int userMax = Convert.ToInt32(Console.ReadLine());

int[,] newArray = Created2dArray(userRows, userColumns, userMin, userMax);
ShowArray(newArray);
Console.WriteLine("Ordered array: ");
OrderedArray(newArray);
ShowArray(newArray);


