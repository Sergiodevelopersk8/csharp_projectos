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
using System.Configuration;
using System.Data.SqlClient;
using System.Configuration.Assemblies;

namespace Ventanalog
{
    public partial class Logwindow : Form
    {
        VistaSQL vista = new VistaSQL();
        Logica1 log = new Logica1();
        ModeloSQL1 sql = new ModeloSQL1();

        Logwindow logii = new Logwindow();
        string mensaje = "";
        Form1 inicio = new Form1();
        public Logwindow()
        {
            InitializeComponent();

            sql.Cadenaconexion = ConfigurationManager.ConnectionStrings["cnsql1"].ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pase = "";
            SqlConnection conex1 = sql.Abrirconexion(ref mensaje);

            string usuario = textBox1.Text;
            string password = textBox2.Text;
            /*bool contraseña = log.validar(usuario, password, conex1,ref pase);
            if ((bool)contraseña!=false)*/
            string contra= log.validar1(usuario,conex1,ref pase);
            if(contra==password)
            {
                inicio.Show();
                logii.Close();
            }
            else
            {
                MessageBox.Show("error de datos");
            }
        }
    }
}
