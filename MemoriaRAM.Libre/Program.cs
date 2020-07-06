using System;
using System.Diagnostics;
using System.Threading;

////////////////////////////////////////////////////////
// Descripción del programa: muestra la RAM libre     //
// Autor del programa: Jesús Hdz. Ramírez (Virus)     //
////////////////////////////////////////////////////////

namespace MemoriaRAM.Libre
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            PerformanceCounter ramCounter = new PerformanceCounter("Memory", "Available MBytes");

            while (true)
            {
                Console.Clear();
                Console.WriteLine(ramCounter.NextValue() + "MB");
                Thread.Sleep(1000);
            }
        }
    }
}