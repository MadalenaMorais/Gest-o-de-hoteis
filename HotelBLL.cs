using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlojamento2
{
    internal class HotelBLL
    {
        private AlojamentoDAL alojamentoDAL;

        public HotelBLL()
        {
            alojamentoDAL = new AlojamentoDAL();
        }

        public List<Hotel> DesserializarHotel()
        {
            return alojamentoDAL.DesserializarHoteis();
        }

        //Adicionar novo Hotel ao sistema ---> listaHotel é uma lista global
        public void AdicionarHotel(Hotel novoHotel)
        {
            var listaHotel = DesserializarHotel();
            listaHotel.Add(novoHotel);
            alojamentoDAL.SerializarHoteis(listaHotel);    
        }
        
        //Adicionar novo Hotel ao sistema de acordo com os input do user
        public void AdicionarHotelInput(string nomeHotel, int qtdQuartos, string nomeSistema)
        {          
            Hotel novoHotel = new Hotel (nomeHotel, qtdQuartos, nomeSistema);
            AdicionarHotel (novoHotel);
            Console.WriteLine("Hotel adicionado com sucesso!");
        }

        
        public List<Hotel> ListarHotels()
        {
            return alojamentoDAL.DesserializarHoteis();
        }

        //Eliminar um hotel em específico
        public void ElimnarHotel(string nomeHotel)
        {
            var listaHotel = DesserializarHotel ();
            
            for (int i = 0; i < listaHotel.Count; i++)
            {
                Hotel hotelAux = listaHotel[i];
                if(hotelAux.NomeHotel == nomeHotel)
                {
                    listaHotel.RemoveAt(i);
                    alojamentoDAL.SerializarHoteis (listaHotel);
                }
            }
        }

        //Eliminar todos os hoteis que pertencem a um sistema
        public void EliminarSistema(string nomeSistema)
        {
            var listaHotel = DesserializarHotel();
            for (int i = 0; i < listaHotel.Count; i++)
            {
                Hotel hotelAux = listaHotel[i];
                
                if (hotelAux.NomeSistema == nomeSistema)
                {
                    listaHotel.RemoveAt(i);   
                }                
            }

            alojamentoDAL.SerializarHoteis(listaHotel);
        }

    }

    
}
