using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using encriptadorydes;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Encripdescrip encri = new Encripdescrip();
       
        string mensaje = "";
        string iniciar = "";
       
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                iniciar = encri.encriptador(textBox1.Text, listBox1, ref mensaje);
            }
            else
            {
                MessageBox.Show("porfavor llene los datos");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {

                iniciar = encri.desencriptador(textBox1.Text, listBox1, ref mensaje);


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text!="")
            {

                iniciar = encri.encriptador2(textBox1.Text, listBox1, int.Parse(textBox2.Text), ref mensaje);


            }
        }
    }
}
