using System;
using System.Diagnostics;

namespace Lab02_RecursivoFibonacci
{
    class Program
    {
         static void Main(string[] args)
        {
            int n, k;
            do {
    		Console.Write("Introduzca el número de términos: ");
    		n = int.Parse(Console.ReadLine());

    	    }while (n <= 1);
            Stopwatch timeMeasure = new Stopwatch();
			timeMeasure.Start();

            Console.WriteLine("\tSerie números de fibonacci recursivo: ");
            for (k = 0; k < n; k++) {
    		    Console.Write(FibonacciRecursivo(k)+ " ");
    	    }
            timeMeasure.Stop();
			Console.WriteLine($"Tiempo: {timeMeasure.Elapsed.TotalMilliseconds} ms");

            timeMeasure.Start();
    	    Console.WriteLine("\n\tSerie números de fibonacci iterativo: ");
    	    FibonacciIterativo(n);
            timeMeasure.Stop();
			Console.WriteLine($"Tiempo: {timeMeasure.Elapsed.TotalMilliseconds} ms");
        }

         static int FibonacciRecursivo(int n) {
    	    if (n < 2) { return n; }
    	    else { return FibonacciRecursivo(n - 2) + FibonacciRecursivo (n - 1); }
        }
         static void FibonacciIterativo (int n) { 
    	    int i, ant1, ant2;  
      	    ant1 = ant2 = 1; 
      	    Console.Write("0 1 1 ");
     	    for (i=1; i<n-2; i++) { 
                    int actual = ant1 + ant2; 
                    Console.Write(actual+ " ");
                    ant2 = ant1; 
                    ant1 = actual; 
    	    }
        }

    }
}   
    

