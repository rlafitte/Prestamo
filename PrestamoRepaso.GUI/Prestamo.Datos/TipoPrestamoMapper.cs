using Newtonsoft.Json;
using Prestamo.Entidades;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamo.Datos
{
    public class TipoPrestamoMapper
    {
        //Get
        public List<TipoPrestamo> ListaTipoPrestamos()
        {
            string json = WebHelper.Get("tipo");
            List<TipoPrestamo> _lista = MapList(json);
            return _lista;
        }

        //MapList
        private List<TipoPrestamo> MapList(string json)
        {
            List<TipoPrestamo> _lista = JsonConvert.DeserializeObject<List<TipoPrestamo>>(json);
            return _lista;
        }
        //Post
        //public TransactionResult AgregarPrestamo(TipoPrestamo tipoPre)
        //{
        //    NameValueCollection n = ReverseMap(tipoPre);
        //    string json = WebHelper.Post("", n);
        //    TransactionResult res = JsonConvert.DeserializeObject<TransactionResult>(json);
        //    return res;
        //}

        ////ReverseMap
        //private NameValueCollection ReverseMap(TipoPrestamo pre)
        //{
        //    NameValueCollection n = new NameValueCollection();
        //    n.Add("id", pre.Id.ToString());
        //    n.Add("tna", pre.Tna.ToString());
        //    n.Add("linea", pre.Linea);
        //    n.Add("plazo", pre.Plazo.ToString());
        //    n.Add("idCliente", pre.IdCliente.ToString());
        //    n.Add("idTipo", pre.IdTipo.ToString());
        //    n.Add("monto", pre.Monto.ToString());
        //    n.Add("cuota", pre.Cuota.ToString());
        //    n.Add("tipoPrest", pre.TipoPre.ToString());
        //    return n;
        //}
    }
}
