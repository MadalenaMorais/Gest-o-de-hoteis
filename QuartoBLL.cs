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

        public void ReservarQuarto(string nomeHotel) 
        {
            var listaQuartos = DesserializarQuarto(nomeHotel);
            int idQuartoAReservar;

            //O primeiro quarto disponivel a ser encontrado é reservado (eDisponivel ---> false)
            foreach (var quarto in listaQuartos)
            {
                if(quarto.EDisponivel = true)
                {
                    idQuartoAReservar = quarto.IdQuarto;
                    if (quarto.IdQuarto == idQuartoAReservar)
                    {
                        quarto.EDisponivel = false;
                        break;
                        
                    }
                }
                else
                {
                    Console.WriteLine("Não há quartos disponiveis");
                }
               
            }
            Console.WriteLine("Quarto Reservado");
            QuartoDAL.SerializarQuartos(listaQuartos, nomeHotel);

        }

        public int EliminarQuarto(string nomeHotel) 
        {
            var listaQuartos = DesserializarQuarto(nomeHotel);
            int idQuartoAEliminar = -1; //nenhum quarto atribuido
            
            //quando é feito check in, o quarto reservado é eliminado do json
            foreach (var quarto in listaQuartos) 
            {
                if (quarto.EDisponivel == false)
                {
                    listaQuartos.Remove(quarto);
                    idQuartoAEliminar = quarto.IdQuarto;

                    Console.WriteLine("Apagado");
                    break;

                }
                else 
                {
                    Console.WriteLine("Não há quartos reservado.");
                }
            }

            QuartoDAL.SerializarQuartos(listaQuartos, nomeHotel);
            return idQuartoAEliminar;
        }

    }
        
}
