using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividades_1_4.Modelo
{
    class Estudiante
    {
        //Propiedades de la clase
        public byte edad;
        public char genero;
        public string nombre;
        public long numeroControl;

        //Métodos getter y setter de las propiedades
        public byte Edad { get; set; }
        public char Genero { get; set; }
        public string Nombre { get; set; }
        public long NumeroControl { get; set; } 

        //
        public void Estudiar(string texto)
        {
            return;//Método para estudiark
        }//Fin del metodo estudiar
        public void hacerTarea(string texto)
        {
            return;//Método para estudiar
        }//Fin del metodo hacer tarea
    }
}
