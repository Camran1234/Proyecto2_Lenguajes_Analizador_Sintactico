using Proyecto1_AnalizadorLexico.Archivo;
using System;

namespace Proyecto1_AnalizadorLexico.Semantico
{
    public class VariableValor
    {
        private Token token;
        private string valor;

        public VariableValor(Token token)
        {
            this.token = token;
        }

        public Boolean WatchIfSame(Token token)
        {
            if (this.token == token)
            {
                return true;
            }

            return false;
        }

        public Token ReturnToken()
        {
            return token;
        }

        public string GetValueVariable()
        {
            //Comprobamos que el token sea igual
            //Retornamos el valor
            return this.Value();
        }

        public string GetName()
        {
            return token.ReturnLexema();
        }

        public void AssignValue(string valor)
        {
            this.valor = valor;
        }

        private string Value()
        {
            if(valor != null)
            {
                return valor;
            }
            else
            {
                return "null";
            }
        }
    }
}