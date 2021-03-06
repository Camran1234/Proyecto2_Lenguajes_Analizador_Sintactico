﻿using Proyecto1_AnalizadorLexico.Informacion_Gramaticas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_AnalizadorLexico.Gramaticas
{
    class _String: InfoGramatica
    {
        public _String()
        {
            this.nombre = "string";
            this.MakeStatesAndTransition();
        }

        public override void MakeStatesAndTransition()
        {
            this.transiciones = new Transicion[3];
            transiciones[0] = new Transicion('\"', "S0", "S1");
            transiciones[1] = new Transicion('$', "S1", "S1");
            transiciones[1].AssignNextCharacterToNotIgnore('\"');
            transiciones[2] = new Transicion('\"', "S1", "S2");
        }
    }
}
