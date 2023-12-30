using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlojamento2
{
    public class QuartoOcupadoBLL
    {
        private QuartoOcupadoDAL QuartoOcupadoDAL;

        public QuartoOcupadoBLL()
        {
            QuartoOcupadoDAL = new QuartoOcupadoDAL();
        }

        public List<QuartoOcupado> DesserializarQuartoOcupados(string nomeHotel)
        {
            return QuartoOcupadoDAL.DesserializarQuartos(nomeHotel);
        }

        public void AdicionarQuarto(QuartoOcupado novoQuarto, string nomeHotel)
        {
            var listaQuartos = DesserializarQuartoOcupados(nomeHotel);
            listaQuartos.Add(novoQuarto);
            QuartoOcupadoDAL.SerializarQuartosOcupados(listaQuartos, nomeHotel);
        }

        public void CheckIn(string nomeHotel, string nomeCliente, int qtdNoites)
        {
            //É eliminado um quartoBLL e criado um quartoOcupadoBLL com o mesmo número de quarto
            QuartoBLL quartoBLL = new QuartoBLL();
            int idQuarto = quartoBLL.EliminarQuarto(nomeHotel);

            QuartoOcupado novoQuarto = new QuartoOcupado(idQuarto, nomeHotel, nomeCliente, qtdNoites);
            AdicionarQuarto(novoQuarto, nomeHotel);
            Console.WriteLine($"Check-in realizado com sucesso no quarto {idQuarto}!");
            
        }

        public void EliminarQuartoOcupado(int idquarto, string nomeHotel)
        {
            var listaQuartosOcupados = DesserializarQuartoOcupados(nomeHotel);
            
            foreach (var quartoOcupado in listaQuartosOcupados)
            {
                if (quartoOcupado.IdQuarto == idquarto)
                {
                    listaQuartosOcupados.Remove(quartoOcupado);
                    
                    Console.WriteLine("Apagado");
                    break;

                }
                else
                {
                    Console.WriteLine("Esse quarto não foi ocupado.");
                }
            }

            QuartoOcupadoDAL.SerializarQuartosOcupados(listaQuartosOcupados, nomeHotel);
           
        }

        public int CalcularEstadia(string nomeHotel, int idQuarto)
        {
            int valor = 0;
            var listaQuartosOcupados = DesserializarQuartoOcupados(nomeHotel);

            foreach (var quartoOcupado in listaQuartosOcupados)
            {
                if (quartoOcupado.IdQuarto == idQuarto)
                {
                    valor = quartoOcupado.Preco * quartoOcupado.QtdNoites;

                    Console.WriteLine($"O preço da estadia é {valor}. ");
                } 
            }

                return valor;
        }

        public void CheckOut(string nomeHotel, int idQuarto)
        {
            //Calcular valor a pagar pela estadia
            CalcularEstadia(nomeHotel, idQuarto);
            //É elimiando un quartoOcupado e criado um quartoBLL
            EliminarQuartoOcupado(idQuarto, nomeHotel);

            Quarto quartoLivre = new Quarto(idQuarto, nomeHotel);

            QuartoBLL quartoBLL = new QuartoBLL();
            quartoBLL.AdicionarQuarto(quartoLivre, nomeHotel);
            Console.WriteLine("Check-out realizado com sucesso!");

        }

        

        

    }
        
}
