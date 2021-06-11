using Prestamo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamo.Negocio
{
    public class Operador
    {
        private double _comision;
        private List<Prestamos> _prestamos;
        public Operador()
        {
            Comision = 0.15;
        }
        public List<Prestamos> Prestamos(List<Prestamos> lst)
        {
            Prestamos1 = lst;
            return Prestamos1;
        }

        public double Comision { get => _comision; set => _comision = value; }
        public List<Prestamos> Prestamos1 { get => _prestamos; set => _prestamos = value; }

        public string PorcentajeComsion(List<Prestamos> prestamos1, double comision)
        {

            double x = prestamos1.Sum(o => o.CuotaInteres());
            x = x * comision;
            return x.ToString("0.00");
        }
        public int ContadorPrestamos()
        {
            int i = Prestamos1.Count();
            return i;
        }

    }
}
