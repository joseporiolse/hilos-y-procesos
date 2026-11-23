using System;
using System.Threading;

class Program
{
    static int contador = 0;

    static void Incrementar()
    {
        for (int i = 0; i < 100000; i++)
        {
            Interlocked.Increment(ref contador);
        }
    }

    static void Main(string[] args)
    {
        Thread hilo1 = new Thread(Incrementar);
        Thread hilo2 = new Thread(Incrementar);

        hilo1.Start();
        hilo2.Start();

        hilo1.Join();
        hilo2.Join();

        Console.WriteLine("Resultado: " + contador);
    }
}
