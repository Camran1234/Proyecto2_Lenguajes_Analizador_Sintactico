﻿using Proyecto1_AnalizadorLexico.Informacion_Gramaticas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_AnalizadorLexico.Gramaticas
{
    class Division : InfoGramatica
    {
        public Division()
        {
            this.nombre = "/";
            this.MakeStatesAndTransition();
        }

        public override void MakeStatesAndTransition()
        {
          

            this.transiciones = new Transicion[1];
            transiciones[0] = new Transicion('/', "S0", "S1");
        }
    }
}
