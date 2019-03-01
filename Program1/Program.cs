using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {

            int num;
            Console.Write("¿Cuantos datos decea capturar?\nR:");
            num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                int[] arreglo= new int[num];
                for (int i = 0; i < num; i++)
                {
                    Console.Clear();
                    Console.WriteLine("Ingresa el dato del {0} elemento(s)", i + 1);
                    arreglo[i] = int.Parse(Console.ReadLine());
                }

                float suma = 0;
                float promedio;
                double Sumatoria = 0;

                foreach (var item in arreglo)
                    suma += item;

                promedio = suma / num;

                foreach (var item in arreglo)
                {
                    float Diferencia = 0;
                    Diferencia = item - promedio;
                    Sumatoria+= Math.Pow(Diferencia, 2);
                }

                Console.Clear();
                Console.WriteLine("La suma es de: {0}", suma);
                Console.WriteLine("El promedio es de: {0}", promedio);
                Console.WriteLine("El cuadado es de: {0}", Math.Pow(suma, 2));
                Console.WriteLine("El cubo es de: {0}", Math.Pow(suma, 3));
                Console.WriteLine("La desviacion estandar es de: {0}", Math.Sqrt(Sumatoria / (num - 1)));
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Necesitas que la lista sea mayor a 0");
            }

        }
    }
}
