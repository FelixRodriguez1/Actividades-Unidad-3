using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividades_1_4.Modelo.Campeonato
{
    class Jugador : Persona
    {
        //Atributos de la clase
        private Equipo _equipo;
        private int numero;
        private string _posicion;

        //Métodos getter y setter
        public int Numero { get; set; }
        public string Posicion { get; set; }
        public Equipo Equipo { get; set; }
    }
}
