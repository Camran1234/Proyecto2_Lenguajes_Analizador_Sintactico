using Proyecto1_AnalizadorLexico.Informacion_Gramaticas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_AnalizadorLexico.Gramaticas
{
    class Si : InfoGramatica
    {
        public Si()
        {
            this.nombre = "Si";
            this.MakeStatesAndTransition();
        }

        public override void MakeStatesAndTransition()
        {
          

            this.transiciones = new Transicion[2];
            transiciones[0] = new Transicion('S', "S0", "S1");
            transiciones[1] = new Transicion('I', "S1", "S2");

        }
    }
}
