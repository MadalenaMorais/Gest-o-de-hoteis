namespace GestaoAlojamento2
{
    internal class Program
    {
        public static List<Hotel> listaHotel = new List<Hotel>();
        
        

        static void Main(string[] args)
        {

            //var hotelBLL = new HotelBLL();
            SistemaHoteis sistemaTeste = new SistemaHoteis("Hoteis zona norte", 2);
            //List<Hotel> listaHotel2 = sistemaTeste.GetAllHotel(listaHotel);




            //MostrarHoteis(hotelBLL.ListarHotels());


            //hotelBLL.AdicionarHotelInput("Hotel0", 52, "NomeDoSistema");
            //hotelBLL.AdicionarHotelInput("Hotel1", 52, "NomeDoSistema");
            //hotelBLL.AdicionarHotelInput("Hotel2", 52, "NomeDoSistema");


            //hotelBLL.ElimnarHotel("NovoHotelAula");
            //hotelBLL.EliminarSistema("NomeDoSistema");
            //MostrarHoteis(hotelBLL.ListarHotels());

            
            

        }

        //Metodo para listar todos os hoteis gravados no ficheiro
        static void MostrarHoteis(List<Hotel> hotels)
        {
            Console.WriteLine("Lista de hOTELS:");
            foreach (var hotel in hotels)
            {
                Console.WriteLine($"{hotel.QtdQuartos}: {hotel.NomeHotel}: {hotel.NomeSistema}");
            }
        }


    }


}

