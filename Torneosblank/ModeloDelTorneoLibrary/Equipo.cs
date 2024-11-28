using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDelTorneoLibrary
{
    class Equipo
    {
        //mio

        public String NombreClub { get; set; }
        public String Ciudad { get; set; }
        public short Num_jugadores { get; set; }
        public short Año_fundacionn { get; set; }


        public Equipo()
        {




        }

        public Equipo(String Nombre, String Ciu, short num_Jugadores, short Año_Fundacion)
        {
            Nombre = NombreClub;
            Ciu = Ciudad;
            Num_jugadores = num_Jugadores;
            Año_fundacionn = Año_Fundacion;
        }

        public string TodosDatosEquipos()
        {
            string salida = "";
            salida = "Club: " + NombreClub + " - Ciudad: " + Ciudad + " - Total de jugadores: " +
                Num_jugadores + " - Fundado: " + Año_fundacionn;
            return salida;
        }
    }
}
