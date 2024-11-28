using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlVentasLibrary
{
    public class ControlventasClass
    {
        double precio,descuento;
        int cantidad = 0;
        double importe,  total;
       

        public void operacioncontrol(string precioo, string cantidadd)
        {
            precio = double.Parse(precioo);
            cantidad = int.Parse(cantidadd);

            descuentosproductos();
        }


        public void descuentosproductos()
        {
           importe = cantidad * precio;
             descuento = 11 / 100.0 * importe;
             total = importe - descuento;

        }

        public void imprimirlista(ListBox lista) 
        
      {
            lista.Items.Clear();
            lista.Items.Add("importe total"+" "+importe);
           
            lista.Items.Add(" Descuento"+" "+descuento);
           
            lista.Items.Add("Total a pagar "+" "+total);
          


        }

    }
}
