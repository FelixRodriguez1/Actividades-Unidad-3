using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDoloresHidalgo.Modelo
{
    class Asiento
    {
        //Propiedades de la clase
        private int _numero;
        private bool _estaDisponible;

        //constructor
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
         //Metodos getter y setter
        public bool EstaDisponible { get; set; }
        public int Numero { get; set; }
    }
}
