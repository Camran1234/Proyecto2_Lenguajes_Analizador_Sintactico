using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_AnalizadorLexico.Arbol_Sintactico
{
    class ArbolSintactico
    {
        private string path ;
        private string pathFile;
        private FileStream flujoArchivo;
        private byte[] contenido;
        private string nameFile = "Texto!@#$%^&.text";

        public ArbolSintactico()
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            this.StartConnection();
        }

        //Empezamos la conexion con el archivo
        private void StartConnection()
        {
            try
            {
                pathFile = path + "\\"+nameFile;
                File.Delete(pathFile);
                flujoArchivo = File.Create(pathFile);
                contenido = new UTF8Encoding().GetBytes("digraph Archivo {\n");
                flujoArchivo.Write(contenido, 0, contenido.Length);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace);
            }
        }

        public Boolean AddNode(string nodo)
        {
            contenido = new UTF8Encoding().GetBytes(nodo);
            flujoArchivo.Write(contenido, 0, contenido.Length);
            return false;
        }

        //Cerramos el archivo
        public void CloseFile()
        {
            contenido = new UTF8Encoding().GetBytes("}");
            flujoArchivo.Write(contenido, 0, contenido.Length);
            flujoArchivo.Close();
        }

        /// <summary>
        /// Metodo para crear nuestra imagen del arbol
        /// </summary>
        /// <param name="imgFileName"></param>
        public void CallGenerateFile( string imgFileName)
        {
            string img = imgFileName;
            this.GenerateImg( img);
            File.Delete(pathFile);
        }

        /// <summary>
        /// Genera nuestra imagen 
        /// </summary>
        /// <param name="imgFileName"></param>
        private void GenerateImg(string imgFileName)
        {
            try
            {
                string comandoGenerador = "dot.exe -Tpng \"" + pathFile + "\" -o " + imgFileName;
                var comando = string.Format(comandoGenerador);
                var comandoIniciador = new System.Diagnostics.ProcessStartInfo("cmd", "/C" + comando);
                var comandoProceso = new System.Diagnostics.Process();
                comandoProceso.StartInfo = comandoIniciador;
                comandoProceso.Start();
                comandoProceso.WaitForExit();
                File.Delete(pathFile);
                MessageBox.Show("Imagen creada en: " + imgFileName);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
