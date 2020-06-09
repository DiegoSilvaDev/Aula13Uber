namespace Uber
{

    public class Usuario
    {
        // Propriedade resumida
        public string Nome { get; set; } 

        // Propriedade completa
        private int idade;
        public int Idade
        {
            get { return idade; }
            set { 
                if(idade > 0){
                    idade = value;
                }
            }
        }
       public string Foto { get; set; }

       private string login = "paulo@gmail.com";
       private string senha = "123";
       public string LocalizacaoAtual { get; set; }
       public string TokenLogin { get; set; } 
       private string TipoAcesso { get; set; }
    

       public bool Login(string login, string senha){
           if(this.login == login && this.senha == senha){
               TokenLogin = "uy23gyu42guy23g4uy324g23uyg48234t";
               return true;
           }
           return false;
       }
       public void Logout(){
           TokenLogin = "";
           System.Console.WriteLine("\nVocê foi deslogado de sua conta.");
       }


    }
}