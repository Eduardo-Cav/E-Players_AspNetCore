using System.Collections.Generic;
using System.IO;
using E_Players_AspNetCore.Interfaces;

namespace E_Players_AspNetCore.Models
{
    public class Equipe : EPlayersBase, IEquipe
    {
        //ID - Identificador único (fazer alterações, busca)

        public int IdEquipe { get; set; }
       
        public string Nome { get; set; }
        
        public string Imagem { get; set; }

        private const string PATH = "Databse/Equipe.csv";

        public Equipe()
        {
            CreateFolderAndFile(PATH);
        }
        
        public string Prepare(Equipe teamP){
            return $"{teamP.IdEquipe};{teamP.Nome};{teamP.Imagem}";
        }

        public void Create(Equipe teamC)
        {
            string[] linhas = {Prepare(teamC)};
            File.AppendAllLines(PATH, linhas);
        }

        public List<Equipe> ReadAll()
        {
            List<Equipe> teams = new List<Equipe>();

            //Ler as linhas do cscv
            string[] lines = File.ReadAllLines(PATH);

            //percorrer as linhas e adicionar na lista "teams" cada objeto equipe
            foreach (var item in lines)
            {
                //1;SKgamind;SK.jpg
                string[] line = item.Split(";");

                //0 - 1
                //1 -SKgaming
                //2 - SK.jpg

                //criar um objeto de equipe
                Equipe team = new Equipe();

                // atribuimos os valores no objeto
                team.IdEquipe = int.Parse(line[0]);
                team.Nome = line[1];
                team.Imagem = line[2];

                // adicionando a equipe na lista teams
                teams.Add(team);
            }

            return teams;
        }
        
        public void Update(Equipe teamU)
        {
            List<string> lines = new List<string>();

            //remover a linha que o código vai ser alterado
            lines.RemoveAll(x => x.Split(";")[0] == teamU.IdEquipe.ToString());

            // add linha alterada no final do arquivo com o mesmo código
            lines.Add(Prepare(teamU));

            //rescreever csv alterado
            RewriteCSV(PATH, lines);
        }
        
        public void Delete(int id)
        {
            List<string> lines = new List<string>();

            //remover a linha que o código vai ser alterado
            lines.RemoveAll(x => x.Split(";")[0] == id.ToString());


            //rescreever csv alterado
            RewriteCSV(PATH, lines);
        }


    }
}