using Proyecto1_AnalizadorLexico.Informacion_Gramaticas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_AnalizadorLexico.Gramaticas
{
    class Palabra : InfoGramatica
    {

        public Palabra()
        {
            this.nombre = "Palabra";
            this.MakeStatesAndTransition();
        }

        public override void MakeStatesAndTransition()
        {


            this.transiciones = new Transicion[2];
            transiciones[0] = new Transicion('$', "S0", "S0");
            transiciones[0].AssignNextCharacterToNotIgnore(' ');
            transiciones[1] = new Transicion(' ', "S0", "S1");
            

        }
    }
}
