using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDoloresHidalgo.Modelo
{
    class Taquillero : Persona
    {
        private int _numeroEmpleado;
        private string _tipoEmpleado;

        public Taquillero() : base()
        {
            _numeroEmpleado = 123;
            _tipoEmpleado = "Cajero";
        }

        public int NumeroEmpleado { get; set; }
        /*{
            get
            {
                return _numeroEmpleado;
            }
            set
            {
                _numeroEmpleado = value;
            }
        }*/
        public string TipoEmpleado { get; set; }
        /*{
            get
            {
                return _tipoEmpleado;
            }
            set
            {
                _tipoEmpleado = value;
            }
        }*/
    }
}
