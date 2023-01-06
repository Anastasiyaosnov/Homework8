// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

int Sum(int[,] array, int i)
{
  int sum = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sum += array[i,j];
  }
  return sum;
}


int UserRows = Prompt("Введите количество строк");
int UserColumns = Prompt("Введите количество столбцов");
int UserMin = Prompt("Введите min");
int UserMax = Prompt("Введите max");

int[,] userMatrix = new int[UserRows, UserColumns];
FillMatrix(userMatrix, UserMin, UserMax);

Print(userMatrix);
Console.WriteLine();

int minSum = 0;
int sumLine = Sum(userMatrix, 0);
for (int i = 1; i < userMatrix.GetLength(0); i++)
{
  int tempSumLine = Sum(userMatrix, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSum = i;
  }
}

Console.WriteLine($"{minSum+1} - строкa с наименьшей суммой >({sumLine}) ");