using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SociosporcentajesLibrary;
namespace Ventanasocios
{
    public partial class Form1 : Form
    {

        Porcentajesocioclass socio = new Porcentajesocioclass();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            socio.porcentajedelossocios();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            socio.imprimir(listBox1);
        }
    }
}
