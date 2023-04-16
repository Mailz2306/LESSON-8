/*
Задача 53: Задайте двумерный массив. Напишите программу, которая 
поменяет местами первую и последнюю строку массива.
Задача 55: Задайте двумерный массив. Напишите программу, которая 
заменяет строки на столбцы. В случае, если это невозможно, программа 
должна вывести сообщение для пользователя.
Задача 57: Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз встречается 
элемент входных данных.
Набор данных
Частотный массив
{ 1, 9, 9, 0, 2, 8, 0, 9 }
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза
1, 2, 3 4, 6, 1 2, 1, 6
1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза

ЗАДАЧА 53

int[,] array = Generate2DArray(3, 4);

Print2DArray(array);
RevesreArray(array);
Console.WriteLine();
Print2DArray(array);

int[,] Generate2DArray(int m, int n)
{

    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            Console.Write(" ");
        }

        Console.WriteLine();
    }
}

void RevesreArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(1); i++)
    {
        int tmp = array[0, i];
        array[0, i] = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = tmp;
    }
}
___________ 

ЗАДАЧА 55:
Задайте двумерный массив. Напишите программу, которая 
заменяет строки на столбцы. В случае, если это невозможно, программа 
должна вывести сообщение для пользователя.

int[,] array = Generate2DArray(3, 3);

RevesreArray(array);

Print2DArray(array);

ChangeRowsArray(array);

Console.WriteLine();

Print2DArray(array);

int[,] Generate2DArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}

void RevesreArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(1); i++)
    {
        int tmp = array[0, i];
        array[0, i] = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = tmp;
    }
}

void ChangeRowsArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
            int tmp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = tmp;
        }
    }
}

ЗАДАЧА 57 
Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз встречается 
элемент входных данных.
Набор данных
Частотный массив
{ 1, 9, 9, 0, 2, 8, 0, 9 }
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза
1, 2, 3 4, 6, 1 2, 1, 6
1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза


int[,] array = Generate2DArray(2, 15);
Console.WriteLine("Вот твой массив, кожаный ублюдок");
PrintArray(array);
Console.WriteLine("В этом массиве: ");
Dictionary<int, int> result = SummIndexTimes(array);
foreach(var row in result)
{
    if (row.Value == (1) | row.Value == (5)| row.Value == (6))
    {
        Console.WriteLine($"Цифра {row.Key} встречается {row.Value} раз");
    } 
        else 
        {
            Console.WriteLine($"Цифра {row.Key} встречается {row.Value} раза");
        }
}
void PrintArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}

int[,] Generate2DArray(int m, int n)
{
    int[,] array = new int[m, n];

    Random random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }

    return array;
}

Dictionary<int, int> SummIndexTimes(int[,] array)
{
    Dictionary<int, int> dic = new Dictionary<int, int>();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (!dic.TryAdd(array[i, j], 1))
            {
                dic[array[i, j]] += 1;
            }
        }
    }
    return dic;
}
_______________________
КОНЕЦ СЕМИНАРА 
ДОМАШНИЕ ЗАДАНИЯ 
Задача 54:
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
РЕШЕНИЕ: 
___________________________
Console.Write("Введите размерность m массива: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите размерность n массива: ");
int n = int.Parse(Console.ReadLine());

int[,] randomArray = new int[m, n];

void GenerateArray(int m, int n)
{
    int i, j;
    Random rand = new Random();
    for (i = 0; i < m; i++)
    {
        for (j = 0; j < n; j++)
        {
            randomArray[i, j] = rand.Next(1, 9);
        }
    }
}

void PrintArray(int[,] array)
{
    int i, j;
    for (i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
    }
}

GenerateArray(m, n);
Console.WriteLine("Например, задан массив: ");
PrintArray(randomArray);

void DecrieseArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

DecrieseArray(randomArray);
Console.WriteLine();
Console.WriteLine("В итоге получается вот такой массив: ");
PrintArray(randomArray);
____________________________ 


*/

