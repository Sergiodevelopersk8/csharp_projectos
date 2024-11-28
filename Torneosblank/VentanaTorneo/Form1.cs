using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModeloDelTorneoLibrary;
using VistaTorneo;
namespace VentanaTorneo
{
    public partial class Form1 : Form
    {

        //Torneo modelo;//
        Vistaclass mivista = new Vistaclass();
        Confederacion miConfe;
        string mensj = "";
        string[] atrapa;
        public Form1()
        {
            InitializeComponent();
        }

        private void creaConfederacion_Click(object sender, EventArgs e)
        {
            try
            {
                miConfe = new Confederacion(Convert.ToInt16(texboxnumtorne.Text), textBoxconfenombre.Text);
                mivista.MiLetrero("Confederacion creada.");
                texboxnumtorne.Text = "";
                textBoxconfenombre.Text = "";
                texboxnumtorne.Focus();
            }
            catch
            {
                mivista.MiLetrero("Asegurese de haber insertado los datos correctamente.");
            }
        }

        private void btnCrearTor_Click(object sender, EventArgs e)
        {
            try
            {
                mensj = miConfe.AgregarTorneo(txtNombreTor.Text, Convert.ToInt16(txtTotalEquipos.Text));
                mivista.MiLetrero(mensj);
                atrapa = miConfe.devuelveDatosTorneos();
                txtNombreTor.Text = "";
                txtTotalEquipos.Text = "";
                txtNombreTor.Focus();
            }
            catch
            {
                mivista.MiLetrero("Asegurese de haber insertado los datos correctamente.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            atrapa = miConfe.devuelveDatosTorneos();
            mivista.MonstrarCadenas(atrapa, listBox2);
        }

        private void btnAgregarEq_Click(object sender, EventArgs e)
        {
            try
            {
                mensj = miConfe.AgregarEquiposATorneo(listBox2.SelectedIndex, txtClub.Text, txtCiudad.Text, Convert.ToInt16(txtJugadores.Text), Convert.ToInt16(txtFundacion.Text));
                mivista.MiLetrero(mensj);
                txtClub.Text = "";
                txtCiudad.Text = "";
                txtJugadores.Text = "";
                txtFundacion.Text = "";
                txtClub.Focus();
            }
            catch
            {
                mivista.MiLetrero("Asegurese de haber insertado los datos correctamente.");
            }
        }

        private void btnMonstrarEq_Click(object sender, EventArgs e)
        {
            try
            {
                atrapa = miConfe.devuelveDatosEquiposPorTorneo(listBox2.SelectedIndex);
                mivista.MonstrarCadenas(atrapa, listBox1);

            }
            catch
            {
                mivista.MiLetrero("Asegurese de haber insertado los datos correctamente.");
            }
        }

        private void eliminarPorSelec_Click(object sender, EventArgs e)
        {
            mensj = miConfe.EliminarPorPosi_EnTorneo(listBox2.SelectedIndex, listBox1.SelectedIndex);
            mivista.MiLetrero(mensj);
        }

        private void eliminaTodasCopias_Click(object sender, EventArgs e)
        {
            try
            {
                mensj = miConfe.EliminarTodasCopias_EnTorneo(listBox2.SelectedIndex, txteliminar.Text);
                mivista.MiLetrero(mensj);
                txteliminar.Text = "";
            }
            catch
            {
                mivista.MiLetrero("Asegurese de haber insertado los datos correctamente.");
            }
        }

        private void eliminarXbusqueda_Click(object sender, EventArgs e)
        {
            try
            {
                mensj = miConfe.EliminaPorBusqueda_EnTorneo(listBox2.SelectedIndex, txteliminar.Text);
                mivista.MiLetrero(mensj);
                txteliminar.Text = "";
            }
            catch
            {
                mivista.MiLetrero("Asegurese de haber insertado los datos correctamente.");
            }
        }

        private void DespuesDe_Click(object sender, EventArgs e)
        {
            try
            {
                mensj = miConfe.AgregarDespuesDe_EnTorneo(listBox2.SelectedIndex, listBox1.SelectedIndex, txtClub.Text, txtCiudad.Text, Convert.ToInt16(txtJugadores.Text), Convert.ToInt16(txtFundacion.Text));
                mivista.MiLetrero(mensj);
                txtClub.Text = "";
                txtCiudad.Text = "";
                txtJugadores.Text = "";
                txtFundacion.Text = "";
                txtClub.Focus();
            }
            catch
            {
                mivista.MiLetrero("Asegurese de haber insertado los datos correctamente.");
            }
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                mensj = miConfe.ModificarEquipo_EnTorneo(listBox2.SelectedIndex, listBox1.SelectedIndex, txtClub.Text, txtCiudad.Text, Convert.ToInt16(txtJugadores.Text), Convert.ToInt16(txtFundacion.Text));
                mivista.MiLetrero(mensj);
                txtClub.Text = "";
                txtCiudad.Text = "";
                txtJugadores.Text = "";
                txtFundacion.Text = "";
                txtClub.Focus();
            }
            catch
            {
                mivista.MiLetrero("Asegurese de haber insertado los datos correctamente.");
            }
        }
    }
}
