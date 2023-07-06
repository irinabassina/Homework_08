// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int SumElemLine(int[,] arrayToCount, int i)  // метод, суммирует элементы в строке
{
    int sumLine = arrayToCount[i, 0];
    for (int j = 1; j < arrayToCount.GetLength(1); j++)
    {
        sumLine += arrayToCount[i, j];
    }
    return sumLine;
}

Console.Write("Input count of rows: ");
int userRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input count of columns: ");
int userColumns = Convert.ToInt32(Console.ReadLine());

if (userRows == userColumns)
{ 
Console.WriteLine("Error! Impossible value! Array is not rectangular!");
return;
}

Console.Write("Input min value: ");
int userMin = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max value: ");
int userMax = Convert.ToInt32(Console.ReadLine());

int[,] newArray = Created2dArray(userRows, userColumns, userMin, userMax);
ShowArray(newArray);

int minSumLine = 0;
int sumLine = SumElemLine(newArray, 0);
for (int i = 1; i < newArray.GetLength(0); i++)
{
    int temp = SumElemLine(newArray, i);
    if (sumLine > temp)
    {
        sumLine = temp;
        minSumLine = i;
    }
}
Console.WriteLine($"{minSumLine + 1} - the row with the smallest sum of elements: {sumLine}");
