using System;
using System.Collections.Generic;
using Prestamo.Entidades;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Specialized;

namespace Prestamo.Datos
{
    public class PrestamoMapper
    {

       
        //Get
        public List<Prestamos> ListaPrestamos()
        {
            string json = WebHelper.Get("/877071");
            List<Prestamos> _lista = MapList(json);
            return _lista;
        }

        //MapList
        private List<Prestamos> MapList(string json)
        {
            List<Prestamos> _lista = JsonConvert.DeserializeObject<List<Prestamos>>(json);
            return _lista;
        }
        //Post
        public TransactionResult AgregarPrestamo(Prestamos pre)
        {
            NameValueCollection n = ReverseMap(pre);
            string json = WebHelper.Post("", n);
            TransactionResult res  =  JsonConvert.DeserializeObject<TransactionResult>(json);
            return res;
        }

        //ReverseMap
        private NameValueCollection ReverseMap(Prestamos pre)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("id", pre.Id.ToString());
            n.Add("tna", pre.Tna.ToString());
            n.Add("linea", pre.Linea);
            n.Add("plazo", pre.Plazo.ToString());
            n.Add("idCliente", pre.IdCliente.ToString());
            n.Add("idTipo", pre.IdTipo.ToString());
            n.Add("monto", pre.Monto.ToString());
            n.Add("cuota", pre.Cuota.ToString());
            n.Add("usuario", pre.Usuario);
            n.Add("tipoPrest", pre.TipoPre.Id.ToString());
            return n;
        }

    }
}
