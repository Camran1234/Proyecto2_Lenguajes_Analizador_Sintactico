using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_AnalizadorLexico.Archivo
{
    class Token
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

    }
}
