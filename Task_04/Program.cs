// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

HashSet<int> randomSet = new HashSet<int>(); // учет уже использованных двухзначных чисел 
int UniqueRandomInt() 
{
    var rand = new Random();
    int myNumber;
    do
    {
       myNumber = rand.Next(10, 100);
    } while (randomSet.Contains(myNumber));
	randomSet.Add(myNumber);
    return myNumber;
}
int[,,] Create3DArray(int randomRows, int randomColls, int randomDepth) // создание трехмерного массива
{
    int[,,] createdRandom3dArray = new int[randomRows, randomColls, randomDepth];

    for (int i = 0; i < randomRows; i++)
    {
        for (int j = 0; j < randomColls; j++)
        {
            for (int z = 0; z < randomDepth; z++)
            {
                createdRandom3dArray[i, j, z] = UniqueRandomInt();
            }
        }
    }
    return createdRandom3dArray;
}

void Print3DArray(int[,,] array3d)
{
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int z = 0; z < array3d.GetLength(2); z++)
            {
                Console.Write(array3d[i, j, z]);
                Console.Write($"({i},{j},{z}) ");
            }
            Console.WriteLine(); // переход вывода на новую строку
        }
    }
    Console.WriteLine(); // отступ от массива
}

int randomRows = new Random().Next(2, 3);
int randomColls = new Random().Next(2, 3);
int randomDepth = new Random().Next(2, 3);
int[,,] new3dArray = Create3DArray(randomRows, randomColls, randomDepth);
Console.WriteLine($"Массив размером {randomRows} X {randomColls} X {randomDepth}");
Print3DArray(new3dArray);
