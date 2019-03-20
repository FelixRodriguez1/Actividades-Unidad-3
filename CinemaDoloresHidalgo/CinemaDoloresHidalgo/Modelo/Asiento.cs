using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDoloresHidalgo.Modelo
{
    class Asiento
    {
        private int _numero;
        private bool _estaDisponible;

        public Asiento()
        {
            _numero = 1;
            _estaDisponible = false;
        }

        public Asiento(int num, bool disponible)
        {
            _numero = num;
            _estaDisponible = disponible;
        }
        /*crear asiento
         * Asiento a1 = new Asiento();
         * a1.Numero = 1;
         * a1.EstaDisponible;
         * */
        public bool Disponibilidad { get; set; }
        public int Numero { get; set; }
    }
}
