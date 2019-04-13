using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articulos_y_pedidos.Modelo
{
    class Cliente
    {
        private int _numCli;
        private string _direccion;
        private int _dirNum;
        private string _calle;
        private string _colonia;
        private string _cuidad;
        private double _saldo;
        private double _linCre;
        private double _descuento;

        public Cliente(int numero, string dir, int numDireccion, string calle, string colonia, string cuidad, double saldo, double limite, double descuento)
        {
            _numCli = numero;
            _direccion = dir;
            _dirNum = numDireccion;
            _calle = calle;
            _colonia = colonia;
            _cuidad = cuidad;
            _saldo = saldo;
            _linCre = limite;
            _descuento = descuento;
        }

        public int NumCli {
            get
            {
                return _numCli;
            }
            set
            {
                _numCli = value;
            }
        }
        public string Direccion {
            get
            {
                return _direccion;
            }
            set
            {
                _direccion = value;
            }
        }
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                _saldo = value;
            }
        }
        public double LinCre {
            get
            {
                return _linCre;
            }
            set
            {
                if (value > 10000.000)
                {
                    _linCre = value;
                }
            }
        }
        public double Descuento {
            get
            {
                return _descuento;
            }
            set
            {
                _descuento = value;
            }
        }
    }
}
