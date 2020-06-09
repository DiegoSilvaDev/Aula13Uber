namespace Uber
{
    public class Corrida
    {
        public string LocalInicio { get; set; }
        public string LocalChegada { get; set; }
        public string StatusCorrida { get; set; }
        private string Motorista { get; set; }
        private string Passageiro { get; set; }

         public string Cancelar(){
            return "Sua corrida foi cancelada";
        }
    }
}