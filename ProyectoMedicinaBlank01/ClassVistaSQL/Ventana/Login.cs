using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassVistaSQL;
using ManejaSQL;
using Ventana;

namespace Ventana
{
    public partial class Login : Form
    {
        VistaSQL vista = new VistaSQL();
        Logica1 log = new Logica1();
        ModeloSQL1 sql = new ModeloSQL1();
        Form1 inicio = new Form1();
        public Login()
        {

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
