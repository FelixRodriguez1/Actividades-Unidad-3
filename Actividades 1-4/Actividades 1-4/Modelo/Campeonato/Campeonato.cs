using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividades_1_4.Modelo.Campeonato
{
    class Campeonato
    {
        private int _id;
        private string _nombre;
        private DateTime _fechaInicio;
        private DateTime _fechaTermino;
        private Jornada[] jor = new Jornada[20];
        private List<Jornada> _jor = new List<Jornada>();

        public Campeonato()
        {
            _id = 0;
            _nombre = "nombre";
            for (int i=0;i <=19 ;i++)
            {
                jor[i] = new Jornada();
                jor[i].Id= i + 1;
            }
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaTermino { get; set; }
        public List<Jornada> Jor { get; set; }
    }
}
