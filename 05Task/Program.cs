//Напишете метод, който проверява дали елемент, намиращ се на дадена
//позиция от масив, е по-голям от двата му съседа.Тествайте метода
//дали работи коректно.
using System;

namespace _05Task
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter array length: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Enter position in array: ");
            int position = Int32.Parse(Console.ReadLine());

            CompareNumbers(arr, position);
        }

        static void CompareNumbers(int[] array, int pos)
        {
            if (array[pos] > array[pos - 1] && array[pos] > array[pos + 1])
            {
                Console.WriteLine("{0} is bigger than left and right neighbours", array[pos]);
            }
            if (array[pos] < array[pos - 1] && array[pos] < array[pos + 1])
            {
                Console.WriteLine("{0} is smaller than left and right neighbours", array[pos]);
            }
            if (array[pos] < array[pos - 1])
            {
                Console.WriteLine("{0} is smaller than left neighbours", array[pos]);
            }
            if (array[pos] < array[pos + 1])
            {
                Console.WriteLine("{0} is smaller than right neighbours", array[pos]);
            }
            if (array[pos] == array[pos + 1])
            {
                Console.WriteLine("{0} is equal than right neighbours", array[pos]);
            }
            if (array[pos] == array[pos + -1])
            {
                Console.WriteLine("{0} is equal than left neighbours", array[pos]);
            }
            if (array[pos] == array[pos + -1] && array[pos] == array[pos + +1])
            {
                Console.WriteLine("{0} is equal than left neighbours and right neighbours", array[pos]);
            }
        }
    }
}

