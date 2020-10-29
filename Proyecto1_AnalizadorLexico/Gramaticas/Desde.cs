using Proyecto1_AnalizadorLexico.Informacion_Gramaticas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_AnalizadorLexico.Gramaticas
{
    class Desde : InfoGramatica
    {
        public Desde()
        {
            this.nombre = "Desde";
            this.MakeStatesAndTransition();
        }

        public override void MakeStatesAndTransition()
        {
          

            this.transiciones = new Transicion[5];
            transiciones[0] = new Transicion('D', "S0", "S1");
            transiciones[1] = new Transicion('E', "S1", "S2");
            transiciones[2] = new Transicion('S', "S2", "S3");
            transiciones[3] = new Transicion('D', "S3", "S4");
            transiciones[4] = new Transicion('E', "S4", "S5");
        }
    }
}
