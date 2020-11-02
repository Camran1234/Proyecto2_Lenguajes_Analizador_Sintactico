using Proyecto1_AnalizadorLexico.Informacion_Gramaticas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_AnalizadorLexico.Gramaticas
{
    class _Char : InfoGramatica
    {

        public _Char()
        {
            this.nombre = "char'";
            this.MakeStatesAndTransition();
        }

        public override void MakeStatesAndTransition()
        {
            char comilla = '\'';
            this.transiciones = new Transicion[3];
            transiciones[0] = new Transicion(comilla, "S0", "S1");
            transiciones[1] = new Transicion('#', "S1", "S2");
            transiciones[2] = new Transicion(comilla, "S2", "S3");
        }
    }
}
