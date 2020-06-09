namespace Uber
{
    public class Cartao
    {
        private string Titular { get; set; }
        private string NumeroCartao { get; set; }
        private string Bandeira { get; set; }
        private string CVV { get; set; }
        public string resposta;

        public void CadastrarCartao(){
            System.Console.WriteLine("\nDeseja cadastrar uma nova forma de pagamento cartão? Se for do seu interesse digite 'Sim' Caso contrário aperte Enter.\n");
            resposta = System.Console.ReadLine();
            if(resposta == "Sim"){
                System.Console.WriteLine("Digite o numero do cartão");
                NumeroCartao = System.Console.ReadLine();
                System.Console.WriteLine("Digite o Titular do Cartão");
                Titular = System.Console.ReadLine();
                System.Console.WriteLine("Digite o cvv");
                CVV = System.Console.ReadLine();

                System.Console.WriteLine($"Pronto sua forma de pagamento foi atualizada, você acaba de adicionar as formas de pagamento o seguinte cartão, com o numero: {NumeroCartao}, titular: {Titular}, e cvv {CVV}\n");
            }
                
        } 
            public string Excluir(){
                return "Esta forma de pagamento não esta mais registrada";
            }
    }
}