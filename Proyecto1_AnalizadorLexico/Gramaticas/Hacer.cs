using Proyecto1_AnalizadorLexico.Informacion_Gramaticas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_AnalizadorLexico.Gramaticas
{
    class Hacer : InfoGramatica
    {
        public Hacer()
        {
            this.nombre = "Hacer";
            this.MakeStatesAndTransition();
        }

        public override void MakeStatesAndTransition()
        {
           

            this.transiciones = new Transicion[5];
            transiciones[0] = new Transicion('H', "S0", "S1");
            transiciones[1] = new Transicion('A', "S1", "S2");
            transiciones[2] = new Transicion('C', "S2", "S3");
            transiciones[3] = new Transicion('E', "S3", "S4");
            transiciones[4] = new Transicion('R', "S4", "S5");
            
        }
    }
}
