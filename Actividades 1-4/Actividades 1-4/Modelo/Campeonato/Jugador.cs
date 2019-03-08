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
        private int numero;
        private string _posicion;

        //Enlace con la clase Equipo
        private Equipo _equipe;

        //Métodos getter y setter
        public int Numero { get; set; }
        public string Posicion { get; set; }
        public Equipo Equipe { get; set; }
    }
}
