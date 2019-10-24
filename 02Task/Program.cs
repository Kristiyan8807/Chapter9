//Създайте метод GetMax() с два целочислени(int) параметъра, който
//връща по-голямото от двете числа.Напишете програма, която прочи-
//та три цели числа от конзолата и отпечатва най-голямото от тях, изпол-
//звайки метода GetMax().
using System;

class Program
{
    static void Main()
    {
        Console.Write("Напишете първото число: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Напишете второто число: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.Write("Напишете третото число: ");
        int num3 = int.Parse(Console.ReadLine());
        GetMax(num1, num2, num3);
    }

    static void GetMax(int num1, int num2, int num3)
    {
        if (num1 > num2)
        {
            if (num1 > num3)
            {
                Console.Write("Първото число е най-голямо: {0}", num1);
            }
            else
            {
                Console.Write("Третото число е най-голямо: {0}", num3);
            }
        }
        else if (num2 > num3)
            Console.Write("Второто число е най-голямо: {0}", num2);
        else
            Console.Write("Третото число е най-голямо: {0}", num3);
    }
}
