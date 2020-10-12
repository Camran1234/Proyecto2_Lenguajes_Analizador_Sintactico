﻿using Proyecto1_AnalizadorLexico.Gramaticas;
using Proyecto1_AnalizadorLexico.Informacion_Gramaticas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_AnalizadorLexico.Analizador_Lexico
{
    class Automata
    {
        private InfoGramatica[] gramaticas = new InfoGramatica[34];

        /// <summary>
        /// Establece un automata donde contenedremos todas las gramaticas clases que se establecieron
        /// </summary>
        public Automata()
        {
            //Establecemos una lista de las gramaticas que contiene el automata
            gramaticas[0] = new And();
            gramaticas[1] = new Boolean_();
            gramaticas[2] = new Cadena();
            gramaticas[3] = new Chart();
            gramaticas[4] = new Colon();
            gramaticas[5] = new ComentarioUnaLinea();
            gramaticas[6] = new ComentarioVariasLineas();
            gramaticas[7] = new Comparacion();
            gramaticas[8] = new Decimal_();
            gramaticas[9] = new Desde();
            gramaticas[10] = new Diferente();
            gramaticas[11] = new Disminuir();
            gramaticas[12] = new Division();
            gramaticas[13] = new Entero();
            gramaticas[14] = new Hacer();
            gramaticas[15] = new Hasta();
            gramaticas[16] = new Igual();
            gramaticas[17] = new Incrementar();
            gramaticas[18] = new Incremento();
            gramaticas[19] = new Mayor();
            gramaticas[20] = new MayorIgual();
            gramaticas[21] = new Menor();
            gramaticas[22] = new MenorIgual();
            gramaticas[23] = new Mientras();
            gramaticas[24] = new Multiplicacion();
            gramaticas[25] = new Negacion();
            gramaticas[26] = new Or();
            gramaticas[27] = new ParentesisAbrir();
            gramaticas[28] = new ParentesisCerrar();
            gramaticas[29] = new Resta();
            gramaticas[30] = new Si();
            gramaticas[31] = new Sino();
            gramaticas[32] = new Sino_Si();
            gramaticas[33] = new Suma();

        }
    }
}
