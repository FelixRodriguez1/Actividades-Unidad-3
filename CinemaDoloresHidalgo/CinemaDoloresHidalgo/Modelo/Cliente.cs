using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDoloresHidalgo.Modelo
{
    class Cliente : Persona
    {
        //propiedades de la clase
        private string _celular;

        //Constructor
        public Cliente() : base ()
        {
            _celular = "4181102345";
        }

        //Metodos getter y setter
        public string Celular
        {
            get
            {
                return _celular;
            }
            set
            {
                _celular = value;
            }
        }
    }
}
