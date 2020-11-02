using Proyecto1_AnalizadorLexico.Informacion_Gramaticas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_AnalizadorLexico.Gramaticas
{
    class ComentarioVariasLineas : InfoGramatica
    {
        public ComentarioVariasLineas()
        {
            this.nombre = "ComentarioVariasLineas";
            this.MakeStatesAndTransition();
        }

        public override void MakeStatesAndTransition()
        {
            

            this.transiciones = new Transicion[5];
            transiciones[0] = new Transicion('/', "S0", "S1");
            transiciones[1] = new Transicion('*', "S1", "S2");
            transiciones[2] = new Transicion('$', "S2", "S3");
            transiciones[2].AssignNextCharacterToNotIgnore('*');
            transiciones[3] = new Transicion('*', "S2", "S3");
            transiciones[4] = new Transicion('/', "S3", "S4");
        }
    }
}
