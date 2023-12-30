using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlojamento2
{
    internal class SistemaHoteis
    {
        public string NomeSistema {  get; set; }
        public int QtdHoteis { get; set; }

        public SistemaHoteis(string nomeSistema, int qtdHoteis)
        {
            if (qtdHoteis < 0)
            {
                throw new ArgumentOutOfRangeException("A quantidade de hoteis pertencentes ao sistema não é válida");
            }
            else
            {
                QtdHoteis = qtdHoteis;
            }

            NomeSistema = nomeSistema;

            for (int i = 0; i < qtdHoteis; i++)
            {
                Console.Write("Nome do Hotel: ");
                string nomeHotel = Console.ReadLine();

                Console.WriteLine("Quantidade de Quartos: ");
                int qtdQuartos = Int32.Parse(Console.ReadLine());
                            
                Hotel novoHotel = new Hotel(nomeHotel, qtdQuartos, nomeSistema);

                HotelBLL hotelBLL = new HotelBLL();
                hotelBLL.AdicionarHotel(novoHotel);
                Console.WriteLine($"Hotel Adicionado a {nomeSistema}");
            }
        }
    }
}
