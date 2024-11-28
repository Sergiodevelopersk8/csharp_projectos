using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using pruebaencriclass;

namespace Formprueba
{
    public partial class Form1 : Form
    {
        clsEncriptacion logica = new clsEncriptacion();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == " ")
                {
                    MessageBox.Show("por favor igrese el texto");
                }
                else
                {

                    //logica.stEncriptar(textBox1.Text);
                    string tkey = ConfigurationManager.AppSettings["tkey"];
                    label1.Text = logica.encri3des(textBox1.Text, tkey);
                    

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("error de " + ex);
            }
        }
    }
}
