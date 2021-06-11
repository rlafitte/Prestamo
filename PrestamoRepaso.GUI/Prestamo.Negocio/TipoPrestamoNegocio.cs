using Prestamo.Datos;
using Prestamo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamo.Negocio
{
    public class TipoPrestamoNegocio
    {
        private TipoPrestamoMapper _tipoMap;
        public TipoPrestamoNegocio()
        {
            _tipoMap = new TipoPrestamoMapper();
        }

        public List<TipoPrestamo> TraerTipoPrestamos()
        {
            List<TipoPrestamo> _lista = _tipoMap.ListaTipoPrestamos();
            return _lista;
        }
    }
}
