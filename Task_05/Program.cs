// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

double[,] squareMatrix = new double[4, 4];
int temp = 1;
int i = 0;
int j = 0;

while (temp <= squareMatrix.GetLength(0) * squareMatrix.GetLength(1))
{
    squareMatrix[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < squareMatrix.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= squareMatrix.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > squareMatrix.GetLength(1) - 1)
        j--;
    else
        i--;
}

void PrintArray(double[,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write($"{arrayToPrint[i, j].ToString().PadLeft(2, '0')} ");
        }
        Console.WriteLine();
    }
}

PrintArray(squareMatrix);
