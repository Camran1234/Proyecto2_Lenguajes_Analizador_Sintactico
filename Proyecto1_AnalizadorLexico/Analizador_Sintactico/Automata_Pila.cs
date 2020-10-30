using Proyecto1_AnalizadorLexico.Analizador_Lexico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            elemento.RemoveAt(elemento.Count - 1);
            foreach (string palabra in token)
            {
                if (!palabra.Equals("e"))
                {
                    elemento.Add(palabra);
                    posicion++;
                }
            }
            string hola = "";
            for (int indexElemento =0; indexElemento< elemento.Count; indexElemento++)
            {
                hola += elemento[indexElemento];
            }
            MessageBox.Show("Analisis: " + hola);
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
            if (this.GetLastElement().Equals("$"))
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
