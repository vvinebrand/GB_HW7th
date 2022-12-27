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
