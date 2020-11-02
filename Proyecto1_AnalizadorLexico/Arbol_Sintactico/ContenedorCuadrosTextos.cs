using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_AnalizadorLexico.Arbol_Sintactico
{
    class ContenedorCuadrosTextos
    {
        
        public void AddError(RichTextBox cuadroError,string texto)
        {
            cuadroError.AppendText(texto + "\n");
        }

        public void AddTexto(RichTextBox cuadroTokens,string text)
        {
            cuadroTokens.AppendText(text + "\n");
        }
    }
}
