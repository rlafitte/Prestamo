using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Prestamo.Entidades
{
    [DataContract]
    public class TipoPrestamo
    {
        private double _tna;
        private string _linea;
        private int _id;

        public TipoPrestamo(double tna, string linea, int id)
        {
            Tna = tna;
            Linea = linea;
            Id = id;
        }
        public TipoPrestamo()
        {

        }
        [DataMember (Name = "tna")]
        public double Tna { get => _tna; set => _tna = value; }
        [DataMember (Name = "linea")]
        public string Linea { get => _linea; set => _linea = value; }
        [DataMember (Name = "id")]
        public int Id { get => _id; set => _id = value; }

        public override string ToString()
        {
            return $"ID: {this.Id} - TNA%: {this.Tna} - Linea: {this.Linea}";
        }
    }
}
