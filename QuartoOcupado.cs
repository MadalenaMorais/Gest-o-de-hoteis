using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlojamento2
{
    public class QuartoOcupado : Quarto
    {
        public QuartoOcupado(int idQuarto, string nomeHotel, int preco, string nomeCliente, int qtdNoites) : base(idQuarto, nomeHotel)
        {
            
        }
    }
}
