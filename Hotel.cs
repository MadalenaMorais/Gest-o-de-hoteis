using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlojamento2
{
    internal class Hotel
    {
        public string NomeHotel { get; set; }
        public int QtdQuartos { get; set; }
        public string NomeSistema { get; set; } //nome do sistema de hoteis a que pertence este hotel

        public Hotel(string nomeHotel, int qtdQuartos, string nomeSistema)
        {
            if (qtdQuartos < 0) 
            {
                throw new ArgumentOutOfRangeException("A quantidade de quartos não é válida");
            }
            else
            {
                QtdQuartos = qtdQuartos;
            }

            NomeHotel = nomeHotel;
            NomeSistema = nomeSistema;

            for (int i = 1; i <= qtdQuartos; i++)
            {
                Quarto novoQuarto = new Quarto(i, nomeHotel);
                QuartoBLL quartoBLL = new QuartoBLL();

                quartoBLL.AdicionarQuarto(novoQuarto, nomeHotel);
            }
        }



    }
}
