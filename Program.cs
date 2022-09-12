using System;
{
    Console.WriteLine("Task.47");
    Console.Write("Введите колисчетсво строк: ");
    int ROWS = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int COLUMNS = Convert.ToInt32(Console.ReadLine());


    double[,] array = new double[ROWS, COLUMNS];

    for (int i = 0; i < ROWS; i++)
    {
        for (int j = 0; j < COLUMNS; j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }

    for (int i = 0; i < ROWS; i++)
    {


        for (int j = 0; j < COLUMNS; j++)
        {
            Console.Write(array[i, j] + "  ");

        }
        Console.WriteLine();
    }

}

{
    Console.WriteLine("Task.50");
    Console.WriteLine("Введите номер строки: ");

    int posRows = Convert.ToInt32(Console.ReadLine());
    posRows--;

    Console.WriteLine("Введите номер столбца: ");
    int posColumns = Convert.ToInt32(Console.ReadLine());
    posColumns--;

    Console.WriteLine();


    const int ROWS = 4;
    const int COLUMNS = 3;

    if (posRows >= ROWS || posColumns >= COLUMNS || posRows < 0 || posColumns < 0)
    {
        Console.WriteLine("такого числа в массиве нет");
    }
    else
    {
        int[,] ourMatrix = CreateMatrix(ROWS, COLUMNS);
        PrintMatrix(ourMatrix);
        Console.WriteLine("Результат:");
        Console.WriteLine(ourMatrix[posRows, posColumns]);
    }

    int[,] CreateMatrix(int rows, int columns)
    {
        int[,] matrix = new int[rows, columns];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = new Random().Next(0, 10);
            }
        }
        return matrix;
    }

    void PrintMatrix(int[,] matrix)
    {

        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

}

{
    Console.WriteLine("Task.52");
    Console.Write("Введите колисчетсво строк: ");
    int ROWS = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов : ");
    int COLUMNS = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[ROWS, COLUMNS];

    for (int i = 0; i < ROWS; i++)
    {
        for (int j = 0; j < COLUMNS; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }

    for (int i = 0; i < ROWS; i++)
    {

        for (int j = 0; j < COLUMNS; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }

    Console.WriteLine("Результат:");

   string result = "";
    for (int i = 0; i < ROWS; i++)
    {
        int temp = 0;
        for (int j = 0; j < COLUMNS; j++)
        {
            temp += array[i, j];
        }
        result = result + ((float)temp / ROWS) + "\n";
    }
    Console.WriteLine(result);
}







