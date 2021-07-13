using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GnassoMariana003
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Title = "Ejercicio03";
                double TempIngresado, Suma = 0, Promedio, EquivalenteFahrenheit;

                for (int contador = 0; contador < 3; contador++)
                {
                    Console.WriteLine("Ingresar una temperatura en grados Celsius:");
                    TempIngresado = Convert.ToDouble(Console.ReadLine());
                    if (TempIngresado >= -70 && TempIngresado <= 60)
                    {
                        EquivalenteFahrenheit = ConvertiraF(TempIngresado);
                        Console.WriteLine($"El equivalente de {TempIngresado} en grados fahrenheit es: {EquivalenteFahrenheit}");
                        Suma += TempIngresado;
                    }
                    else
                    {
                        Console.WriteLine("La temperatura ingresada debe estar entre -70 y 60.");
                    }
                }

                Promedio = Suma / 3;
                Console.WriteLine($"Promedio de temperaturas ingresadas: {Promedio}");

            }
            catch (FormatException)
            {

                Console.WriteLine("Los valores deben ingresarse en forma numerica");
            }

            Console.ReadLine();

        }

        private static double ConvertiraF(double tempIngresado)
        {
            return 1.8 * tempIngresado + 32;
        }
    }
}

    //NO PUDE RESOLVER LA CONSIGNA QUE PEDIA MOSTRAR LA MAYOR TEMPERATURA REGISTRADA
    //NO SUPE RESERVAR LOS VALORES ANTERIORES DEL CICLO ANTERIOR UNA VEZ COMENZADO
    //EL SIGUIENTE Y COMO SACARLOS DEL CICLO PARA MOSTRARLO AL FINAL.
        
