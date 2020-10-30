using Proyecto1_AnalizadorLexico.Analizador_Lexico;
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
        /// La pila siempre empieza con $E
        /// </summary>
        public Automata_Pila()
        {
            elemento.Add("$");
            elemento.Add("E");
        }
        /// <summary>
        /// Agrega elementos a la pila
        /// </summary>
        /// <param name="token"></param>
        public Boolean AgregarElemento(string[] token, string lastWord)
        {
            if(elemento[elemento.Count - 1].Equals(lastWord))
            {
                elemento.RemoveAt(elemento.Count - 1);
                foreach (string palabra in token)
                {
                    elemento.Add(palabra);
                    Console.WriteLine("Se agrego a la pila: "+palabra);
                    posicion++;
                }
            }
            return false;   
        }

        /// <summary>
        /// Quita un elemento de la pila
        /// Retorna verdadero si se pudo quitar el elemento 
        /// Retorna falso si no se pudo quitar el elemento
        /// </summary>
        /// <param name="token"></param>
        public Boolean QuitarElemento(string token)
        {
            if (elemento[elemento.Count - 1].Equals(token))
            {
                elemento.RemoveAt(elemento.Count-1);
                Console.WriteLine("Se removio de la pila: " + token);
                posicion--;
                return true;
            }
            else
            {
                return false;
            }
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

        internal string GetLastElement()
        {
            return elemento[elemento.Count - 1];
        }
    }
}
