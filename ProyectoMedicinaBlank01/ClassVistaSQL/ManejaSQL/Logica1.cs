using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ManejaSQL
{
    public class Logica1
    {
        SqlCommand carrito;
        string mensj = "";
        ModeloSQL1 msql = new ModeloSQL1();


        List<int> Pacientesver = new List<int>();
        List<int> idPaciente1 = new List<int>();



        /////////Inserciones/////////////////////////



        public void InsertarPaciente(SqlConnection carretera, string nombre, string apellidop,
            string apellidom, string correo, string telefono, string fecha, string horacita, ref string mensaje)
        {
            string query = "insert into Paciente1(NombrePa,apellidoP,apellidoM,correo,telefono,fecha,horacita )  values (@nombre,@apellidopate,@apellidomate,@correopac,@telefonopac,@fechapac,@horacitapac)";

            if (carretera != null)
            {
                try
                {
                    SqlParameter uno = new SqlParameter("nombre", SqlDbType.VarChar, 100);
                    uno.Direction = ParameterDirection.Input;
                    uno.Value = nombre;

                    SqlParameter dos = new SqlParameter("apellidopate", SqlDbType.VarChar, 100);
                    dos.Direction = ParameterDirection.Input;
                    dos.Value = apellidop;

                    SqlParameter tres = new SqlParameter("apellidomate", SqlDbType.VarChar, 100);
                    tres.Direction = ParameterDirection.Input;
                    tres.Value = apellidom;

                    SqlParameter cuatro = new SqlParameter("correopac", SqlDbType.VarChar, 100);
                    cuatro.Direction = ParameterDirection.Input;
                    cuatro.Value = correo;

                    SqlParameter cinco = new SqlParameter("telefonopac", SqlDbType.VarChar, 100);
                    cinco.Direction = ParameterDirection.Input;
                    cinco.Value = telefono;


                    SqlParameter seis = new SqlParameter("fechapac", SqlDbType.VarChar, 100);
                    seis.Direction = ParameterDirection.Input;
                    seis.Value = fecha;


                    SqlParameter siete = new SqlParameter("horacitapac", SqlDbType.VarChar, 100);
                    siete.Direction = ParameterDirection.Input;
                    siete.Value = horacita;


                    carrito = new SqlCommand();
                    carrito.Parameters.Add(uno);
                    carrito.Parameters.Add(dos);
                    carrito.Parameters.Add(tres);
                    carrito.Parameters.Add(cuatro);
                    carrito.Parameters.Add(cinco);
                    carrito.Parameters.Add(seis);
                    carrito.Parameters.Add(siete);


                    carrito.Connection = carretera;
                    carrito.CommandText = query;
                    carrito.ExecuteNonQuery();

                    mensaje = "se incerto correctamente";


                }
                catch (Exception h)
                {
                    mensaje = "no se inserto correctamente" + h.Message;

                }
                carretera.Close();
            }
            else
            {

                mensaje = "no hay conexion a la base de datos";


            }



        }


        public string Validaciondelashoras(SqlConnection carretera, string nombre, string apellidop,
            string apellidom, string correo, string telefono, string fecha, string horacita, ref string mensaje)
        {


            if (carretera != null)
            {

                try
                {

                    string alertaa = "";
                    carrito = new SqlCommand();
                    carrito.CommandText = "Confirmandohoras3";
                    carrito.CommandType = CommandType.StoredProcedure;
                    carrito.Parameters.Add(new SqlParameter("@nombre", nombre));
                    carrito.Parameters.Add(new SqlParameter("@apellidopate", apellidop));
                    carrito.Parameters.Add(new SqlParameter("@apellidomate", apellidom));
                    carrito.Parameters.Add(new SqlParameter("@correopac", correo));
                    carrito.Parameters.Add(new SqlParameter("@telefonopac", telefono));
                    carrito.Parameters.Add(new SqlParameter("@fechapac", fecha));
                    carrito.Parameters.Add(new SqlParameter("@horasdeunacita ", horacita));
                    SqlParameter Alertaa = new SqlParameter("@alerta", SqlDbType.VarChar);
                    Alertaa.Direction = ParameterDirection.Output;
                    Alertaa.Size = 40;
                    carrito.Parameters.Add(Alertaa);

                    carrito.Connection = carretera;
                    carrito.ExecuteNonQuery();
                    alertaa = carrito.Parameters["@alerta"].Value.ToString();

                    if (alertaa == "ya existe la hora")
                    {
                        mensaje = "esta hora ya esta ocupada";
                    }
                    else {
                        mensaje = "se incerto correctamente";

                    }



                }
                catch (Exception error)
                {
                    MessageBox.Show("error :" + error.ToString());
                }
                carretera.Close();
            }
            return mensaje;
           
        }



        public void Insertarnuevacita(SqlConnection carretera, int idpaciente1, string fechanue, string horarionue, ref string mensaje)
        {

            int idpacientes = idPaciente1[idpaciente1];
            string query = "insert into NuevaCita(idPaciente1,fecha ,horacita) " +
               "values(" + idpacientes + ",@fechanue,@horarionue)";

            if (carretera != null)
            {

                try
                {
                    SqlParameter uno = new SqlParameter("idPaciente1", SqlDbType.Int, 50);
                    uno.Direction = ParameterDirection.Input;
                    uno.Value = idpacientes;

                    SqlParameter dos = new SqlParameter("fecha", SqlDbType.VarChar, 100);
                    dos.Direction = ParameterDirection.Input;
                    dos.Value = fechanue;

                    SqlParameter tres = new SqlParameter("horario", SqlDbType.VarChar, 100);
                    dos.Direction = ParameterDirection.Input;
                    dos.Value = horarionue;


                    carrito = new SqlCommand();
                    carrito.Parameters.Add(uno);
                    carrito.Parameters.Add(dos);
                    carrito.Parameters.Add(tres);


                    carrito.Connection = carretera;
                    carrito.CommandText = query;
                    carrito.ExecuteNonQuery();

                    mensaje = "se incerto correctamente";


                }
                catch (Exception h)
                {
                    mensaje = "no se inserto correctamente" + h.Message;

                }
                carretera.Close();
            }



        }






        /////////FINAL DE Inserciones/////////////////////////


        ///////validar///////

      
        ///fin validar


        /***Datas Reader   INICIO***/
        public SqlDataReader ConsultaDataReaderconParametross(ref SqlConnection cn_abierta, string query1, ref string mensj, SqlParameter campo)
        {
            SqlDataReader contenedor = null;
            SqlCommand carrito = new SqlCommand();
            carrito.Parameters.Add(campo);

            if (cn_abierta != null)
            {
                carrito.Connection = cn_abierta;
                carrito.CommandText = query1;
                try
                {
                    contenedor = carrito.ExecuteReader();
                    mensj = "Consulta correcta";
                }
                catch (Exception g)
                {
                    mensj = "Error: " + g.Message;
                    contenedor = null;
                }
            }
            else
            {
                mensj = "No hay conexión abierta";
                contenedor = null;
            }
            return contenedor;
        }
        public SqlDataReader ConsultaDataReader(ref SqlConnection cn_abierta, string query1, ref string mensj)
        {
            SqlDataReader contenedor = null;
            SqlCommand carrito = new SqlCommand();

            if (cn_abierta != null)
            {
                carrito.Connection = cn_abierta;
                carrito.CommandText = query1;
                try
                {
                    contenedor = carrito.ExecuteReader();
                    mensj = "Consulta correcta";
                }
                catch (Exception g)
                {
                    mensj = "Error: " + g.Message;
                    contenedor = null;
                }
            }
            else
            {
                mensj = "No hay conexión abierta";
                contenedor = null;
            }
            return contenedor;
        }

        //esto debería ir en la lógica de negocios porque el siguiente método va a depender del problema
        public List<string> DevuelveMarcas(SqlConnection abierta, ref string mens, ref List<int> ids)
        {
            List<string> misMarcas = new List<string>();
            ids = new List<int>();

            SqlDataReader tablita = null;

            tablita = ConsultaDataReader(ref abierta, "Select * from MArcas", ref mens);
            if (tablita != null)
            {
                while (tablita.Read())
                {
                    ids.Add((int)tablita[0]);
                    misMarcas.Add((string)tablita[1]);
                }
                abierta.Close();
                abierta.Dispose();
            }
            else
            {
                mens = mens + ", no hay datos";
                misMarcas = null;
                ids = null;
            }

            return misMarcas;
        }

        /***Datas Reader   FINAL***/
        /////////////////////////////////////C O N S U L T A S//////////////////////////////////////////////////

        public bool validar(string usuario,string passwordus, SqlConnection cn_abierta, ref string mensj)
        {
            bool dev =true;
            try 
            {
                
                carrito = new SqlCommand("Select Usuario, contrasena  from loginusuario1 where Usuario=@usuario and contrasena=@pas ", cn_abierta);
                carrito.Parameters.AddWithValue("usuario", usuario);
                carrito.Parameters.AddWithValue("pas", passwordus);
                /* SqlDataAdapter sda = new SqlDataAdapter();
                 DataTable dt = new DataTable();
                 sda.Fill(dt);
                 if (dt.Rows.Count==1) */

                if (cn_abierta!=null  ) 
                {
                    MessageBox.Show("Entrando");
                    dev = true;
                }
                else
                {
                    MessageBox.Show("error de contraseña o usuario");
                    dev = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return dev;
        }

        public string validar1(string usuarios, SqlConnection cn_abierta,ref string mnsj)
        {
            string abrir = "";
            string contraseña = "";
            string query = "select contrasena  from loginusuario1  where Usuario ='" + usuarios + "'";
            
            SqlDataReader dr1 = null;
            
            if (cn_abierta != null)
            {
                dr1 = msql.ConsultaDataReader(ref cn_abierta, query, ref mnsj);
                if (dr1 != null)
                {
                    while (dr1.Read())
                    {
                        contraseña = ((string)dr1[0]);
                    }
                }
                cn_abierta.Close();
                cn_abierta.Dispose();
            }
            return contraseña;
        }





        public SqlDataReader ConsultaTodos(SqlConnection cn_abierta, ref string mensj)
        {
            SqlDataReader contenedor = null;
            carrito = new SqlCommand("Select * from Paciente1", cn_abierta);

            if (cn_abierta != null)
            {
                try
                {
                    contenedor = carrito.ExecuteReader();
                    mensj = "Consulta correcta";
                }
                catch (Exception g)
                {
                    mensj = "Error: " + g.Message;
                    contenedor = null;
                }
            }
            else
            {
                mensj = "No hay conexión abierta";
                contenedor = null;
            }
            return contenedor;
        }

        public DataSet DTConsultarpacientes1(SqlConnection carretera,  ref string mensj)
        {
        //    DevuelveCuatrimestres(carretera);
        //    int losCuatris = idforeign[selecc];
            return msql.ConsultaDataSet(carretera, "select*from Paciente1" ,ref mensj);
        }



        public void consultamiestilo(SqlConnection carretera, DataGridView tablita)
        {
            string mensaje = "";
            SqlConnection conex1 = msql.Abrirconexion(ref mensaje);
            if (carretera != null) { 
            SqlCommand comando = new SqlCommand("select NombrePa as Nombre, apellidoP as ApellidoPaterno, apellidoM as ApellidoPaterno, correo as Correo, telefono as Telefono,fecha as FechaCita, horacita as Horadelacita from Paciente1; ", carretera);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable atrapa = new DataTable();
            adaptador.Fill(atrapa);
            tablita.DataSource = atrapa;
            }
            else
            {

            }
            
        }

    }
}
