using System;
using System.Collections.Generic;
using System.Text;
using ProyectoUTN.Domain.ValueObject;

namespace ProyectoUTN.Domain.Productos.Producto
{
    public class Producto
    {
        public string nombreProducto {get; protected set;}

        public TipoProducto tipoProducto { get; protected set; }

        public string Descripcion { get; protected set; }

        public string Marca { get; protected set; }
    }
}
