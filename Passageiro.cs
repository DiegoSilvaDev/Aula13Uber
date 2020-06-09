namespace Uber
{
    public class Passageiro : Usuario
    {
        public void SolicitarMotorista(){
            System.Console.WriteLine("Procurando Motorista...\n"); 
        }
        public string Pagar(string statusCorrida){
            if(statusCorrida == "finalizada"){
                return "Pagamento efetuado";
            }
            return "o Pagamento só será concluido quando a corrida for declarada finalizada.";
        } 
    }
}