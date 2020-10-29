using Proyecto1_AnalizadorLexico.Informacion_Gramaticas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_AnalizadorLexico.Gramaticas
{
    class Incremento : InfoGramatica
    {
        public Incremento()
        {
            this.nombre = "Incremento";
            this.MakeStatesAndTransition();
        }

        public override void MakeStatesAndTransition()
        {
           

            this.transiciones = new Transicion[10];
            transiciones[0] = new Transicion('I', "S0", "S1");
            transiciones[1] = new Transicion('N', "S1", "S2");
            transiciones[2] = new Transicion('C', "S2", "S3");
            transiciones[3] = new Transicion('R', "S3", "S4");
            transiciones[4] = new Transicion('E', "S4", "S5");
            transiciones[5] = new Transicion('M', "S5", "S6");
            transiciones[6] = new Transicion('E', "S6", "S7");
            transiciones[7] = new Transicion('N', "S7", "S8");
            transiciones[8] = new Transicion('T', "S8", "S9");
            transiciones[9] = new Transicion('O', "S9", "S10");

        }
    }
}
