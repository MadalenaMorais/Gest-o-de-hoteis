using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlojamento2
{
    public class Quarto
    {
        public int IdQuarto {get; set;}
        public string NomeHotel { get; set;}
        public bool EDisponivel { get; set; }

        public Quarto(int idQuarto, string nomeHotel)
        {
            IdQuarto = idQuarto;
            NomeHotel = nomeHotel;
            EDisponivel = true;
        }
    }
}
