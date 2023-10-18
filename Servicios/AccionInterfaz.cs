using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_logica.Servicios
{
    /// <summary>
    /// Aquí tenemos el encabezado de los métodos
    /// 181023 - lig
    /// </summary>
    internal interface AccionInterfaz
    {
        /// <summary>
        /// Método que nos muestra la calculadora y la selección
        /// 181023 - lig
        /// </summary>
        public void igualdad();

        /// <summary>
        /// Método que realiza la igualdad de la acción
        /// 181023 - lig
        /// </summary>

        public void desigualdad();

        /// <summary>
        /// Método que realiza la desigualdad de la acción
        /// 181023 - lig
        /// </summary>
    }
}
