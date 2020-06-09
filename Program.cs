using System;

namespace Uber
{
    class Program
    {
        static void Main(string[] args)
        {
            Passageiro paulin = new Passageiro();
            Cartao masterCard = new Cartao();
            Corrida race = new Corrida();
            Usuario user = new Usuario();
            Conta bank = new Conta();

            System.Console.WriteLine("Digite seu login:");
            string login = Console.ReadLine();

            System.Console.WriteLine("Digite sua senha:");
            string senha = Console.ReadLine();

            paulin.Login(login, senha);

            if( paulin.TokenLogin != "" && paulin.TokenLogin != null ){
                
                System.Console.WriteLine("Login autorizado!");
                Console.Clear();
                inicio : 
                System.Console.WriteLine("Para efetuar alguma corrida é necessário uma forma de pagamento cadastrada, deseja pagar com sua conta bancária ou cartão? se for cartão digite [Card] e se for conta digite [Bank] se preferir dinheiro, digite [Cash].");
                switch(Console.ReadLine()){
                case "Card":
                masterCard.CadastrarCartao();
                break;
                case "Bank":
                bank.CadastrarBank();
                break;
                case "Cash":
                    System.Console.WriteLine("Valorize as moedas, elas facilitam o trocado do motorista!\n");
                break;
                default:
                    System.Console.WriteLine("\nHouve algum erro na digitação, tente novamente...\n");
                    goto inicio; 
                }

                System.Console.WriteLine("O que deseja, se quiser deslogar de sua conta digite [Logout], se deseja solicitar um motorista digite [Race]\n");
                switch(System.Console.ReadLine()){
                case"Logout":
                    user.Logout();
                break;
                case"Race":
                    paulin.SolicitarMotorista();
                break;
                default:
                    System.Console.WriteLine("\nHouve algum erro na digitação, desligando...");
                break;
                }
                
                System.Console.WriteLine("Digite sua localização atual: ");
                race.LocalInicio = Console.ReadLine();
                System.Console.WriteLine("Digite o destino final da viagem: ");
                race.LocalChegada = Console.ReadLine();

                race.StatusCorrida = "em adamento";
                System.Console.WriteLine($"\nCorrida {race.StatusCorrida} e {paulin.Pagar(race.StatusCorrida)}");
                





            }else{
                System.Console.WriteLine("Login não foi efetuado, tente novamente.");
            }
        }
    }
}
