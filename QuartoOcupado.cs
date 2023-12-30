using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlojamento2
{
    public class QuartoOcupado : Quarto
    {
        public int Preco;
        public string NomeCliente;
        public int QtdNoites;
        public QuartoOcupado(int idQuarto, string nomeHotel, string nomeCliente, int qtdNoites) : base(idQuarto, nomeHotel)
        {
            Preco= 60;
            NomeCliente= nomeCliente;
            QtdNoites= qtdNoites;
            EDisponivel = false;
        }
    }
}
