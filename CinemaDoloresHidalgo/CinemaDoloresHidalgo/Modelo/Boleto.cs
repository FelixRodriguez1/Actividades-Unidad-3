using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDoloresHidalgo.Modelo
{
    class Boleto
    {
        //Propiedades de la clase
        private long _folio;
        private DateTime _fecha;
        private int _asiento;
        private double _costo;

        //Constructor
        public Boleto()
        {
            _folio = 0;
            _fecha = DateTime.Now;
            _asiento = 0;
            _costo = 0.0;
        }

        //Metodos getter y setter
        public long Folio
        {
            get
            {
                return _folio;
            }
            set
            {
                _folio = value;
            }
        }
        public DateTime Fecha { get; set; }
        public int Asiento
        {
            get
            {
                return _asiento;
            }
            set
            {
                _asiento = value;
            }
        }
        public double Costo
        {
            get
            {
                return _costo;
            }
            set
            {
                _costo = value;
            }
        }
    }
}
