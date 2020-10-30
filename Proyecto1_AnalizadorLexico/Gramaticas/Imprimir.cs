using Proyecto1_AnalizadorLexico.Informacion_Gramaticas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_AnalizadorLexico.Gramaticas
{
    class Imprimir: InfoGramatica
    {
        public Imprimir()
        {
            this.nombre = "Imprimir";
            this.MakeStatesAndTransition();
        }

        public override void MakeStatesAndTransition()
        {


            this.transiciones = new Transicion[8];
            transiciones[0] = new Transicion('I', "S0", "S1");
            transiciones[1] = new Transicion('m', "S1", "S2");
            transiciones[2] = new Transicion('p', "S2", "S3");
            transiciones[3] = new Transicion('r', "S3", "S4");
            transiciones[4] = new Transicion('i', "S4", "S5");
            transiciones[5] = new Transicion('m', "S5", "S6");
            transiciones[6] = new Transicion('i', "S6", "S7");
            transiciones[7] = new Transicion('r', "S7", "S8");

        }
    }
}
