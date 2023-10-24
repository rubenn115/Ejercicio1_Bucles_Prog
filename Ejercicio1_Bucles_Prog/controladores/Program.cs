//Ruben Bernal Ramos
//CSI1

using Ejercicio1_Bucles_Prog.servicios;

namespace Ejercicio1_Bucles_Prog.controladores
{
    /// <summary>
    /// Clase principal de nuestra aplicación
    /// rbr - 241023
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método principal de nuestra aplicación
        /// rbr - 241023
        /// </summary>
        /// <param name="args"></param>
        static public void Main(string[] args)
        {
            //Declaro la variable
            int numero, suma;

            //Instancio las dos interfaces con sus implementaciones
            solicitarInterfaz si = new solicitarImplementacion();
            calcularInterfaz ci = new calcularImplementacion();

            //Solicito el número entero por consola
            numero = si.solicitarNumero();

            //Calculo la suma total
            suma = ci.sumaTotal(numero);
        }
    }
}