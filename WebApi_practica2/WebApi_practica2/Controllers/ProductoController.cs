using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Producto.DAL;
using Producto.Entities2;

namespace WebApi_practica2.Controllers
{
    public class ProductoController : ApiController
    {


        Datos datos = new Datos();

        List<Producto.Entities2.Producto2> DatosProductos;
        [HttpGet]

        public List<Producto.Entities2.Producto2> ListaProductos()
        {

            DatosProductos = datos.ListaProductos();

            datos.LiberarConexion();
            return DatosProductos;


        }







    }
}
