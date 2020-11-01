using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_AnalizadorLexico.Analizador_Sintactico
{
    
    class AsignadorId
    {
        private static int numeroNodos = 0;

        public void NodeFound()
        {
            numeroNodos++;
            //MessageBox.Show("Numero: " + numeroNodos);
        }

        public int GetId()
        {
            numeroNodos--;
            return (numeroNodos + 1);

        }
    }
}
