﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamo.Entidades
{
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
        public double Tna { get => _tna; set => _tna = value; }
        public string Linea { get => _linea; set => _linea = value; }
        public int Id { get => _id; set => _id = value; }

        public override string ToString()
        {
            return $"ID: {this.Id} - TNA%: {this.Tna}";
        }
    }
}
