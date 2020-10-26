using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_AnalizadorLexico.Informacion_Gramaticas
{
    class InfoGramatica
    {
        protected string nombre;
        protected State[] nombresEstados;
        protected Transicion[] transiciones;
        //Indicaremos en que estado nos encontramos
        protected int actualTransition = 0;
        public InfoGramatica()
        {
            this.MakeStatesAndTransition();
        }

        /// <summary>
        /// Obtiene los estados del automata
        /// </summary>
        /// <returns></returns>
        public State[] GetStates()
        {
            return nombresEstados;
        }

        /// <summary>
        /// Obtiene las transiciones del automata
        /// </summary>
        /// <returns></returns>
        public Transicion[] GetTransicions()
        {
            return transiciones;
        }

        /// <summary>
        /// Probamos la transici[on
        /// Retornamos 1 indicamos que llego al estado final
        /// Retornamos 2 indicamos que entro al analisis del automata
        /// Retornamos 3 si no entro Al analisis del automata
        /// Retornamos 0 si no entro al analisis y ya andaba en analisis
        /// </summary>
        /// <param name="caracter"></param>
        /// <returns></returns>
        public int ProveTransition(Char caracter)
        {
            try
            {
                if (transiciones[actualTransition].ProveChar(caracter))
                {
                    if (transiciones[actualTransition].IfHaveNextCharacter())
                    {
                        this.MoveOfTransition();
                    }

                    if(actualTransition == transiciones.Length - 1)
                    {
                        //Llego al estado inicial
                        this.ResetTransition();
                        return 1;
                    }
                    else
                    {
                        //Avanzamos de transicion
                        this.MoveOfTransition();
                        return 2;
                    }
                }
                else
                {
                    if (transiciones[actualTransition].IfHaveNextCharacter())
                    {
                        //Al indicar que tiene un posible siguiente caracter indicaremos de que sigue en el ciclo
                        return 2;
                    }
                    if (actualTransition == 0)
                    {
                        //Error de que ni entro al automata
                        return 3;
                    }
                    else
                    {
                        //Error de que andaba en el automata pero fue un error lexico
                        this.ResetTransition();
                        return 0;
                    }
                    //Al no haber un error reiniciamos
                }
            }
            catch(Exception ex)
            {
                //Por si exisitian errores
                ResetTransition();
                return 0;
            }
        }
        private void MoveOfTransition()
        {
            actualTransition++;
        }

        private void ResetTransition()
        {
            actualTransition = 0;
        }

        /// <summary>
        /// Retorna el nombre del token
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return this.nombre;
        }

        public virtual void MakeStatesAndTransition()
        {

        }

        
    }
}
