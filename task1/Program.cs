/*1. Дан целочисленный массив из 20 элементов.
 * Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.
 * Заполнить случайными числами. Написать программу,
 * позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3.
 * В данной задаче под парой подразумевается два подряд идущих элемента массива.*/
using System;

namespace HW4._1
{
    struct MyArray
    {
        public void FillArray(int[] arr)
        {
            Random R = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = R.Next(-10000, 10001);
            }
        }

        public string ShowArray(int[] arr)
        {
            string result = string.Empty;
            for (int i = 0; i < arr.Length; i++)
            {
                result += $"array[{i}] = {arr[i]}\n";
            }
            return result;
        }

        public string Task(int[] arr)
        {
            string result = "Пары:\n";
            int sum = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] % 3 == 0 && arr[i + 1] % 3 != 0)
                {
                    result += $"{arr[i]},{arr[i + 1]}\n";
                    sum++;
                }
            }
            result += $"Результат: {sum}\n";
            return result;
        }

        public string SubTask(int[] arr)
        {
            string result = "Проверка:\n";
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] % 3 == 0 && arr[i + 1] % 3 != 0)
                {
                    int first = arr[i] / 3;
                    double ar = arr[i + 1];
                    double second = ar / 3;
                    result += $"{arr[i]}/3={first}, {arr[i + 1]}/3={second:F2}\n";
                }
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            MyArray a;
            a.FillArray(array);
            Console.WriteLine(a.ShowArray(array));

            Console.WriteLine(a.Task(array));

            Console.WriteLine(a.SubTask(array));
            Console.ReadKey();
        }
    }
}
