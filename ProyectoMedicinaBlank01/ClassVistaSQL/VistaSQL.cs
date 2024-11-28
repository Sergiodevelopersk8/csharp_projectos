using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ClassVistaSQL
{
    public class VistaSQL
    {
        public void MiLetrero(string j)
        {
            MessageBox.Show(j);
        }

        public void LLenarcomboboxdepacientes(ComboBox box, SqlDataReader leer)
        {
            while (leer.Read())
            {
                box.Items.Add(leer["NombrePa"].ToString()+""+leer["apellidoP"].ToString()+""+leer["apellidoM"].ToString());
            }

            leer.Close();
        }


        public void LLenarListadecitas(ListBox listacitauno,SqlDataReader leer)
        {
            while (leer.Read())
            {
                listacitauno.Items.Add(leer["NombrePa"].ToString() + "" + leer["apellidoP"].ToString() + "" + leer["apellidoM"].ToString()+""+
                    leer["fecha "].ToString() + "" + leer["horacita "].ToString());
                                                                                                                  
            }
        }

        public void Primerashorascombo(ComboBox combo)
        {
            combo.Items.Clear();
          
            combo.Items.Add("9:00");
            combo.Items.Add("10:00");
            combo.Items.Add("11:00");
            combo.Items.Add("12:00");
            combo.Items.Add("1:00");
            combo.Items.Add("2:00");
            combo.Items.Add("3:00");
            combo.Items.Add("4:00");
            
            
        }


        public void Segundashorascombo(ComboBox combo)
        {
            combo.Items.Clear();
            combo.Items.Add("10:00");
            combo.Items.Add("11:00");
            combo.Items.Add("12:00");
            combo.Items.Add("1:00");
            combo.Items.Add("2:00");
            combo.Items.Add("3:00");
            

        }

        public void AmoPm(ComboBox combo)
        {
            combo.Items.Clear();
            combo.Items.Add("am");
            combo.Items.Add("pm");
           
        }
        public void muestraDataTable(System.Data.DataTable tabla, DataGridView celdas)
        {
            if (tabla != null)
            {
                celdas.DataSource = tabla;
            }
            else
            {
                MiLetrero(" tiene datos que mostrar ");
            }
        }

    }
}
