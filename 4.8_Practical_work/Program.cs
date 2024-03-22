using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._8_Practical_work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет, давайте создадим матрицу...");
            Console.Write("Введите количество строк: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int col = int.Parse(Console.ReadLine());

            int[,] matrix1 = new int[row, col];
            int[,] matrix2 = new int[row, col];
            int[,] matrixSum = new int[row, col];
            int sum = 0;

            Random r = new Random();

            for (int i = 0; i < row; i++) 
            {
                for (int j = 0; j < col; j++) 
                {
                    matrix1[i, j] = r.Next(10);
                    matrix2[i, j] = r.Next(10);
                    matrixSum[i, j] = matrix1[i, j] + matrix2[i, j];
                    sum += matrix1[i, j];
                    Console.Write($"{matrix1[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Сумма всех элементов матрицы составит: {sum}.");
            Console.WriteLine("\nТеперь создадим ещё одну матрицу того же размера и выполним их сложение.");
            Console.Write("Для продолжения нажмите Enter...");
            Console.ReadLine();

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"{matrix1[i, j]} ");
                }

                if ((row % 2 == 0 && i == row / 2 - 1) || (row % 2 != 0 && i == row / 2))
                {
                    Console.Write(" +  ");
                }
                else 
                {
                    Console.Write("    ");
                }

                for (int j = 0; j < col; j++)
                {
                    Console.Write($"{matrix2[i, j]} ");
                }

                if ((row % 2 == 0 && i == row / 2 - 1) || (row % 2 != 0 && i == row / 2))
                {
                    Console.Write(" =  ");
                }
                else
                {
                    Console.Write("    ");
                }

                for (int j = 0; j < col; j++)
                {
                    Console.Write($"{matrixSum[i, j], 2} ");
                }

                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
