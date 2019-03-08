using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividades_1_4.Modelo.Campeonato
{
    class Equipo
    {
        //Propiedades de la clase
        private int _id;
        private string _nombre;
        private string _entrenador;
        private string _comunidad;

        //Enlace con jugador
        private List<Jugador> jugadores = new List<Jugador>();

        //Métodos getter y setter
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Entrenador { get; set; }
        public int Comunidad { get; set; }

    }
}
