using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Process proceso = new Process();

        proceso.StartInfo.FileName = "dotnet";
        proceso.StartInfo.Arguments = "--version";
        proceso.StartInfo.RedirectStandardOutput = true;
        proceso.StartInfo.UseShellExecute = false;
        proceso.StartInfo.CreateNoWindow = true;

        proceso.Start();

        string resultado = proceso.StandardOutput.ReadToEnd();

        proceso.WaitForExit();

        Console.WriteLine("Versión de .NET:");
        Console.WriteLine(resultado);

        proceso.Dispose();
    }
}
