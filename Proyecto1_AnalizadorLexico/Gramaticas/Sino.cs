using Proyecto1_AnalizadorLexico.Informacion_Gramaticas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_AnalizadorLexico.Gramaticas
{
    class Sino : InfoGramatica
    {
        public Sino()
        {
            this.nombre = "SINO";
            this.MakeStatesAndTransition();
        }

        public override void MakeStatesAndTransition()
        {
          

            this.transiciones = new Transicion[4];
            transiciones[0] = new Transicion('S', "S0", "S1");
            transiciones[1] = new Transicion('I', "S1", "S2");
            transiciones[2] = new Transicion('N', "S2", "S3");
            transiciones[3] = new Transicion('O', "S3", "S4");
        }

    }
}
