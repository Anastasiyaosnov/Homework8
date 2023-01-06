// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void Sort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - 1; j++)
        {
            if (array[j] < array[j + 1])
            {
                int z = array[j];
                array[j] = array[j + 1];
                array[j + 1] = z;
            }
        }
    }
}


int[,] RangRows(int[,] array)
{
    
    for (int index = 0; index < array.GetLength(0); index++)
    {
        int[] zone = new int[array.GetLength(1)];
        for (int i = 0; i < array.GetLength(1); i++)
        {
            zone[i] = array[index, i];
        }
        Sort(zone);

        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[index, j] = zone[j];
        }

    }
    return array;
}

// void Sort(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       for (int k = 0; k < array.GetLength(1) - 1; k++)
//       {
//         if (array[i, k] < array[i, k + 1])
//         {
//           int temp = array[i, k + 1];
//           array[i, k + 1] = array[i, k];
//           array[i, k] = temp;
//         }
//       }
//     }
//   }
// }



int UserRows = Prompt("Введите количество строк");
int UserColumns = Prompt("Введите количество столбцов");
int UserMin = Prompt("Введите min");
int UserMax = Prompt("Введите max");

int[,] userMatrix = new int[UserRows, UserColumns];
FillMatrix(userMatrix, UserMin, UserMax);

Print(userMatrix);
Console.WriteLine();

Print(RangRows(userMatrix));
