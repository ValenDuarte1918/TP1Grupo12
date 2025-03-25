using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp1
{
    public partial class FormNombres : Form
    {
        FormularioPrincipal formularioPrincipal;
        public FormNombres(FormularioPrincipal formularioPrincipal)
        {
            InitializeComponent();
            this.formularioPrincipal = formularioPrincipal;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                listBox1.Items.Add(textBox1.Text.Trim());
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("No se puede agregar un nombre vacío");

            }
    }

        private void FormNombres_FormClosed(object sender, FormClosedEventArgs e)
        {
            formularioPrincipal.Show();
        }
    }
}
