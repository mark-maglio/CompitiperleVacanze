using System;

namespace CompitiperleVacanze
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.MaxValue;
            Console.WriteLine(a);//qua il codice stampa il numero massimo
            while(a != int.MaxValue)
            {
                Console.WriteLine(a+1);//qua si nota un'errore perchè a va in overflow per cui stampa 1
            }
            int b = -128;//viene assegnato un valore alla variabile
            int c = -b;//viene assegnato -b a c
            Console.WriteLine(Convert.ToString(b,2));//il valore della variabile b viene convertito in binario
            Console.WriteLine(Convert.ToString(c,2));//il valore della variabile c viene convertito in binario
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
