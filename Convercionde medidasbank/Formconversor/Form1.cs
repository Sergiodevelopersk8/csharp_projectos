using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassConversormedidas;

namespace Formconversor
{
    public partial class Form1 : Form
    {
        Convertidormedidas convertido = new Convertidormedidas();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            convertido.operacionesconv(textBox1.Text);
            convertido.generar(listBox1);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
