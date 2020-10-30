using Proyecto1_AnalizadorLexico.Archivo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_AnalizadorLexico.Analizador_Lexico
{
    class AnalizadorLexico
    {
        Lenguaje lenguaje ;
        int posicionAlmacenada;
        Boolean primeraVezMetodo = true;
        /// <summary>
        /// Un analizadorLexico
        /// El parametro debe ser el cuadro donde esta la informacion
        /// </summary>
        /// <param name="richTextBox"></param>
        public AnalizadorLexico (RichTextBox richTextBox)
        {
            this.lenguaje = new Lenguaje(richTextBox);
        }

        public Boolean AnalizarLexema(char lexema, int posicion)
        {
            if (primeraVezMetodo)
            {
                posicionAlmacenada = posicion;
                primeraVezMetodo = false;
            }

            if (lenguaje.ContainChar(lexema, posicionAlmacenada))
            {
                posicionAlmacenada = posicion + 1;
            }
            
            return false;
        }

        public List<Token> ReturnTokens()
        {
            return lenguaje.ReturnTokens();
        }

        public void AddTokens(RichTextBox richText)
        {
            string tokens = "Tokens: (" + lenguaje.GetNoTokens() + ") \n";
            richText.AppendText(tokens);
            richText.AppendText(lenguaje.GetTokensAsString());
        }

        /// <summary>
        /// Enviar de primero el cuadro de errores, y uego el cuadro del texto
        /// </summary>
        /// <param name="richText"></param>
        /// <param name="richTextBoxCompilador"></param>
        public void AddMistakesTokens(RichTextBox richText, RichTextBox richTextBoxCompilador)
        {
            string errorFraseInicial = "Errores: (" + lenguaje.GetNoMistakes() + ") \n";
            //Anexamos la cantidad de errores encontrados
            richText.AppendText(errorFraseInicial);
            //Colocamos los errores y sus respectivas posiciones
            richText.AppendText(lenguaje.GetErroresAsString(richTextBoxCompilador));
        }
    }
}
