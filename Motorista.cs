namespace Uber
{
    public class Motorista
    {
        public string nome = "Jorge";
        private string ModeloCarro { get; set; }
        private string PlacaCarro { get; set; }

        public string AceitarCorrida( ){
                return $"Achamos sua corrida, o nome do passageiro é ";
        }
        public string ReceberPagamento(string statusCorrida){
            if(statusCorrida == "Finalizada."){
                return "Você recebeu o pagamento da corrida!";
            }

            return "O pagamento será efetuado quando a corrida for finalizada.";
        }

    }
}