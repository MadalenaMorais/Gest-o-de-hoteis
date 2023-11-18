using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlojamento2
{
    internal class AlojamentoDAL
    {
        private const string dataFilePath = "sistemaHoteis.json";

        public List<Hotel> DesserializarHoteis()
        {
            if (File.Exists(dataFilePath))
            {
                var json = File.ReadAllText(dataFilePath);
                return JsonConvert.DeserializeObject<List<Hotel>>(json);
            }
            return new List<Hotel>();
        }

        public void SerializarHoteis(List<Hotel> listaSistemaHoteis)
        {
            var json = JsonConvert.SerializeObject(listaSistemaHoteis, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(dataFilePath, json);
        }
    }
}
