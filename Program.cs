using System;

namespace MatrixArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк массива:\t");
            int lines = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов массива:\t");
            int column = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int[,] array = new int[lines, column ];


            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write("Введите элемент с индексом[" + i + "," + j + "]: ");
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();

            Console.WriteLine("Вывод массива:");

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}