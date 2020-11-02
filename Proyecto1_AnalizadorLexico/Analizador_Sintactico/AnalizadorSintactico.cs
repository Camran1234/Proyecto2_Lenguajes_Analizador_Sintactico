using Proyecto1_AnalizadorLexico.Archivo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_AnalizadorLexico.Analizador_Sintactico
{
    class AnalizadorSintactico
    {
        private Expresion[] expresiones = new Expresion[44];
        public AnalizadorSintactico()
        {
            expresiones[0] = new Expresion("E");
            expresiones[0].AddTokensApunta("Palabra", "F G");
            expresiones[1] = new Expresion("F");
            expresiones[1].AddTokensApunta("Palabra", "Palabra Pa Pc Y");
            expresiones[2] = new Expresion("Y");
            expresiones[2].AddTokensApunta("{", "{");
            expresiones[3] = new Expresion("_Y");
            expresiones[3].AddTokensApunta("}", "}");
            expresiones[4] = new Expresion("G");
            expresiones[4].AddTokensApunta("Entero", "A G");
            expresiones[4].AddTokensApunta("Cadena", "A G");
            expresiones[4].AddTokensApunta("Chart", "A G");
            expresiones[4].AddTokensApunta("Decimal", "A G");
            expresiones[4].AddTokensApunta("Boolean", "A G");
            expresiones[4].AddTokensApunta("SI", "S G");
            expresiones[4].AddTokensApunta("Mientras", "M G");
            expresiones[4].AddTokensApunta("Hacer", "H G");
            expresiones[4].AddTokensApunta("Desde", "D G");
            expresiones[4].AddTokensApunta("Imprimir", "I G");
            expresiones[4].AddTokensApunta("Leer", "L G");
            expresiones[4].AddTokensApunta("Variable", "A G");
            expresiones[4].AddTokensApunta("}", "_Y");
            expresiones[5] = new Expresion("Pa");
            expresiones[5].AddTokensApunta("(", "(");
            expresiones[6] = new Expresion("Pc");
            expresiones[6].AddTokensApunta(")", ")");
            expresiones[7] = new Expresion("A");
            expresiones[7].AddTokensApunta("Entero", "P Q");
            expresiones[7].AddTokensApunta("Cadena", "P Q");
            expresiones[7].AddTokensApunta("Chart", "P Q");
            expresiones[7].AddTokensApunta("Decimal", "P Q");
            expresiones[7].AddTokensApunta("Boolean", "P Q");
            expresiones[7].AddTokensApunta("Variable", "P Q");
            expresiones[8] = new Expresion("P");
            expresiones[8].AddTokensApunta("Entero", "Entero V K");
            expresiones[8].AddTokensApunta("Cadena", "Cadena V K");
            expresiones[8].AddTokensApunta("Chart", "Chart V K");
            expresiones[8].AddTokensApunta("Decimal", "Decimal V K");
            expresiones[8].AddTokensApunta("Boolean", "Boolean V K");
            expresiones[8].AddTokensApunta("Variable", "V Fe");
            expresiones[9] = new Expresion("_L");
            expresiones[9].AddTokensApunta("numeroEntero", "W C");
            expresiones[9].AddTokensApunta("string", "W C");
            expresiones[9].AddTokensApunta("char'", "W C");
            expresiones[9].AddTokensApunta("numeroDecimal", "W C");
            expresiones[9].AddTokensApunta("True", "W C");
            expresiones[9].AddTokensApunta("False", "W C");
            expresiones[9].AddTokensApunta("Variable", "W C");
            expresiones[9].AddTokensApunta(")", "C");
            expresiones[9].AddTokensApunta("&&", "C");
            expresiones[9].AddTokensApunta("||", "C");
            expresiones[10] = new Expresion("V");
            expresiones[10].AddTokensApunta("Variable", "Variable");
            expresiones[11] = new Expresion("K");
            expresiones[11].AddTokensApunta("=", "= _K ");
            expresiones[11].AddTokensApunta(",", ", V K'");
            expresiones[12] = new Expresion("Q");
            expresiones[12].AddTokensApunta(";", ";");
            expresiones[13] = new Expresion("K'");
            expresiones[13].AddTokensApunta(",", ", V K'");
            expresiones[13].AddTokensApunta(";", "e");
            expresiones[14] = new Expresion("_K");
            expresiones[14].AddTokensApunta("numeroEntero", "W _K'");
            expresiones[14].AddTokensApunta("string", "W _K'");
            expresiones[14].AddTokensApunta("char'", "W _K'");
            expresiones[14].AddTokensApunta("numeroDecimal", "W _K'");
            expresiones[14].AddTokensApunta("True", "W _K'");
            expresiones[14].AddTokensApunta("False", "W _K'");
            expresiones[15] = new Expresion("_K'");
            expresiones[15].AddTokensApunta(";", "e");
            expresiones[15].AddTokensApunta("+", "+W _K'");
            expresiones[16] = new Expresion("S");
            expresiones[16].AddTokensApunta("SI", "O _S");
            expresiones[17] = new Expresion("_S");
            expresiones[17].AddTokensApunta("{", "Y G O'");
            expresiones[18] = new Expresion("O");
            expresiones[18].AddTokensApunta("SI", "SI Pa T");
            expresiones[19] = new Expresion("O'");
            expresiones[19].AddTokensApunta("Entero", "e");
            expresiones[19].AddTokensApunta("Cadena", "e");
            expresiones[19].AddTokensApunta("Chart", "e");
            expresiones[19].AddTokensApunta("Decimal", "e");
            expresiones[19].AddTokensApunta("Boolean", "e");
            expresiones[19].AddTokensApunta("SI", "e");
            expresiones[19].AddTokensApunta("SINO_SI", "SINO_SI Pa T _S");
            expresiones[19].AddTokensApunta("SINO", "SINO _S");
            expresiones[19].AddTokensApunta("Mientras", "e");
            expresiones[19].AddTokensApunta("Hacer", "e");
            expresiones[19].AddTokensApunta("Desde", "e");
            expresiones[19].AddTokensApunta("Imprimir", "e");
            expresiones[19].AddTokensApunta("Leer", "e");
            expresiones[19].AddTokensApunta("}", "e");
            expresiones[20] = new Expresion("M");
            expresiones[20].AddTokensApunta("Mientras", "_M R");
            expresiones[21] = new Expresion("_M");
            expresiones[21].AddTokensApunta("Mientras", "Mientras Pa T");
            expresiones[22] = new Expresion("R");
            expresiones[22].AddTokensApunta("{", "Y G");
            expresiones[23] = new Expresion("H");
            expresiones[23].AddTokensApunta("Hacer", "_H Z");
            expresiones[24] = new Expresion("_H");
            expresiones[24].AddTokensApunta("Hacer", "Hacer Y");
            expresiones[25] = new Expresion("Z");
            expresiones[25].AddTokensApunta("numeroEntero", "G _M");
            expresiones[25].AddTokensApunta("Cadena", "G _M");
            expresiones[25].AddTokensApunta("Chart", "G _M");
            expresiones[25].AddTokensApunta("numeroDecimal", "G _M");
            expresiones[25].AddTokensApunta("Variable", "G _M");
            expresiones[25].AddTokensApunta("Boolean", "G _M");
            expresiones[25].AddTokensApunta("SI", "G _M");
            expresiones[25].AddTokensApunta("Mientras", "G _M");
            expresiones[25].AddTokensApunta("Hacer", "G _M");
            expresiones[25].AddTokensApunta("Desde", "G _M");
            expresiones[25].AddTokensApunta("Imprimir", "G _M");
            expresiones[25].AddTokensApunta("Leer", "G _M");
            expresiones[25].AddTokensApunta("}", "G _M");
            expresiones[26] = new Expresion("T");
            expresiones[26].AddTokensApunta("numeroEntero", "W _P _L");
            expresiones[26].AddTokensApunta("string", "W _P _L");
            expresiones[26].AddTokensApunta("char'", "W _P _L");
            expresiones[26].AddTokensApunta("numeroDecimal", "W _P _L");
            expresiones[26].AddTokensApunta("True", "W _P _L");
            expresiones[26].AddTokensApunta("False", "W _P _L");
            expresiones[26].AddTokensApunta("Variable", "W _P _L");
            expresiones[26].AddTokensApunta("!", "_W C");
            expresiones[27] = new Expresion("_W");
            expresiones[27].AddTokensApunta("!", "! W");
            expresiones[28] = new Expresion("W");
            expresiones[28].AddTokensApunta("numeroEntero", "numeroEntero");
            expresiones[28].AddTokensApunta("string", "string");
            expresiones[28].AddTokensApunta("char'", "char'");
            expresiones[28].AddTokensApunta("numeroDecimal", "numeroDecimal");
            expresiones[28].AddTokensApunta("False", "False");
            expresiones[28].AddTokensApunta("True", "True");
            expresiones[28].AddTokensApunta("Variable", "V");
            expresiones[29] = new Expresion("_P");
            expresiones[29].AddTokensApunta(")", "e");
            expresiones[29].AddTokensApunta("==", "==");
            expresiones[29].AddTokensApunta(">", ">");
            expresiones[29].AddTokensApunta(">=", ">=");
            expresiones[29].AddTokensApunta("<", "<");
            expresiones[29].AddTokensApunta("<=", "<=");
            expresiones[29].AddTokensApunta("!=", "!=");
            expresiones[30] = new Expresion("C");
            expresiones[30].AddTokensApunta(")", "Pc");
            expresiones[30].AddTokensApunta("&&", "&& T");
            expresiones[30].AddTokensApunta("||", "|| T");
            expresiones[31] = new Expresion("D");
            expresiones[31].AddTokensApunta("Desde", "Desde V X");
            expresiones[32] = new Expresion("X");
            expresiones[32].AddTokensApunta("=", "= W B");
            expresiones[33] = new Expresion("B");
            expresiones[33].AddTokensApunta("Hasta", "Hasta V _B");
            expresiones[34] = new Expresion("_B");
            expresiones[34].AddTokensApunta("==", "_P W U");
            expresiones[34].AddTokensApunta(">", "_P W U");
            expresiones[34].AddTokensApunta(">=", "_P W U");
            expresiones[34].AddTokensApunta("<", "_P W U");
            expresiones[34].AddTokensApunta("<=", "_P W U");
            expresiones[34].AddTokensApunta("!=", "_P W U");
            expresiones[35] = new Expresion("U");
            expresiones[35].AddTokensApunta("Incremento", "Incremento W _U");
            expresiones[36] = new Expresion("_U");
            expresiones[36].AddTokensApunta("{", "Y G");
            expresiones[37] = new Expresion("I");
            expresiones[37].AddTokensApunta("Imprimir", "J I'");
            expresiones[38] = new Expresion("I'");
            expresiones[38].AddTokensApunta("+", "+ W I'");
            expresiones[38].AddTokensApunta(")", "Pc Q");
            expresiones[39] = new Expresion("J");
            expresiones[39].AddTokensApunta("Imprimir", "Imprimir Pa W");
            expresiones[40] = new Expresion("L");
            expresiones[40].AddTokensApunta("Leer", "_Ñ _Q");
            expresiones[41] = new Expresion("_Ñ");
            expresiones[41].AddTokensApunta("Leer", "Leer Pa V");
            expresiones[42] = new Expresion("_Q");
            expresiones[42].AddTokensApunta(")", "Pc Q");
            expresiones[43] = new Expresion("Fe");
            expresiones[43].AddTokensApunta("++", "++");
            expresiones[43].AddTokensApunta("--", "--");
            expresiones[43].AddTokensApunta("=", "K");
        }

        public Boolean EmpezarAnalizador(List<Token> tokens)
        {
            Automata_Pila pila = new Automata_Pila();
            string token;
            string[] palabras;
            Boolean necesitaNuevaExpresion;
            int acceso;
            for (int indexToken = 0; indexToken < tokens.Count; indexToken++)
            {
                again:
                token = tokens[indexToken].ReturnTokenName();
                if (!token.Equals("ComentarioUnaLinea") && !token.Equals("ComentarioVariasLineas"))
                {
                    necesitaNuevaExpresion = pila.QuitarElemento(token);
                    if (!necesitaNuevaExpresion)
                    {
                        //Devuelve el index del token
                        acceso = this.AnalizeToken(pila.GetLastElement());
                        if (acceso != -1)
                        {
                            palabras = expresiones[acceso].ReturnExpresionApuntadora(token);
                            if (palabras == null)
                            {
                                FormEntorno.cuadroErrorA.AppendText("Error sintactico cerca de: " + this.LexicErrorMessage(indexToken, tokens) + "\n");
                                MessageBox.Show("Error Sintactico, no se puede generar el árbol");
                                return false;
                            }
                            pila.AgregarElemento(palabras, token);
                        }
                        else
                        {
                            //Codigo Para indicar que ya no se pudo continuar el automata
                            FormEntorno.cuadroErrorA.AppendText("Error sintactico cerca de: " + this.LexicErrorMessage(indexToken, tokens) + "\n");
                            MessageBox.Show("Error Sintactico, no se puede generar el árbol");
                            return false;
                        }
                        if (!pila.QuitarElemento(token))
                        {
                            goto again;
                        }
                    }
                }

            }
            if (pila.ComprobarAutomataCorrecto())
            {
                //Codigo para indicar que la sintaxis esta correcta
                
                return true;
            }
            MessageBox.Show("ERROR: ");
            FormEntorno.cuadroErrorA.AppendText("Error sintactico incapaz de detectar \n");
            return false;
        }

        private string LexicErrorMessage(int indexToken, List<Token> tokens)
        {
            string textoError = "";
            if (indexToken > 0 && indexToken < tokens.Count - 1)
            {
                textoError += tokens[indexToken - 1].ReturnLexema() + tokens[indexToken].ReturnLexema()
                    + tokens[indexToken + 1].ReturnLexema();
            }
            else if (indexToken >= 0 && indexToken < tokens.Count - 1)
            {
                textoError += tokens[indexToken].ReturnLexema()
                    + tokens[indexToken + 1].ReturnLexema();
            }
            else
            {
                textoError += tokens[indexToken].ReturnLexema();
            }
            return textoError;
        }

        private int  AnalizeToken(string nombre)
        {
            for (int indexExpresion = 0; indexExpresion < expresiones.Length; indexExpresion++)
            {
                if (expresiones[indexExpresion].SameName(nombre))
                {
                    return indexExpresion;
                }
            }
            return -1;
        }
    }
}
