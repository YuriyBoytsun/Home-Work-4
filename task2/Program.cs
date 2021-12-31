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

        public int Sum()
        {
            int result = 0;
            for (int i = 0; i < MainArray.Length; i++)
            {
                result += MainArray[i];
            }
            return result;
        }

        public int[] Inverse()
        {
            int[] newArr = new int[MainArray.Length];
            for (int i = 0; i < MainArray.Length; i++)
            {
                newArr[i] = -MainArray[i];
            }

            return newArr;
        }

        public int[] Multi( int mul)
        {
            int[] newArr = new int[MainArray.Length];
            for (int i = 0; i < MainArray.Length; i++)
            {
                newArr[i] = mul * MainArray[i];
            }
            
           return newArr;
        }

        public string MaxCounter()
        {
            string result;
            int max = MainArray[0];
            int repits = 0;
            for (int i = 0; i < MainArray.Length; i++)
            {
                if (MainArray[i] > max)
                {
                    max = MainArray[i];
                    repits = 1;
                }
                else if (MainArray[i] == max) repits++;

            }
            result = $"max = {max}, repits {repits} times";
            return result ;
            
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
    }
    public  struct  Some
        {
            public static void Print(int[] arr)
            {
                foreach (var item in arr)
                {
                    Console.WriteLine(item);
                }
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                MyArrays array1 = new MyArrays(20);
                
                Console.WriteLine( array1.ShowArray());
                Console.WriteLine(array1.MaxCounter());
                Console.WriteLine(array1.Sum());

                Console.WriteLine("##############\n");


                MyArrays array2 = new MyArrays(15, 0, 3);
                Console.WriteLine(array2.ShowArray());
                 
                int[] arr1 = array2.Multi(3);
                Some.Print(arr1);

                Console.WriteLine("##############\n");

                int[] arr2 = array1.Inverse();
                Some.Print(arr2);

            Console.ReadLine();
            }
        }
    
}
