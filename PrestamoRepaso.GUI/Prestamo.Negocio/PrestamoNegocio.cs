using Prestamo.Datos;
using Prestamo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamo.Negocio
{
    public class PrestamoNegocio
    {
        private PrestamoMapper _preMap;
        public PrestamoNegocio()
        {
            _preMap = new PrestamoMapper();
        }

        public List<Prestamos> TraerPrestamos()
        {
            List<Prestamos> _lista = _preMap.ListaPrestamos();
            return _lista;
        }


        public void AgregarPrestamo(Prestamos p)
        {
            _preMap.AgregarPrestamo(p);

        }
    }
}
