using Calculadora_logica.Servicios;

namespace Calculadora_logica
{
    /// <summary>
    /// Clase principal
    /// 171023 - lig
    /// </summary>

    class Program
    {
       /// <summary>
       /// Método menú, donde concentra el orden en el que se debe ejecutar los métodos
       ///171023 - lig
       /// </summary>

        static void Main(string[] args) {

            int OpcionSeleccionada;
            bool cerrarCalculadora = false;
            MenuInterfaz aka = new MenuImplementacion();
            AccionInterfaz ao = new AccionImplementacion();

         //Procedimieto

            while (!cerrarCalculadora) 
            {

                OpcionSeleccionada = aka.mostrarCalculadoraYResultado();

                switch (OpcionSeleccionada) 
                {

                    case 1:
                        Console.WriteLine("Igualdad:");
                        ao.igualdad(); 
                        break;
                    case 2:
                        Console.WriteLine("Desigualdad:");
                        ao.desigualdad();
                        break;
                    case 3:
                        Console.WriteLine("Cerrando calculadora lógica");
                        cerrarCalculadora = true;
                        break;
                       

                }         
            
            }
           
        }

    }

}