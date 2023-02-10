/*Задача 50. Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

void SearchNum(int[,] matrix, int rows, int columns, int iPos, int jPos)
{
    int numPos = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    if (iPos >= rows || jPos >= columns)
        Console.WriteLine("номер строки: " +iPos +" номер столца: "+ jPos + "-> такого числа в массиве нет");
    else
    {
        numPos = matrix[iPos, jPos];
        Console.WriteLine("номер строки: " +iPos +" номер столца: "+ jPos + " -> число: " + numPos);
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
int positionRows = GetNumFromUser("Введите позицию строки: ");
int positionColum = GetNumFromUser("Введите позицию столбца: ");

// Генерация 2х мерного массива размером м и н
int[,] realArray = GenerateMatrix(row, column, 10);

//Ищем число с заданной позицией
SearchNum(realArray, row, column, positionRows, positionColum);