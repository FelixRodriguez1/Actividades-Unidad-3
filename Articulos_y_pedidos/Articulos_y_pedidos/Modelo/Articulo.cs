using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articulos_y_pedidos.Modelo
{
    class Articulo
    {
        protected int _numArt;
        private string _fabrica;
        private int _existencia;
        private string _descripcion;

        public int NumArt { get; set; }
        public string Fabrica { get; set; }
        public int Existencia { get; set; }
        public string Descripcion { get; set; }

    }
}
