using System;
using System.Threading;

class Program
{
    static void MostrarNumeros()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Número: " + i);
            Console.WriteLine("ID hilo secundario: " + Environment.CurrentManagedThreadId);
            Thread.Sleep(500);
        }
    }

    static void Main(string[] args)
    {
        Thread hilo = new Thread(MostrarNumeros);
        hilo.Start();

        Console.WriteLine("Mensaje del hilo principal");
        Console.WriteLine("ID hilo principal: " + Environment.CurrentManagedThreadId);
        

        hilo.Join();
    }
}
