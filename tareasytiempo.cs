using System;
using System.Diagnostics;
using System.Threading.Tasks;

class Program
{
    static async Task Descargar(int numero, int segundos)
    {
        Console.WriteLine("Iniciando descarga " + numero);

        await Task.Delay(segundos * 1000);

        Console.WriteLine("Descarga " + numero + " terminada");
    }

    static async Task Main(string[] args)
    {
        Stopwatch reloj = new Stopwatch();

        reloj.Start();

        await Descargar(1, 1);
        await Descargar(2, 2);
        await Descargar(3, 3);

        reloj.Stop();

        Console.WriteLine("Tiempo total: " + reloj.Elapsed.TotalSeconds + " segundos");
    }
}
