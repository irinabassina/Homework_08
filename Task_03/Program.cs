// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

void MultiplArray(int[,] newArray1, int[,] newArray2, int[,] multiplArray)
{
    for (int i = 0; i < multiplArray.GetLength(0); i++)
    {
        for (int j = 0; j < multiplArray.GetLength(1); j++)
        {
            int sumMultiplElem = 0;
            for (int z = 0; z < newArray1.GetLength(1); z++)
            {
                sumMultiplElem += newArray1[i, z] * newArray2[z, j];
            }
            multiplArray[i, j] = sumMultiplElem;
        }
    }
}

Console.Write("Input count of rows for 1st Matrix: ");
int userRows1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input count of 1st Matrix columns which is the same as count of 2nd Matrix rows : ");
int userColumns1Rows2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input count of 2nd Matrix columns: ");
int userColumns2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min value: ");
int userMin = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max value: ");
int userMax = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Matrix1: ");
int[,] newArray1 = Created2dArray(userRows1, userColumns1Rows2, userMin, userMax);
ShowArray(newArray1);
Console.WriteLine("Matrix2: ");
int[,] newArray2 = Created2dArray(userColumns1Rows2, userColumns2, userMin, userMax);
ShowArray(newArray2);

int[,] multiplArray = new int[userRows1, userColumns2];
MultiplArray(newArray1, newArray2, multiplArray);
Console.WriteLine("The multiplication of the first and second Matrix is : ");
ShowArray(multiplArray);









