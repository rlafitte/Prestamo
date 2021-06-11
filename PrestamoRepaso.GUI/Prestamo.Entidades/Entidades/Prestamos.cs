using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Prestamo.Entidades
{
    [DataContract]
    public class Prestamos
    {
        private int _id;
        private double _tna;
        private string _linea;
        private int _plazo;
        private int _idCliente;
        private int _idTipo;
        private double _monto;
        private double _cuota;
        private string _usuario;
        private TipoPrestamo _tipoPre;

        public Prestamos(int id, double tna, string linea, int plazo, int idCliente, int idTipo, double monto, double cuota, string usuario, TipoPrestamo tipoPre)
        {
            TipoPre = new TipoPrestamo();
            Id = id;
            Tna = tna;
            Linea = linea;
            Plazo = plazo;
            IdCliente = idCliente;
            IdTipo = idTipo;
            Monto = monto;
            Cuota = cuota;
            Usuario = usuario;
            TipoPre = tipoPre;
        }
        public Prestamos()
        {
            TipoPre = new TipoPrestamo();
        }

        [DataMember (Name = "id")]
        public int Id { get => _id; set => _id = value; }
        [DataMember (Name = "tna")]
        public double Tna { get => _tna; set => _tna = value; }
        [DataMember (Name = "linea")]
        public string Linea { get => _linea; set => _linea = value; }
        [DataMember (Name = "plazo")]
        public int Plazo { get => _plazo; set => _plazo = value; }
        [DataMember (Name = "idCliente")]
        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        [DataMember (Name = "idTipo")]
        public int IdTipo { get => _idTipo; set => _idTipo = value; }
        [DataMember (Name = "monto")]
        public double Monto { get => _monto; set => _monto = value; }
        [DataMember (Name = "cuota")]
        public double Cuota { get => _cuota; set => _cuota = value; }
        [DataMember (Name = "usuario")]
        public string Usuario { get => _usuario; set => _usuario = value; }
        [DataMember (Name = "tipoPrest")]
        public TipoPrestamo TipoPre { get => _tipoPre; set => _tipoPre = value; }

        public override string ToString()
        {
            return $"ID: {this.Id} - Tipo Prestamo {this.TipoPre.Id}";
        }
    }
}
