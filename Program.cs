using System.Text;

int programm, num;
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

            break;

        case 2:

           
            break;

        case 3:

           
            break;

        case 4:

            
            break;

        default:
            begin = false;
            break;
    }
}
