//Напишете метод, който при подадено име отпечатва на конзолата
//"Hello, <name>!" (например "Hello, Peter!"). Напишете програма,
//която тества дали този метод работи правилно.
using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Напишете си името: ");
            string name = Console.ReadLine();
            UserName(name);
        }
        static void UserName(string name)
        {
            Console.WriteLine($"Здравей {name}");
        }
    }
