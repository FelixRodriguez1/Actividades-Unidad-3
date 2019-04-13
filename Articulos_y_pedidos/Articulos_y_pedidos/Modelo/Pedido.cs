using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articulos_y_pedidos.Modelo
{
    class Pedido
    {
        private Cliente _numCliente;
        private Cliente _dirPedido;
        private DateTime _fechaPed;
        private Articulo _numArticulo;
        private int _cantidad;                 

        public Pedido(Cliente NumCliente, Cliente direccion, DateTime fecha, Articulo NumArticulo, int cant)
        {
            _numCliente = NumCliente;
            _dirPedido = direccion;
            _fechaPed = fecha;
            _numArticulo = NumArticulo;
            _cantidad = cant;
        }

        public DateTime FechaPed
        {
            get
            {
                return _fechaPed;
            }

            set
            {
                _fechaPed = value;
            }
        }
        public int Cantidad
        {
            get
            {
                return _cantidad;
            }

            set
            {
                _cantidad = value;
            }
        }
        internal Cliente NumCliente
        {
            get
            {
                return _numCliente;
            }
            set
            {
                _numCliente = value;
            }
        }
        internal Cliente DirPedido
        {
            get
            {
                return _dirPedido;
            }

            set
            {
                _dirPedido = value;
            }
        }

        internal Articulo NumArticulo
        {
            get
            {
                return _numArticulo;
            }

            set
            {
                _numArticulo = value;
            }
        }
    }
}
