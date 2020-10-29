using Proyecto1_AnalizadorLexico.Informacion_Gramaticas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_AnalizadorLexico.Gramaticas
{
    class Sino_Si : InfoGramatica
    {
        public Sino_Si()
        {
            this.nombre = "Sino_Si";
            this.MakeStatesAndTransition();
        }

        public override void MakeStatesAndTransition()
        {
         

            this.transiciones = new Transicion[7];
            transiciones[0] = new Transicion('S', "S0", "S1");
            transiciones[1] = new Transicion('I', "S1", "S2");
            transiciones[2] = new Transicion('N', "S2", "S3");
            transiciones[3] = new Transicion('O', "S3", "S4");
            transiciones[4] = new Transicion('_', "S4", "S5");
            transiciones[5] = new Transicion('S', "S5", "S6");
            transiciones[6] = new Transicion('I', "S6", "S7");
        }
    }
}
