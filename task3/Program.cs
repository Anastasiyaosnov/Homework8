// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


int Prompt(string message)
{
    Console.Write($"{message} >"); // Вывод приглашения
    return Convert.ToInt32(Console.ReadLine()); // ввод числа
}

void FillMatrix(int[,] matr, int min, int max)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max);
        }
    }
}

void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] multiplication(int[,] matrix1, int[,] matrix2, int[,] total)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(0); k++)
            {
                total[i, j] = matrix1[i, k] * matrix2[k, j];
            }
        }
    }

    return total;
}


int UserRows = Prompt("Введите количество строк");
int UserColumns = Prompt("Введите количество столбцов");
int UserMin = Prompt("Введите min");
int UserMax = Prompt("Введите max");

int[,] userMatrix1 = new int[UserRows, UserColumns];
FillMatrix(userMatrix1, UserMin, UserMax);
Print(userMatrix1);
Console.WriteLine();

int[,] userMatrix2 = new int[UserRows, UserColumns];
FillMatrix(userMatrix2, UserMin, UserMax);
Print(userMatrix2);
Console.WriteLine();

int[,] total = new int[UserRows, UserColumns];

Print(multiplication(userMatrix1, userMatrix2, total));

