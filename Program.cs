using System.Text;

int programm;
Boolean begin = true;

while (begin)
{
    Console.WriteLine("\nЗадача 1. Двумерный массив, со случайными вещественными числами\nЗадача 2. Поиск элемента в массиве\nЗадача 3. Поиск среднего арифметического каждого столбца в массиве\nВведите 0 для выхода\n");
    Console.Write("Введите номер задачи: ");
    programm = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    switch (programm)
    {
        case 1:

            Console.Write("Введите количество строк: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int cols = Convert.ToInt32(Console.ReadLine());
            double[,] numbers = new double[rows, cols];
            FillArrayRandomNumbers(numbers);
            PrintArray(numbers);

            break;

        case 2:

            int row = ReadInt("Введите индекс строки: ");
            int columns = ReadInt("Введите индекс столбца: ");
            int[,] num = new int[6, 8];
            FillArray2D(num);
            PrintArray2D(num);

            if (row < num.GetLength(0) && columns < num.GetLength(1)) Console.WriteLine(num[row, columns]);
            else Console.WriteLine($"{row}{columns} -> такого числа в массиве нет");

            break;

        case 3:

           
            break;

        default:
            begin = false;
            break;
    }
}


void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}