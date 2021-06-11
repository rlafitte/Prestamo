using System;
using System.Collections.Generic;
using Prestamo.Entidades;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Prestamo.Datos
{
    public class PrestamoMapper
    {
        
        //Get
        public List<Prestamo> ListaPrestamos()
        {
            string json = WebHelper.Get("/877071");
            List<Prestamo> _lista = MapList(json);
            return _lista;
        }

        //MapList
        private List<Prestamo> MapList(string json)
        {
            List<Prestamo> _lista = JsonConvert.
        }
        //Post
        //ReverseMap
    }
}
