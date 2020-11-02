using Proyecto1_AnalizadorLexico.Archivo;
using Proyecto1_AnalizadorLexico.Gramaticas;
using Proyecto1_AnalizadorLexico.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_AnalizadorLexico.Semantico
{
    class TratadorTokens
    {
        private List<Token> tokens = new List<Token>();
        private List<VariableValor> variables = new List<VariableValor>();

        /// <summary>
        /// Clase para crear el documento de salida de las partes de imprimir y leer
        /// </summary>
        /// <param name="tokens"></param>
        public TratadorTokens(List<Token> tokens)
        {
            this.tokens = tokens;
            this.AssignVariable();
        }

        private void AssignVariable()
        {
            string path = this.CreateFile();
            string text = "";
            int indexImpresion;
            Boolean disponibilidadVariable = true;
            string prevision = "";
            if(path != null)
            {
                foreach (Token token in tokens)
                {
                    if (token.ReturnTokenName().Equals("Variable"))
                    {
                        for(int indexVariables =0; indexVariables<variables.Count; indexVariables++)
                        {
                            if(variables[indexVariables].ReturnToken().ReturnLexema().Equals(token.ReturnLexema()))
                            {
                                disponibilidadVariable = false;
                            }
                        }
                        if (disponibilidadVariable)
                        {
                            variables.Add(new VariableValor(token));
                        }
                        disponibilidadVariable = true;
                    }
                }
                for (int indexToken = 0; indexToken < tokens.Count; indexToken++)
                {
                    if (tokens[indexToken].ReturnTokenName().Equals("Imprimir"))
                    {//Para imprimir resultados
                        indexImpresion = indexToken + 2;
                        while (!tokens[indexImpresion].ReturnTokenName().Equals(")"))
                        {
                            if (!tokens[indexImpresion].ReturnTokenName().Equals("+"))
                            {
                                if (tokens[indexImpresion].ReturnTokenName().Equals("Variable"))
                                {
                                    for(int indexVariables=0; indexVariables< variables.Count; indexVariables++)
                                    {
                                        if (tokens[indexImpresion].ReturnLexema().Equals(variables[indexVariables].ReturnToken().ReturnLexema()))
                                        {
                                            text += variables[indexVariables].GetValueVariable();
                                            MessageBox.Show(""+variables.Count);
                                        }
                                    }
                                }
                                else
                                {
                                    prevision = tokens[indexImpresion].ReturnLexema();
                                    prevision = prevision.Replace("\"","");
                                    text += prevision;
                                }
                                
                            }
                            indexImpresion++;
                        }
                        text += "\n";
                        new ManipuladorArchivo().AddTextToFile(path, text);
                        text = "";
                    }//Para leer variables
                    else if (tokens[indexToken].ReturnTokenName().Equals("Leer"))
                    {
                        for(int index=0; index< variables.Count; index++)
                        {
                            if (variables[index].ReturnToken().ReturnLexema().Equals(tokens[indexToken+2].ReturnLexema()))
                            {
                                new FormAsignadorVariable(variables[index]).ShowDialog();
                                break;
                            }
                            
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Archivo de salida no creado");
            }

            
        }

        private string  CreateFile()
        {
            string valor;
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "txt files (*.txt)|*.txt";
            if(saveFile.ShowDialog() == DialogResult.OK)
            {
                valor = saveFile.FileName;
                new ManipuladorArchivo().NewFile("",valor);
                return valor;
            }
            return null;
        }
    }
}
