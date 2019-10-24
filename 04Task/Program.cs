//Напишете метод, който намира колко пъти дадено число се среща
//в даден масив.Напишете програма, която проверява дали този метод
//работи правилно.
using System;
using System.Linq;

class Program
{
    public static void Main()
    {
        int[] array = { 12, 5, 12, 2, 3, 3, 4, 4, 4, 6, 7, 7, 9, 11, 22, 22 };
        CheckingNumberInArray(array);
    }
    static void CheckingNumberInArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < array.Length; j++)
            {

                if (array[i] == array[j])
                    count = count + 1;
            }
            Console.WriteLine(" " + array[i] + " is repeated " + count + " times");
        }
    }
}





