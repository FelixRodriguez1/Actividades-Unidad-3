using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDoloresHidalgo.Modelo
{
    class Cartelera
    {
        //Propiedades de la clase
        private int _id;
        private DateTime _fecha;
        private string _horario;
        private string _tipo;

        //constructor
        public Cartelera()
        {
            _id = 0;
            _fecha = DateTime.Now;
            _horario = "";
            _tipo = "";
        }

        //Metodos getter y setter
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public DateTime Fecha { get; set; }
        public string Horario
        {
            get
            {
                return _horario;
            }
            set
            {
                _horario = value;
            }
        }

        public string Tipo
        {
            get
            {
                return _tipo;
            }
            set
            {
                _tipo = value;
            }
        }
    }
}
