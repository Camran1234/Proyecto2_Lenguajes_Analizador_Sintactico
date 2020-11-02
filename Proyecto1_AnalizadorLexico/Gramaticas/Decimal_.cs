using Proyecto1_AnalizadorLexico.Informacion_Gramaticas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_AnalizadorLexico.Gramaticas
{
    class Decimal_ : InfoGramatica
    {
        public Decimal_()
        {
            this.nombre = "Decimal";
            this.MakeStatesAndTransition();
        }

        public override void MakeStatesAndTransition()
        {
           

            this.transiciones = new Transicion[7];
            transiciones[0] = new Transicion('D', "S0", "S1");
            transiciones[1] = new Transicion('e', "S1", "S2");
            transiciones[2] = new Transicion('c', "S2", "S3");
            transiciones[3] = new Transicion('i', "S3", "S4");
            transiciones[4] = new Transicion('m', "S4", "S5");
            transiciones[5] = new Transicion('a', "S5", "S6");
            transiciones[6] = new Transicion('l', "S6", "S7");

        }
    }
}
