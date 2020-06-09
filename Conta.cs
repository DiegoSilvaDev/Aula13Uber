namespace Uber
{
    public class Conta 
    {
        private string agencia { get; set; }

        private string conta { get; set; }

        public void CadastrarBank(){

            System.Console.WriteLine("Digite a sua agencia");
            System.Console.ReadLine();
            System.Console.WriteLine("Digite o numero conta");
            System.Console.ReadLine();
            System.Console.WriteLine("Sua conta foi adicionada com sucesso.");
        }

        public string Excluir(){
            return "Sua forma de pagamento foi excluida com sucesso";
        }
    }
}