using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDoloresHidalgo.Modelo
{
    class Reservacion
    {
        //Propiedades de la clase
        private DateTime _fecha;
        private string _numeroTarjeta;
        private Boleto _bolet;

        //Constructor
        public Reservacion(Boleto bol)
        {
            _fecha = DateTime.Now;
            _numeroTarjeta = "";
            _bolet = bol;
        }
        //Metodos getter y setter
        public DateTime Fecha { get; set; }
        public string NumeroTarjeta
        {
            get
            {
                return _numeroTarjeta;
            }
            set
            {
                _numeroTarjeta = value;
            }
        }
    }
}
