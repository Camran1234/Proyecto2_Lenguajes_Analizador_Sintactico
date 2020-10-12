﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_AnalizadorLexico.Informacion_Gramaticas
{
    /// <summary>
    /// Clase para almacenar el estado y tipo de un automata
    /// tipo de clase para mantener información
    /// </summary>
    class State
    {
        String nombreEstado;
        bool tipoEstado;

        public State(String nombreEstado, bool tipoEstado)
        {
            this.nombreEstado = nombreEstado;
            this.tipoEstado = tipoEstado;
        }

        /// <summary>
        /// Obtiene el nombre del estado
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return nombreEstado;
        }

        /// <summary>
        /// Obtiene el tipo de estado que es
        /// </summary>
        /// <returns></returns>
        public bool GetStateType()
        {
            return tipoEstado;
        }
    }
}
