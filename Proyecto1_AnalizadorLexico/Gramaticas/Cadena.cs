using Proyecto1_AnalizadorLexico.Informacion_Gramaticas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_AnalizadorLexico.Gramaticas
{
    class Cadena : InfoGramatica
    {
        public Cadena( )
        {
            this.nombre = "Cadena";
            this.MakeStatesAndTransition();
        }

        public override void MakeStatesAndTransition()
        {
           
            

            this.transiciones = new Transicion[6];
            transiciones[0] = new Transicion('C', "S0", "S1");
            transiciones[1] = new Transicion('a', "S1", "S2");
            transiciones[2] = new Transicion('d', "S2", "S3");
            transiciones[3] = new Transicion('e', "S3", "S4");
            transiciones[4] = new Transicion('n', "S4", "S5");
            transiciones[5] = new Transicion('a', "S5", "S6");
            

        }
    }
}
