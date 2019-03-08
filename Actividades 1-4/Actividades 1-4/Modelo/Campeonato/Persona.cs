using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividades_1_4.Modelo.Campeonato
{
    class Persona
    {
        //Propiedades de la clase
        protected int _id;
        protected string _nombre;
        protected string _apellidos;
        protected DateTime _fechaNacimiento;
        
        //Métodos getter y setter
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
