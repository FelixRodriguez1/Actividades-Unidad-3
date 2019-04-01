using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Actividades_1_4.Vista.Campeonato;

namespace Actividades_1_4
{
    static class Program
    {
        public static Main formaPrincipal = null;
        public static Jornada formaJornada = null;
        public static Campeonato formaCampeonato = null;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formaPrincipal = new Main();
            formaJornada = new Jornada();
            formaCampeonato = new Campeonato();
            Application.Run(formaPrincipal);
        }
    }
}
