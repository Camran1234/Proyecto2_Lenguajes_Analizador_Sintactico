﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_AnalizadorLexico.Archivo
{
    class ManipuladorProyecto
    {
        /// <summary>
        /// Sirve para crear un proyecto y retorna la path de este
        /// </summary>
        /// <param name="nombreProyecto"></param>
        internal string CreateProyecto(string nombreProyecto)
        {
            try
            {
                //Le agregamos el nombreArchivo al path del proyecto

                FolderBrowserDialog directorio = new FolderBrowserDialog();
                DialogResult resultado = directorio.ShowDialog();
                //Establecemos la nueva path
                string path = Path.Combine(directorio.SelectedPath,nombreProyecto);

                if (resultado == DialogResult.OK && !string.IsNullOrWhiteSpace(path))
                {
                    //Creamos la carpeta proyecto
                    Directory.CreateDirectory(path);
                    MessageBox.Show("Proyecto creado en "+path);
                    return path;
                }
                else
                {
                    MessageBox.Show("No se pudo crear el proyecto");
                    return null;
                }
                
            }
            catch(IOException error)
            {
                MessageBox.Show(error.Message);
                return null;
            }
            
        }

        internal void EliminarProyecto(string pathProyecto)
        {
            try
            {
                string nombreProyecto = new DirectoryInfo(pathProyecto).Name;
                
                //Eliminamos todos los archivos de primero
                string[] direcciones = Directory.GetFiles(pathProyecto);
                ManipuladorArchivo manipuladorArchivo = new ManipuladorArchivo();
                foreach(string direccion in direcciones)
                {
                    manipuladorArchivo.EliminarArchivo(direccion);
                }
                //Eliminamos la carpeta
                Directory.Delete(pathProyecto);
                MessageBox.Show("PROYECTO " + nombreProyecto + " ELIMINADO");
            }
            catch (IOException exc)
            {
                MessageBox.Show("ERROR: " + exc.Message);
            }
        }
    }
}
