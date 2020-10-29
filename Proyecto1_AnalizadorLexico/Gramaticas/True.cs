﻿using Proyecto1_AnalizadorLexico.Informacion_Gramaticas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_AnalizadorLexico.Gramaticas
{
    class True: InfoGramatica
    {
        public True()
        {
            this.nombre = "True";
            this.MakeStatesAndTransition();
        }

        public override void MakeStatesAndTransition()
        {
            this.transiciones = new Transicion[4];
            transiciones[0] = new Transicion('T', "S0", "S1");
            transiciones[1] = new Transicion('r', "S1", "S2");
            transiciones[2] = new Transicion('u', "S2", "S3");
            transiciones[3] = new Transicion('e', "S3", "S4");
        }
    }
}
