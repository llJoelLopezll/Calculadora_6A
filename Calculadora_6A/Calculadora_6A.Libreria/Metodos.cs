using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_6A.Libreria
{
    public class Metodos
    {
        /// <summary>
        /// Funcion que envia saludo
        /// </summary>
        /// <returns>Cadena de Caracteres</returns>
        public string Saludo()
        {
            return "PASA PACK MAMU!!";
        }
        public float Sumar(float numero1, float numero2)
        {
            var resultado = numero1 + numero2;
            return resultado;
        }
        public float Restar(float numero1, float numero2)
        {
            var resultado = numero1 - numero2;
            return resultado;
        }
        public float Multiplicar(float numero1, float numero2)
        {
            var resultado = numero1 * numero2;
            return resultado;
        }
        public float Dividir(float numero1, float numero2)
        {
            var resultado = numero1 / numero2;
            return resultado;
        }
    }
}
