using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articulos_y_pedidos.Modelo
{
    class InfoFabrica
    {
        private int _idFacrica;
        private string _telefonoCont;
        private List<Articulo> _listaArt;
        private string _infoCompe;

        public InfoFabrica(int fabrica, string telefono, string competencia)
        {
            _listaArt = new List<Articulo>();
            _idFacrica = fabrica;
            _telefonoCont = telefono;
            _infoCompe = competencia;
        }

        public int IdFacrica
        {
            get
            {
                return _idFacrica;
            }

            set
            {
                _idFacrica = value;
            }
        }
        public string TelefonoCont
        {
            get
            {
                return _telefonoCont;
            }

            set
            {
                _telefonoCont = value;
            }
        }

        public string InfoCompe
        {
            get
            {
                return _infoCompe;
            }

            set
            {
                _infoCompe = value;
            }
        }
    }
}