using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDoloresHidalgo.Modelo
{
    class Sala
    {
        //Propiedades de la clase
        private int _id;
        private string _nombre;
        private int _capacidad;
        private bool _estaLlena;

        //Una sala contiene 200 asientos
        private Asiento[] asientos = new Asiento[200];

        //Constructor
        public Sala()
        {
            _nombre = "A";
            for (int i = 0; i <= 199; i++)
            {
                asientos[i] = new Asiento();
                asientos[i].Numero = i + 1;
            }
        }
        public Sala(string name)
        {
            _nombre = name;
        }

        // metodos getter y setter
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
        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }
        public int Capacidad
        {
            get
            {
                return _capacidad;
            }
            set
            {
                _capacidad = value;
            }
        }
        public bool Llena
        {
            get
            {
                return _estaLlena;
            }
            set
            {
                _estaLlena = value;
            }
        }
    }
}
