// Сформируйте двухмерный массив из неповторяющихся случайных 
// двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив. Обратите внимание, что максимальный размер такого 
// массива ограничен. Проверку эл-та на присутствие в массиве можно 
// вынести в отдельную функцию.
// Например,
// 11 22 78
// 12 47 96
// 25 87 88

void FillArray(int[,] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(10, 100);
        }
    }
}

void GetDifferentNumbers(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1); k++)
            {
                if (arr[i, j] == arr[i, k])
                {
                    if (k != j)
                    {
                        arr[i, j] = new Random().Next(10, 100);
                        GetDifferentNumbers(arr);
                    }
                }
            }
        }

    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int rowCount = 5;
int columnCount = 5;
int[,] array = new int[rowCount, columnCount];
FillArray(array);
PrintArray(array);
GetDifferentNumbers(array);
Console.WriteLine();
PrintArray(array);
