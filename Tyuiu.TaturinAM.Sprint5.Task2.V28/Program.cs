using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TaturinAM.Sprint5.Task2.V28.Lib;
namespace Tyuiu.TaturinAM.Sprint5.Task2.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5| Выполнил: Татурин А. М. | САРТб-23-1";
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                                                  *");
            Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл                                         *");
            Console.WriteLine("* Задание #2                                                                                                 *");
            Console.WriteLine("* Вариант #12                                                                                                *");
            Console.WriteLine("* Выполнил: Татурин Артем Максимович | САРТб-23-1                                                            *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                   *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный значениями с клавиатуры.                  *");
            Console.WriteLine("* Заменить положительные элементы массива на 1, отрицательные на 0. Результат сохранить в файл               *");
            Console.WriteLine("* OutPutFileTask2.csv и вывести на консоль. -5; -5; 9 -7; 3; -4 8; 7; 9                                      *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                           *");
            Console.WriteLine("**************************************************************************************************************");
            int[,] matrix = new int[3, 3] { { -5, -5, 9 }, { -7, 3, -4 }, { 8, 7, 9 } };
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                 *");
            Console.WriteLine("**************************************************************************************************************");
            string res = ds.SaveToFileTextData(matrix);
            Console.WriteLine("Файл" + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
