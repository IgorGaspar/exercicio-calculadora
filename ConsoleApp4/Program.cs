using System;
using System.Globalization;

namespace ExercícioCalculadora {
    class Program {
        
        static void Main(string[] args) {

            /* Programa que realiza o cálculo da circunferência
            e do volume de um diâmetro a partir do valor do 
            raio do mesmo. */
            
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
