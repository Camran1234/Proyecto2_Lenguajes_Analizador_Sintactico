using Proyecto1_AnalizadorLexico.Archivo;
using Proyecto1_AnalizadorLexico.Gramaticas;
using Proyecto1_AnalizadorLexico.Informacion_Gramaticas;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_AnalizadorLexico.Analizador_Lexico
{
    class Lenguaje
    {

        //Usaremos el token formado con el conjunto de caracteres analizados
        //Tambien analizaremos la posicion y poder pintar esa parte del texto en el richtTextBox del IDE
        //la variable lengthOfToken se utilizara para usar el metodo de richTextBox Select que seleccionaremos esa parte
        //luego con SelectColor cambiamos el color
        private InfoGramatica[] gramaticas = new InfoGramatica[35];
        private List<int> automatasParaAvanzar = new List<int>();
        private List<int> automatasFinales = new List<int>();
        private int resultado;
        private PintarElemento pintador;
        private Boolean permisoAgregarCaracter = true;
        private List<Token> tokens = new List<Token>();
        private string lexema = "";
        private List<Error> tokenErroneos = new List<Error>();
        /// <summary>
        /// Establece un automata donde contenedremos todas las gramaticas clases que se establecieron
        /// </summary>
        public Lenguaje(RichTextBox richTextBox)
        {
            pintador = new PintarElemento(richTextBox);
            //Establecemos una lista de las gramaticas que contiene el automata
            gramaticas[0] = new And();
            gramaticas[1] = new Boolean_();
            gramaticas[2] = new Cadena();
            gramaticas[3] = new Chart();
            gramaticas[4] = new Colon();
            gramaticas[5] = new ComentarioUnaLinea();
            gramaticas[6] = new ComentarioVariasLineas();
            gramaticas[7] = new Comparacion();
            gramaticas[8] = new Decimal_();
            gramaticas[9] = new Desde();
            gramaticas[10] = new Diferente();
            gramaticas[11] = new Disminuir();
            gramaticas[12] = new Division();
            gramaticas[13] = new Entero();
            gramaticas[14] = new Hacer();
            gramaticas[15] = new Hasta();
            gramaticas[16] = new Igual();
            gramaticas[17] = new Incrementar();
            gramaticas[18] = new Incremento();
            gramaticas[19] = new Mayor();
            gramaticas[20] = new MayorIgual();
            gramaticas[21] = new Menor();
            gramaticas[22] = new MenorIgual();
            gramaticas[23] = new Mientras();
            gramaticas[24] = new Multiplicacion();
            gramaticas[25] = new Negacion();
            gramaticas[26] = new Or();
            gramaticas[27] = new ParentesisAbrir();
            gramaticas[28] = new ParentesisCerrar();
            gramaticas[29] = new Resta();
            gramaticas[30] = new Si();
            gramaticas[31] = new Sino();
            gramaticas[32] = new Sino_Si();
            gramaticas[33] = new Suma();
            gramaticas[34] = new Variable();
        }

        public Boolean ContainChar(char caracter, int index)
        {
            permisoAgregarCaracter = true;
            if (this.automatasParaAvanzar.Count == 0)
            {
                for(int indexGramatica = 0; indexGramatica < this.gramaticas.Length; indexGramatica++)
                {
                    resultado = gramaticas[indexGramatica].ProveTransition(caracter);
                    this.Posibilities(caracter, indexGramatica, index);
                }
            } else           
            {
                for (int indexGramatica = 0; indexGramatica < this.automatasParaAvanzar.Count; indexGramatica++)
                {
                    resultado = gramaticas[(int) automatasParaAvanzar[indexGramatica]].ProveTransition(caracter);
                    this.Posibilities(caracter, indexGramatica, index);
                }
            }
            
            //Si ya solo queda un estado por analizar
            if (this.automatasParaAvanzar.Count == 1)
            {
                //Agregamos el token y pintamos el elemento
                tokens.Add(new Token(gramaticas[automatasParaAvanzar[0]].GetName(),lexema));
                pintador.pintarTexto(gramaticas[automatasParaAvanzar[0]].GetName(),lexema,index);
                automatasFinales.Clear();
                automatasParaAvanzar.Clear();
            }
            else
            {
                automatasFinales.Clear();
            }
            return false;
        }

        private void Posibilities(char caracter, int indexGramatica, int index)
        {
            switch (resultado)
            {
                case 0:
                    if (automatasParaAvanzar.Count == 1)
                    {
                        //Marcar como error completo
                        this.tokenErroneos.Add(new Error(lexema, gramaticas[indexGramatica].GetName(),index));
                        pintador.pintarTexto("?Error", lexema, index);
                        lexema = "";
                    }
                    automatasParaAvanzar.Remove(indexGramatica);
                    break;
                case 1:
                    if (automatasFinales.Contains(indexGramatica) == false)
                    {
                        automatasFinales.Add(indexGramatica);
                    }
                    if (automatasParaAvanzar.Contains(indexGramatica) == false)
                    {
                        automatasParaAvanzar.Add(indexGramatica);
                    }
                    if (permisoAgregarCaracter == true)
                    {
                        lexema += caracter;
                        permisoAgregarCaracter = false;
                    }
                    break;
                case 2:
                    //Por si no contiene el automata
                    if (automatasParaAvanzar.Contains(indexGramatica)==false)
                    {
                        automatasParaAvanzar.Add(indexGramatica);
                    }
                    if (permisoAgregarCaracter == true)
                    {
                        lexema += caracter;
                        permisoAgregarCaracter = false;
                    }
                    break;
            }
        }
        public InfoGramatica[] GetGramaticas()
        {
            return this.gramaticas;
        }
    }
}
