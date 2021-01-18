using System.Collections.Generic;
using System.IO;
using E_Players_AspNetCore.Interfaces;

namespace E_Players_AspNetCore.Models
{
    public class Jogador : EPlayersBase, IJogador
    {

        private const string PATH = "Database/Jogador.csv";

        public Jogador()
        {
            CreateFolderAndFile(PATH);
        }
        
        public string Prepare(Jogador P){
            return $"{P.IdJogador};{P.Nome};{P.IdEquipe}";
        }

        public int IdJogador  { get; set; } // Identificador único do jogador

        public string Nome { get; set; }
        
        public string IdEquipe { get; set; } //nome próprio, não está atrelado a equipe.cs

        // Login
        public string Email { get; set; }
        public string Senha { get; set; }

        public void Create(Jogador player)
        {
            string[] linhas = {Prepare(player)};
            File.AppendAllLines(PATH, linhas);
        }

        public void Delete(int id)
        {
            List<string> lines = new List<string>();

            //remover a linha que o código vai ser alterado
            lines.RemoveAll(x => x.Split(";")[0] == id.ToString());

            //rescreever csv alterado
            RewriteCSV(PATH, lines);
        }

        public List<Jogador> ReadAll()
        {
            List<Jogador> playerL = new List<Jogador>();

            //Ler as linhas do cscv
            string[] lines = File.ReadAllLines(PATH);

            //percorrer as linhas e adicionar na lista "playerL" cada objeto equipe
            foreach (var item in lines)
            {
                //1;Fallen;SK/id da Equipe
                string[] line = item.Split(";");

                //0 - 1
                //1 -Fallen
                //2 - SK/ Id da equipe

                //criar um objeto de jogador
                Jogador player = new Jogador();

                // atribuimos os valores no objeto
                player.IdJogador = int.Parse(line[0]);
                player.Nome = line[1];
                player.IdEquipe = line[2];

                // adicionando o jogador na lista playerL
                playerL.Add(player);
            }

            return playerL;
        }

        public void Update(Jogador playerU)
        {
            List<string> lines = new List<string>();

            //remover a linha que o código vai ser alterado
            lines.RemoveAll(x => x.Split(";")[0] == playerU.IdJogador.ToString());

            // add linha alterada no final do arquivo com o mesmo código
            lines.Add(Prepare(playerU));

            //rescreever csv alterado
            RewriteCSV(PATH, lines);
        }
    }
}