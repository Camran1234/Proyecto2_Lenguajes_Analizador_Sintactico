using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_AnalizadorLexico.Archivo
{
    public class Token
    {
        private string token;
        private string lexema;

        public Token(String nombreToken, String lexema)
        {
            this.token = nombreToken;
            this.lexema = lexema;
        }

        /// <summary>
        /// Return a message with the values of this token
        /// </summary>
        /// <returns></returns>
        public string Message()
        {
            return ("Token: " + token + " Lexema: " + lexema);
        }

        public string ReturnTokenName()
        {
            return token;
        }

        public string ReturnLexema()
        {
            return lexema;
        }

        internal bool WatchIfSame(Token token)
        {
            if (this == token)
            {
                return true;
            }

            return false;
        }
    }
}
