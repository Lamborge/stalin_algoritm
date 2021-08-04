using System;

namespace stalin_algoritm
{
    class Program
    {

        public static int ArrayLenth;

        static void Main(string[] args)
        {
            Console.WriteLine("Длинна массива: "); ArrayLenth = Convert.ToInt32(Console.ReadLine());
            int[] int_array = new int[ArrayLenth];
            Console.WriteLine("Заполнить массив случайными числами?(y/n)");
            int_array = Console.ReadLine()=="y" ? RandomFillIntArray(int_array) : ManualFillIntArray(int_array);
            foreach (var item in StalinSortArray(int_array))
            {
                Console.WriteLine(item + " ");
            }
        }

        public static int[] RandomFillIntArray(int[] array){
            int[] res_array = array;
            Random rnd = new Random();
            for (var i = 0; i < res_array.Length; i++)
                array[i] = rnd.Next(res_array.Length);

            return res_array;
        }

        public static int[] ManualFillIntArray(int[] array){
            int[] res_array = array;
            for (var i = 0; i < res_array.Length; i++){
                Console.WriteLine($"Введите значение для элемента массива {i}:");
                res_array[i] = Convert.ToInt32(Console.ReadLine());
            }
            return res_array;
        }

        public static int[] StalinSortArray(int[] array){
            int[] temp_array = array;
            for (var i = 1; i < temp_array.Length; i++)
            {
                if ((temp_array[i] - temp_array[i-1]) != 1)
                {
                    temp_array[i] = 0;
                    i++;
                }
            }

            int[] res_array = new int[temp_array.Length];
            for (var i = 0; i < temp_array.Length; i++)
            {
                if (temp_array[i] != 0)
                {
                    res_array[i] = temp_array[i];
                }
                
            }

            return res_array;
        }
    }
}
