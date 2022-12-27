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

            Console.Write("Введите строку: ");
            int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.Write("Введите столбец: ");
            int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;
            int n = 5;
            int m = 7;
            Random random = new Random();
            int[,] arr = new int[n, m];
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.Next(10, 99);
                    Console.Write("{0} ", arr[i, j]);
                }
                Console.WriteLine();
            }
            if (pos1 < 0 | pos1 > arr.GetLength(0) - 1 | pos2 < 0 | pos2 > arr.GetLength(1) - 1)
            {
                Console.WriteLine("Элемент не существует");
            }
            else
            {
                Console.WriteLine("Значение элемента массива = {0}", arr[pos1, pos2]);
            }
            Console.ReadLine();

            break;

        case 3:

            Console.Write("Введите кол-во строк: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол-во столбцов: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            double[,] arr_2 = new double[a, b];
            double[] sum = new double[b];
            Random ran = new Random();

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    arr_2[i, j] = ran.Next(0, 100);

                    Console.Write(arr_2[i, j] + "\t");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    sum[i] += arr_2[j, i];
                }
            }
            Console.WriteLine("-------------------------------------");
            for (int i = 0; i < b; i++)
            {
                Console.Write((sum[i] / a) + "\t");
            }
            Console.ReadLine();

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