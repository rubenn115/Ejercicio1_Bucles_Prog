//Ruben Bernal Ramos
//CSI1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Bucles_Prog.servicios
{
    /// <summary>
    /// Implementación de la interfaz calcular
    /// </summary>
    internal class calcularImplementacion : calcularInterfaz
    {
        /// <summary>
        /// Método que sumará todos os números enteros hasta el número introducido por consola
        /// rbr - 241023
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public int sumaTotal(int numero)
        {
            int suma = 0;
            for (int contador=0;contador<=numero;contador++)
            {
                suma = suma + contador;
            }
            Console.WriteLine("La suma de todos los números hasta " + numero + " es : " + suma);
            return suma;
        }
    }
}
