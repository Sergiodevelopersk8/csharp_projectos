using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDelTorneoLibrary
{
    public class Confederacion
    {
        //mio
        public string nomConfederacion { get; set; }
        private Torneo[] torneos;
        private int posicion = 0;
        string cad = "";

        public Confederacion(int numTorneos)
        {
            torneos = new Torneo[numTorneos];
        }

        public Confederacion(int numTorneos, string nombreConfe)
        {
            torneos = new Torneo[numTorneos];
            nomConfederacion = nombreConfe;

        }

        ///similar a la clase Torneo
        /// me devuelve los torneos creados
        public string[] devuelveDatosTorneos()
        {
            string[] temporal = new string[posicion];
            int t = 0;
            for (t = 0; t <= posicion - 1; t++)
            {
                temporal[t] = torneos[t].TodosDatosTorneos();
            }
            return temporal;
        }

        public string[] devuelveDatosEquiposPorTorneo(int equipoSelec)//Metodo para mostrar los equipos que hay en un torneo.
        {
            string[] datosEquipo = new string[equipoSelec];
            for (int t = 0; t <= posicion - 1; t++)
            {
                if (equipoSelec < posicion)
                {
                    datosEquipo = torneos[equipoSelec].devuelveDatosEquipos();
                }
            }
            return datosEquipo;
        }

        public string AgregarTorneo(string nombreTorneo, short equiposXtorneo)
        {

            if (posicion <= torneos.Length - 1)
            {
                torneos[posicion] = new Torneo(equiposXtorneo, nombreTorneo);
                posicion++;

                cad = "Torneo agregado.";
            }
            else
            {
                cad = "Ya se han creado los torneos indicados.";
            }
            return cad;
        }

        public string AgregarEquiposATorneo(int posicionTorneo, String club, String ciudad, short no_J, short año)
        {
            if (posicionTorneo == -1)
            {
                cad = "Debe seleccionar un torneo para insertarle equipos.";
            }
            else
            {
                cad = torneos[posicionTorneo].AgregarEquipo(club, ciudad, no_J, año);
            }
            return cad;
        }

        private int BuscarTorneo_EnConfederacion(int nombTorneo)//Metodo para buscar un torneo 
        {
            int piedrita = -1;
            int g = 0;

            for (g = 0; g <= posicion - 1; g++)
            {
                if (nombTorneo.Equals(torneos[g]))
                {
                    piedrita = g;
                    g = posicion;
                }
            }
            return piedrita;
        }

        public string EliminarPorPosi_EnTorneo(int torneoSelec, int equipoSelec)
        {
            if (torneoSelec == -1)
            {
                cad = "Debe seleccionar un torneo para realizar la funcion.";
            }
            else
            {
                if (equipoSelec == -1)
                {
                    cad = "Debe seleccionar un equipo para eliminar";
                }
                else
                {
                    cad = torneos[torneoSelec].EliminarPorPosicion(equipoSelec);
                }
            }
            return cad;
        }

        public string EliminaPorBusqueda_EnTorneo(int torneoSelec, string nombEquipo)
        {
            if (torneoSelec == -1)
            {
                cad = "Asegurese de haber seleccionado un torneo.";
            }
            else
            {
                cad = torneos[torneoSelec].EliminarBusquedas(nombEquipo);
            }
            return cad;
        }

        public string EliminarTodasCopias_EnTorneo(int torneoSelec, string nombEquipo)//Metodo para eliminar equipos repetidos
        {
            if (torneoSelec == -1)
            {
                cad = "Debe seleccionar un torneo para realizar la funcion.";
            }
            else
            {
                cad = torneos[torneoSelec].Eliminartodascopias(nombEquipo);
            }
            return cad;
        }

        public string ModificarEquipo_EnTorneo(int torneoSelec, int posiEquipo, String club, String ciudad, short no_J, short año)
        {
            if (torneoSelec == -1)
            {
                cad = "Debe seleccionar un torneo para realizar la funcion.";
            }
            else
            {
                if (posiEquipo == -1)
                {
                    cad = "Debe seleccionar un equipo para modificar.";
                }
                else
                {
                    cad = torneos[torneoSelec].Modificar(club, ciudad, no_J, año, posiEquipo);
                }
            }
            return cad;
        }

        public string AgregarDespuesDe_EnTorneo(int torneoSelec, int equipoSelec, String club, String ciudad, short no_J, short año)
        {
            if (equipoSelec >= 0)
            {
                cad = torneos[torneoSelec].InsertarDepuesDe(club, ciudad, no_J, año, equipoSelec);
            }
            else
            {
                cad = "Debe seleccionar un equipo para insertar uno nuevo despues.";
            }
            return cad;
        }
    }
}

