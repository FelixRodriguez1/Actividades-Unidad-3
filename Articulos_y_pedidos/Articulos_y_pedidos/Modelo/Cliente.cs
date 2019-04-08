using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articulos_y_pedidos.Modelo
{
    class Cliente
    {
        protected int _numCli;
        protected string _direccion;
        private double _saldo;
        private double _linCre;
        private double _descuento;

        public int NumCli { get; set; }
        public string Direccion { get; set; }
        public double Saldo { get; set; }
        public double LinCre { get; set; }
        public double Descuento { get; set}
    }
}
