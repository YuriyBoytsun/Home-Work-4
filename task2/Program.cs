/*3.
а) Дописать класс для работы с одномерным массивом.
Реализовать конструктор, создающий массив определенного размера
и заполняющий массив числами от начального значения с заданным шагом.
Создать свойство Sum, которое возвращает сумму элементов массива,
метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива 
(старый массив, остается без изменений), 
метод Multi, умножающий каждый элемент массива на определённое число,
свойство MaxCount, возвращающее количество максимальных элементов.*/
using System;

namespace HW4._2
{
    public class MyArrays
    {
        public int[] MainArray { get; set; }
        public int Maxcout { get; set; }

        public MyArrays(int count)
        {
            MainArray = new int[count];
            Random R = new Random();
            for (int i = 0; i < count; i++)
            {
                MainArray[i] = R.Next(-10000, 10001);
            }
        }

        public MyArrays(int count, int start, int step)
        {
            MainArray = new int[count];
            for (int i = 0; i < count; i++)
            {
                MainArray[i] = start + (step * i);
            }
        }

        public int Sum(int[] arr)
        {
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
            }
            return result;
        }

        public int[] Inverse(int[] arr)
        {
            int[] newArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = -arr[i];
            }

            return newArr;
        }

        public int[] Multi(int[] arr, int mul)
        {
            int[] newArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = mul * arr[i];
            }

            return newArr;
        }

        public int MaxCounter(int[] arr)
        {
            int max = arr[0];
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    result = 1;
                }
                else if (arr[i] == max) result++;

            }
            return result;
        }

        public string ShowArray()
        {
            string result = string.Empty;
            for (int i = 0; i < MainArray.Length; i++)
            {
                result += $"array[{i}] = {MainArray[i]}\n";
            }
            return result;

        }
        class Program
        {
            static void Main(string[] args)
            {
                MyArrays array1 = new MyArrays(20);
                
               Console.WriteLine( array1.ShowArray());

                MyArrays array2 = new MyArrays(15, 0, 3);
                Console.WriteLine(array2.ShowArray());
                
                Console.ReadLine();
            }
        }
    }
}
