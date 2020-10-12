using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_AnalizadorLexico.Analizador_Sintactico
{
    class Automata_Pila
    {
        private int posicion = 0;
        private List<string> elemento = new List<string>();

        /// <summary>
        /// Quita un elemento de la pila
        /// </summary>
        /// <param name="token"></param>
        public void AgregarElemento(string token)
        {
            elemento.Add(token);
            posicion++;
        }

        /// <summary>
        /// Quita un elemento de la pila
        /// </summary>
        /// <param name="token"></param>
        public void QuitarElemento(string token)
        {
            elemento.Remove(token);
            posicion--;
        }

        /// <summary>
        /// Comprueba si el automata esta en posicion para ser comprobado o no
        /// </summary>
        /// <returns></returns>
        public Boolean ComprobarAutomataCorrecto()
        {
            if (posicion == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
