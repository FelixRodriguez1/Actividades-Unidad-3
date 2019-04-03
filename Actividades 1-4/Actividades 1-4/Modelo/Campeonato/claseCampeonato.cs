using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividades_1_4.Modelo.Campeonato
{
    class claseCampeonato
    {
        private int _id;
        private string _nombre;
        private DateTime _fechaInicio;
        private DateTime _fechaTermino;
        private Jornada[] jor = new Jornada[20];
        private List<Jornada> _jor = new List<Jornada>();

        public claseCampeonato()
        {
            _id = 1;
            for (int i=0;i <=19 ;i++)
            {
                jor[i] = new Jornada();
                jor[i].Id= i + 1;
            }
        }
        public claseCampeonato(string nombre) //constructor sobrecargado que acepta el nombre del campeonato
        {
            _nombre = nombre;
        }
        public claseCampeonato(string nombre, DateTime fechaInicio, DateTime fechaFin) //constructor sobrecargado que acepta nombre, fecha inicio y fecha fin
        {
            _nombre = nombre;
            _fechaInicio = fechaInicio;
            _fechaTermino = fechaFin;
        }

        public int Id {
            get
            {
                return _id;
            }
            set
            {
                if (value > 0) //validar que id sea mayor a 0
                    _id = value;
            }
        }
        public string Nombre {
            get
            {
                return _nombre;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 50)
                    _nombre = value;
            }
        }
        public DateTime FechaInicio {
            get
            {
                return _fechaInicio;
            }
            set
            {
                if (value > DateTime.Today) //validar que la fecha es mayor a hoy
                    _fechaInicio = value;
            }
        }
        public DateTime FechaTermino {
            get
            {
                return _fechaTermino;
            }
            set
            {
                if (value > DateTime.Today)
                    _fechaTermino = value;
            }
        }
        public List<Jornada> Jor { get; set; }

        public override string ToString()
        {
            return _id + "|" + _nombre + "|" + _fechaInicio.ToString ("dd/MM/yyyy") + "|" + _fechaTermino.ToString("dd/MM/yyyy");
        }
    }
}
