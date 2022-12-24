// Задайте прямоугольный двумерный массив. Напишите программу, которая 
// будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка
void FillArray(int[,] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(1, 10);
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

int GetMinSumString(int[,] arr)
{
    int iMinSting = 0;
    int MinSum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        if (i == 0)
        {
            MinSum = sum;
        }
        if (sum < MinSum)
        {
            iMinSting = i;
            MinSum = sum;
        }
    }
    return iMinSting+1;
}

int rowCount = 3;
int columnCount = 4;
int[,] array = new int[rowCount, columnCount];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.Write("Наименьшая сумма элементов в " + GetMinSumString(array) + " строке");