using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlojamento2
{
    internal class QuartoOcupadoDAL
    {

        public List<QuartoOcupado> DesserializarQuartos(string nomeHotel)
        {
            string dataFilePath = nomeHotel+"Ocupado.json";

            if (File.Exists(dataFilePath))
            {
                var json = File.ReadAllText(dataFilePath);
                return JsonConvert.DeserializeObject<List<QuartoOcupado>>(json);
               
            }
            return new List<QuartoOcupado>();
        }

        public void SerializarQuartosOcupados(List<QuartoOcupado> listaQuartos, string nomeHotel)
        {
            string dataFilePath = nomeHotel+"Ocupado.json";

            var json = JsonConvert.SerializeObject(listaQuartos, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(dataFilePath, json);
        }
    }
}
