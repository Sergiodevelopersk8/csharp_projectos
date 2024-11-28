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
using ClassVistaSQL;
using System.Configuration;
using System.Data.SqlClient;
using System.Configuration.Assemblies;



namespace Ventana
{
    public partial class Form1 : Form
    {
        string mensaje = "";
        ModeloSQL1 model = new ModeloSQL1();
        Logica1 logi = new Logica1();
        VistaSQL vista = new VistaSQL();

        
        public Form1()
        {
            InitializeComponent();
            model.Cadenaconexion = ConfigurationManager.ConnectionStrings["cnsql1"].ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // DateTimePiker1.value = DateTime.Now;

            

            txtfecha.Visible = false;
            textBox1.Visible = false;
            button3.Visible = false;
            SqlConnection conex1 = model.Abrirconexion(ref mensaje);
           
            logi.consultamiestilo(conex1, dataGridView1);

            vista.Primerashorascombo(comboBox1);
            vista.Segundashorascombo(comboBox2);
            vista.AmoPm(comboBox3);

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string a = "-";
                string primerahora = comboBox1.SelectedItem.ToString();
                string segundahora = comboBox2.SelectedItem.ToString();
                string amopm = comboBox3.SelectedItem.ToString();
                string todojunto = primerahora + a + segundahora +" "+ amopm;
                textBox1.Text = todojunto.ToString();

                bool compr=false;
                // DateTime fecha = dateTimePicker1.Value.Date;
                DateTime fecha = dateTimePicker1.Value.Date;
                string fechacita1 = Convert.ToString(fecha);
                txtfecha.Text = fecha.ToString("dd/MM/yyyy");

                if (Nombretxt.Text != "" && Apellidopaternotxt.Text != "" && ApellidoMaternotxt.Text != "" && Correotxt.Text != ""
                    && Telefonotxt.Text != "" && textBox1.Text != "" && txtfecha.Text != "")
                {

                    SqlConnection conex1 = model.Abrirconexion(ref mensaje);
                   
                     string incercion =  logi.Validaciondelashoras(conex1, Nombretxt.Text, Apellidopaternotxt.Text, ApellidoMaternotxt.Text, Correotxt.Text,
                        Telefonotxt.Text, txtfecha.Text, textBox1.Text, ref mensaje);
                    if (incercion != "esta hora ya esta ocupada") 
                    {
                        MessageBox.Show("Se inserto correctamente los datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        conex1.Close();
                        conex1.Dispose();
                        Nombretxt.Text = "";
                        Apellidopaternotxt.Text = "";
                        ApellidoMaternotxt.Text = "";
                        Correotxt.Text = "";
                        Telefonotxt.Text = "";
                        textBox1.Text = "";
                        Nombretxt.Focus();
                    }

                    else 
                    {
                        MessageBox.Show("La hora ya esta ocupada", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }



                }



                else
                {
                    MessageBox.Show("No se a llenado los campos por lo que no se puede agregar los datos","mensaje",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                


            }

            catch (Exception mm)
            {
                MessageBox.Show(mm.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {



            SqlConnection conex1 = model.Abrirconexion(ref mensaje);

            logi.consultamiestilo(conex1, dataGridView1);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
