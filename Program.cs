using System;
using System.Data;

namespace GestaoAlojamento2
{
    internal class Program
    {
        public static List<Hotel> listaHotel = new List<Hotel>();


        static void Main(string[] args)
        {
            var hotelBLL = new HotelBLL();
            var quartoBLL = new QuartoBLL();
            var quartoOcupadoBLL = new QuartoOcupadoBLL();

            while (true)
            {
                MainMenu();

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        {
                            MenuSistema();
                            int opcaoS = int.Parse(Console.ReadLine());
                            switch (opcaoS)
                            {
                                case 1:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Qual o nome do Sistema de Hoteis?");
                                        string nomeSistema = Console.ReadLine();
                                        Console.WriteLine("Quantos hoteis terá o sistema?");
                                        try
                                        {
                                            int qtdHoteis = int.Parse(Console.ReadLine());
                                            SistemaHoteis novoSistemaHoteis = new SistemaHoteis(nomeSistema, qtdHoteis);
                                        }
                                        catch (FormatException)
                                        {
                                            Console.WriteLine("Quantidade não valida.");
                                        }
                                        
                                        break;
                                    }

                                case 2:
                                    {
                                        Console.Clear();
                                        MostrarHoteis(hotelBLL.ListarHotels());
                                        Console.WriteLine("Qual o sistema que deseja apagar?");
                                        string nomeSistema = Console.ReadLine();
                                        hotelBLL.EliminarSistema(nomeSistema);

                                        break;
                                    }
                                case 3:
                                    {
                                        Console.Clear();

                                        break;
                                    }
                                case 0:
                                    {
                                        Environment.Exit(0);
                                        break;
                                    }

                                default:
                                    Console.WriteLine("Opção inválida.");
                                    break;

                            }

                            break;
                        }
                    case 2:
                        {
                            MenuHotel();
                            int opcaoH = int.Parse(Console.ReadLine());
                            switch (opcaoH)
                            {
                                case 1:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Em que sistema quer adicionar o hotel?");
                                        string nomeSistema = Console.ReadLine();
                                        Console.WriteLine("Qual o nome do Hotel?");
                                        string nomeHotel = Console.ReadLine();
                                        Console.WriteLine("Quantos quartos tem o hotel?");
                                        try
                                        {
                                            int qtdQuartos = int.Parse(Console.ReadLine());
                                            hotelBLL.AdicionarHotelInput(nomeHotel, qtdQuartos, nomeSistema);
                                        }
                                        catch (FormatException)
                                        {
                                            Console.WriteLine("Quantidade não valida.");
                                        }
                      
                                        break;
                                    }

                                case 2:
                                    {
                                        Console.Clear();
                                        MostrarHoteis(hotelBLL.ListarHotels());
                                        Console.WriteLine("Qual o hotel que deseja apagar?");
                                        string nomeHotel = Console.ReadLine();

                                        hotelBLL.EliminarHotel(nomeHotel);

                                        break;
                                    }
                                case 3:
                                    {
                                        Console.Clear();

                                        break;
                                    }
                                case 0:
                                    {
                                        Environment.Exit(0);
                                        break;
                                    }

                                default:
                                    Console.WriteLine("Opção inválida.");
                                    break;

                            }
                            break;
                        }
                    case 3:
                        {
                            MenuQuarto();
                            int opcaoQ = int.Parse(Console.ReadLine());
                            switch (opcaoQ)
                            {
                                case 1:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Em que hotel deseja ficar hospedado?");
                                        string nomeHotel = Console.ReadLine();
                                        quartoBLL.ReservarQuarto(nomeHotel);

                                        break;
                                    }

                                case 2:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Em que hotel deseja fazer o check-in?");
                                        string nomeHotel = Console.ReadLine();
                                        Console.WriteLine("Qual o nome do cliente?");
                                        string nomeCliente = Console.ReadLine();
                                        Console.WriteLine("Quantas noites irá ficar hospedado?");
                                        try
                                        {
                                            int qtdNoites = int.Parse(Console.ReadLine());
                                            quartoOcupadoBLL.CheckIn(nomeHotel, nomeCliente, qtdNoites);
                                        }
                                        catch (FormatException)
                                        {
                                            Console.WriteLine("Quantidade não valida.");
                                        }
                         
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Qual o nome do hotel?");
                                        string nomeHotel= Console.ReadLine();
                                        Console.WriteLine("Qual o numero do quarto?");
                                        try
                                        {
                                            int idQuarto = int.Parse(Console.ReadLine());
                                            quartoOcupadoBLL.CheckOut(nomeHotel, idQuarto);
                                        }
                                        catch (FormatException)
                                        {
                                            Console.WriteLine("O número do quarto não é valido.");
                                        }

                                        break;
                                    }
                                case 4:
                                    {
                                        Console.Clear();

                                        break;
                                    }

                                case 0:
                                    {
                                        Environment.Exit(0);
                                        break;
                                    }

                                default:
                                    Console.WriteLine("Opção inválida.");
                                    break;
                            }
                                    break;
                        }
                    case 4:
                        Console.Clear();
                        MostrarHoteis(hotelBLL.ListarHotels());
                        

                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }


        }


          static void MainMenu()
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Gerir Sistema Hoteis.");
            Console.WriteLine("2 - Gerir Hoteis");
            Console.WriteLine("3 - Gerir Quartos");
            Console.WriteLine("4 - Mostar Registos");
            Console.WriteLine("0 - Para sair.");
        }

        static void MenuSistema()
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Adiconar um novo Sistema de Hoteis");
            Console.WriteLine("2 - Apagar um Sistema de Hoteis");
            Console.WriteLine("3 - Voltar ao menu principal");
            Console.WriteLine("0 - Para sair.");
        }

        static void MenuHotel()
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Adiconar um novo Hotel");
            Console.WriteLine("2 - Apagar um Hotel");
            Console.WriteLine("3 - Voltar ao menu principal");
            Console.WriteLine("0 - Para sair.");
        }

        static void MenuQuarto()
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Reservar Quarto");
            Console.WriteLine("2 - Fazer check-in");
            Console.WriteLine("3 - Fazer check-out");
            Console.WriteLine("4 - Voltar ao menu principal");
            Console.WriteLine("0 - Para sair.");

        }
        
        //Metodo para listar todos os hoteis gravados no ficheiro
        static void MostrarHoteis(List<Hotel> hotels)
        {
            Console.WriteLine("Lista de hOTELS:");
            Console.WriteLine("Qtd Quartos/ Nome Hotel/ Nome Sistema");
            foreach (var hotel in hotels)
            {
                Console.WriteLine($"{hotel.QtdQuartos}: {hotel.NomeHotel}: {hotel.NomeSistema}");
            }
        }

        //Metodo para listar os quartos do hotel gravados no ficheiro
        static void MostrarQuartos (List<Quarto> quartos)
        {
            foreach (var quarto in quartos)
            {
                Console.WriteLine($"{quarto.IdQuarto}: {quarto.EDisponivel}");
            }
        }


    }


}

