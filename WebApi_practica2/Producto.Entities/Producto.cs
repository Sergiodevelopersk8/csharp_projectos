using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Producto.DAL;
using System.Configuration;
using System.Data.Sql;
using System.Data.SqlTypes;
using Microsoft.SqlServer;

//using Microsoft.IdentityModel.Protocols;

namespace Producto.Entities
{
    public class Producto
    {
        public int Id_Producto { set; get; }


        public string Nombre_Producto { set; get; }
        public string Descripcion_Producto { set; get; }
        public string mensaje { set; get; }





    }
}
