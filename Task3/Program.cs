/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void SearchAverageNum(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double averageNum = 0;
        double sumNum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sumNum += matrix[i, j];
        }
        averageNum = sumNum / matrix.GetLength(0);
        Console.Write(Math.Round(averageNum, 2) + "\t");
    }
}

int[,] GenerateMatrix(int rows, int columns, int to)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(0, to + 1);
        }
    }
    return result;
}

int GetNumFromUser(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

// ввод пользователем размерности массива
int row = GetNumFromUser("Введите число сторк: ");
int column = GetNumFromUser("Введите число столбцов: ");


// Генерация 2х мерного массива размером м и н
int[,] realArray = GenerateMatrix(row, column, 10);

// Выводим массив
ShowMatrix(realArray);

//Ищем число 
SearchAverageNum(realArray);