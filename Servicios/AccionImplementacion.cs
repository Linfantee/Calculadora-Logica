using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_logica.Servicios
{
    internal class AccionImplementacion : AccionInterfaz
    {

        private string DameAccion()
        { 
        
            string accion = Console.ReadLine();
            return accion;
        
        
        }

         
        public void igualdad() 
        {
            Console.WriteLine("Introduzca primera acción");
            string accion1 = DameAccion();
            Console.WriteLine("Introduzca segunda acción");
            string accion2 = DameAccion();
            Console.WriteLine("Solución");
            Console.WriteLine(accion1==accion2);
        
        
        
        }
          
        public void desigualdad()
        {
            Console.WriteLine("Introduzca primera acción");
            string accion1 = DameAccion();
            Console.WriteLine("Introduzca segunda acción");
            string accion2 = DameAccion();
            Console.WriteLine("Solución");
            Console.WriteLine(accion1 != accion2);






        }
    }
}
