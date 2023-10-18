using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_logica.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        ///<summary>
        ///Método que nos muestra la calculadora
        /// 171023 - lig
        /// </summary>

        public int mostrarCalculadoraYResultado() 
        {

            int Seleccion;
            Console.WriteLine("======================");
            Console.WriteLine(" 1. Igualdad");
            Console.WriteLine(" 2. Desigualdad");
            Console.WriteLine(" 3. Cerrar");
            Console.WriteLine(" Seleccione una opción");
            Console.WriteLine("======================");
            Seleccion = Console.ReadKey(true).KeyChar - ('0');

            return Seleccion;

        }

    }

}
