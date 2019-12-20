using System;

namespace CompitiperleVacanze
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.MaxValue;
            Console.WriteLine(a);//qua il codice stampa il numero massimo
            Console.WriteLine(a+1);//qua si nota un'errore perchè a va in overflow per qui stampa 1
            int b = -128;
            int c = -b;
            Console.WriteLine(Convert.ToString(b,2));
            Console.WriteLine(Convert.ToString(c,2));
            int value = 31;
            int somma = value;
            value = ~value + 1; //NOT
            //value = value + 1;
            somma = somma + value;
            Console.WriteLine($"{value} e {somma}");
            long number = 55555;
            Console.WriteLine(Convert.ToString(number,2));
            short number1 = (short)number;
            Console.WriteLine(number1);
            Console.ReadLine();
        }
    }
}
