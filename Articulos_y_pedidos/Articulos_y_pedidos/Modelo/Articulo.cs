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

        public int NumArt {
            get
            {
                return _numArt;
            }
            set
            {
                _numArt = value;
            }
        }
        public string Fabrica {
            get
            {
                return _fabrica;
            }
            set
            {
                _fabrica = value;
            }
        }
        public int Existencia {
            get
            {
                return _existencia;
            }
            set
            {
                _existencia = value;
            }
        }
        public string Descripcion {
            get
            {
                return _descripcion;
            }
            set
            {
                _descripcion = value;
            }
        }

    }
}
