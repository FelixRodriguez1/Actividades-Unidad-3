using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDoloresHidalgo.Modelo
{
    class Pelicula
    {
        //Propiedades de la clase
        private int _id;
        private string _nombre;
        private string _director;
        private string _clasificacion;
        private string _resumen;

        //Constructor
        public Pelicula()
        {
            _clasificacion = "A";
        }

        //Metodos getter y setter
        public int Id {
            get
            {
                return _id;
            }
            set
            {

            }
        }
        public string Nombre { get; set; }
        public string Director { get; set; }
        public string Clasificacion { get; set; }
        public string Resumen { get; set; }
    }
}
