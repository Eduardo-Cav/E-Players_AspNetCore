namespace E_Players_AspNetCore.Models
{
    public class Jogador
    {
        
        public int IdJogador  { get; set; } // Identificador único do jogador

        public string Nome { get; set; }
        
        public string IdEquipe { get; set; } //nome próprio, não está atrelado a equipe.cs
        
              
        
    }
}