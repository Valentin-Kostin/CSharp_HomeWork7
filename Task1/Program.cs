/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/



void ShowMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(Math.Round(matrix[i, j], 2) + "\t");
        }
        Console.WriteLine();
    }
}

double[,] GetRealArray(int row, int column, int low, int up)
{
    double[,] array = new double[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().NextDouble() * (up - low) + low;
        }
    }
    return array;
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
int random = GetNumFromUser("Введите диапазон: ");

// Генерация 2х мерного массива размером м и н
double[,] realArray = GetRealArray(row, column, random, -random);

// Вывод на экран
ShowMatrix(realArray);