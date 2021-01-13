using System.Collections.Generic;
using System.IO;

namespace E_Players_AspNetCore.Models
{
    public class EPlayersBase
    {
        public void CreateFolderAndFile(string path) //passo como argumento o elemento que irei mudar
        {
            //Database/Equipe.csv
            string folder = path.Split("/")[0];

            //verificar se a pasta existe
            if(!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);               
            }

            //verificar se o arquivo existe
            if(!File.Exists(path))
            {
                File.Create(path);
            }
        }

        public List<string> ReadAllLinesCSV(string path)
        {
            
            List<string> lines = new List<string>();

            //using -> abrir e fechar um arquivo ou conexão
            //StreamReader -> faz a leitura do csv
            using(StreamReader file = new StreamReader(path))
            {
                string line;
                while((line = file.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }

            return lines;

        }

        public void RewriteCSV(string path, List<string> lines)
        {
            //StreamWriter -> escrita de arquivos
            using(StreamWriter output = new StreamWriter(path))
            {
                foreach (var item in lines)
                {
                    output.Write(item + '\n');
                }
            }
        }
    }
}