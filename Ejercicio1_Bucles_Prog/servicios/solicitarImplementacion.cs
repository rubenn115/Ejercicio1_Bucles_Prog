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
    /// Implementación de la interfaz de solicitar
    /// rbr - 241023
    /// </summary>
    internal class solicitarImplementacion : solicitarInterfaz
    {
        /// <summary>
        /// Método que pédira por consola un número entero y lo guardará
        /// rbr - 241023
        /// </summary>
        /// <returns></returns>
        public int solicitarNumero()
        {
            int numero;
            //Utilizo un do...while para controlar que el número que se introduzca por consola cumpla la condición de ser mayor que cero
            do
            {
                Console.WriteLine("Escribe un número entero mayor que cero:");
                numero = Convert.ToInt32(Console.ReadLine());
            }while(numero <= 0);
            

            return numero;
        }
    }
}
