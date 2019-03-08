using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividades_1_4.Modelo.Campeonato
{
    class Arbitro : Persona //herencia
    {
        //Atributos
        private int _aniosExperiencia;
        private bool _tieneGafete;

        //Métodos getter y setter
        public int AniosExperiencia { get; set; }
        public bool TieneGafete { get; set;}
    }
}
