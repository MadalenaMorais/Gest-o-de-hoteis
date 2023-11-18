using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlojamento2
{
    public class QuartoBLL
    {
        private QuartoDAL QuartoDAL;

        public QuartoBLL()
        {
            QuartoDAL = new QuartoDAL();
        }

        public List<Quarto> DesserializarQuarto(string nomeHotel)
        {
            return QuartoDAL.DesserializarQuartos(nomeHotel);
        }

        public void AdicionarQuarto(Quarto novoQuarto, string nomeHotel)
        {
            var listaQuartos = DesserializarQuarto(nomeHotel);
            listaQuartos.Add(novoQuarto);
            QuartoDAL.SerializarQuartos(listaQuartos, nomeHotel);
        }

    }
        
}
