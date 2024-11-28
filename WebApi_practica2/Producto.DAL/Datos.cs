using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Sql;
using Producto.Entities2;
using System.Data;

namespace Producto.DAL
{
    public class Datos
    {
        string conexion = "";
        SqlConnection carretera;

        public void Conectar()
        {

            conexion = ConfigurationManager.ConnectionStrings["ConectaProducto"].ConnectionString;
            carretera = new SqlConnection(conexion);
        }

        public void LiberarConexion()
        {

            carretera.Close();
        }



        public List<Producto.Entities2.Producto2> ListaProductos()
        {
            string consulta = "";
            DataRow fila;
            List<Producto.Entities2.Producto2> ListProducto = new List<Producto.Entities2.Producto2>();
            DataSet Ds = new DataSet();
            SqlCommand dbcommnad = new SqlCommand();
            Conectar();
            consulta = "select * from Producto";
            dbcommnad.CommandText = consulta;
            dbcommnad.Connection = carretera;


            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = dbcommnad;


            try
            {
                adapter.Fill(Ds);
                DataTable tabla = Ds.Tables[0];


                int i = 0;
                while (i <= tabla.Rows.Count - 1)
                {
                    fila = tabla.Rows[i];
                    Producto.Entities2.Producto2 Pr = new Producto.Entities2.Producto2
                    {
                        Id_Producto = Convert.ToInt16(fila["Id_Producto"]),
                        Nombre_Producto = fila["Nombre_Producto"].ToString(),
                        Descripcion_Producto = fila["Descripcion_producto"].ToString()


                    };
                    ListProducto.Add(Pr);
                    ++i;
                }
                dbcommnad.Connection.Close();
                dbcommnad.Dispose();
                adapter.Dispose();
            }
            catch (Exception h)
            {
                Producto.Entities2.Producto2 Pro = new Producto.Entities2.Producto2
                {
                    mensaje = "Ha ocurrido un error" + h.Message// al acceder a la Base de Datos",
                };
                ListProducto.Add(Pro);
            }
            return ListProducto;
        }




    }
}
