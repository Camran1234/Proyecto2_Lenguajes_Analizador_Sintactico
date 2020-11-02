using Proyecto1_AnalizadorLexico.Semantico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_AnalizadorLexico.Interfaces
{
    public partial class FormAsignadorVariable : Form
    {
        VariableValor variable;
        public FormAsignadorVariable(VariableValor variable)
        {
            InitializeComponent();
            this.variable = variable;
            this.textBoxVariable.AppendText(variable.GetName());
        }

        private void FormAsignadorVariable_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valor = textBoxValor.Text;
            variable.AssignValue(valor);
            this.Close();
        }
    }
}
