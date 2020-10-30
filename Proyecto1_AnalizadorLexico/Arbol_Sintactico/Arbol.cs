using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_AnalizadorLexico.Arbol_Sintactico
{
    class Arbol
    {
        private string path ;
        private string pathFile;
        private FileStream flujoArchivo;
        private byte[] contenido;
        public Arbol()
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            MessageBox.Show(path);
            this.StartConnection();
        }

        //Empezamos la conexion con el archivo
        private void StartConnection()
        {
            pathFile = path + "\\Texto.dot";
            File.Delete(pathFile);
            flujoArchivo = File.Create(pathFile);
            contenido = new UTF8Encoding().GetBytes("digraph Archivo {");
            flujoArchivo.Write(contenido, 0, contenido.Length);
        }

        public Boolean AddNode()
        {
            //Agregar texto que soporte el agregar los nodos
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
            string img = path + "\\"+imgFileName+".png";
            this.GenerateImg( img);
        }

        /// <summary>
        /// Genera nuestra imagen 
        /// </summary>
        /// <param name="imgFileName"></param>
        private void GenerateImg(string imgFileName)
        {
            string comandoGenerador = "dot.exe -Tpng " + pathFile + " -o " + imgFileName + " ";
            var comando = string.Format(comandoGenerador);
            var comandoIniciador = new System.Diagnostics.ProcessStartInfo("cmd", "/C" + comando);
            var comandoProceso = new System.Diagnostics.Process();
            comandoProceso.StartInfo = comandoIniciador;
            comandoProceso.Start();
            comandoProceso.WaitForExit();


        }
    }
}
