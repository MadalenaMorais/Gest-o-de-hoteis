using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlojamento2
{
    internal class QuartoDAL
    {

        public List<Quarto> DesserializarQuartos(string nomeHotel)
        {
            string dataFilePath = nomeHotel+".json";

            if (File.Exists(dataFilePath))
            {
                var json = File.ReadAllText(dataFilePath);
                return JsonConvert.DeserializeObject<List<Quarto>>(json);
               
            }
            return new List<Quarto>();
        }

        public void SerializarQuartos(List<Quarto> listaQuartos, string nomeHotel)
        {
            string dataFilePath = nomeHotel+".json";

            var json = JsonConvert.SerializeObject(listaQuartos, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(dataFilePath, json);
        }
    }
}
