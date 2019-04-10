using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articulos_y_pedidos.Modelo
{
    class Pedido
    {
        private Cliente cabecera;
        private Articulo cuerpo;
        
        public Cliente Cabecera { get; set; }
        public Articulo Cuerpo { get; set; }

    }
}
