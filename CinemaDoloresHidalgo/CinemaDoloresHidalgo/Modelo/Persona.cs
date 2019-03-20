using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDoloresHidalgo.Modelo
{
    class Persona
    {
        //PRopiedades de la clase
        protected int _id;
        protected string _nombre;
        protected string _apellidos;
        protected string _domicilio;
        protected string _email;
        protected string _password;

        //Constructor
        public Persona()
        {
            _nombre = "Juanito";
            _apellidos = "Pérez";
        }

        public Persona(string nombre, string apellidos)
        {
            _nombre = nombre;
            _apellidos = apellidos;
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
                if (value > 0)
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
                if (value.Length >=3 && value.Length <= 30) 
                _nombre = value;
            }
        }
        public string Apellidos
        {
            get
            {
                return _apellidos;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 30)
                    _apellidos = value;
            }
        }
        public string Domicilio
        {
            get
            {
                return _domicilio;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 30)
                    _domicilio = value;
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 30)
                    _email = value;
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 30)
                    _password = value;
            }
        }
    }
}
