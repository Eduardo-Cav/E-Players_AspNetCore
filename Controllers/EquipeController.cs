using System.IO;
using E_Players_AspNetCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Players_AspNetCore.Controllers
{
    //LocalHost:5001/Equipe
    [Route("Equipe")]
    public class EquipeController : Controller
    {
        //criamos uma instancia teamModel com a estrutura Equipe
        Equipe teamModel = new Equipe();
        
        //LocalHost:5001/Equipe/Listar
        [Route("Listar")]
        public IActionResult Index()
        {
            //listando todas as equipes e enviando para view atravé da viewBag
            ViewBag.teams = teamModel.ReadAll();
            return View();
        }

        //LocalHost:5001/Equipe/Cadastrar
        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            //criamos uma nova instacia de equipe e armazenamos os dados enviados pelo usuario 
            //através do formulário e salvamos no objeto newTeam
            Equipe newTeam = new Equipe();
            newTeam.IdEquipe = int.Parse(form["IdEquipe"]);
            newTeam.Nome = form["Nome"];
            
            //upload inicio
            // verificação se o usuario enviou um arquivo
            if (form.Files.Count > 0)
            {
                //armazenamos o arquivo na váriavel file
                var file = form.Files[0];
                            //combine = fazer uma junção de vários caminhos
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Equipes");

                //verificamos se a pasta equipe não existe
                if(!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
                                        //localhost:5001                                +Equipes + equipes.jpg (nome do arquivo que o usuário enviar?)
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", folder, file.FileName );
                                           
                                        //path = caminho onde o arquivo vai ser salvo, file mode = o que vai ser feito com o arquivo
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    //salvar arquivo no caminho especificado
                    file.CopyTo(stream);
                }

                newTeam.Imagem = file.FileName;
            }
            else
            {
                newTeam.Imagem = "padrao.png";
            }
            //upload término

            //chamamos o metódo crate para salvar a newTeam no csv
            teamModel.Create(newTeam);
            ViewBag.teams = teamModel.ReadAll();

            return LocalRedirect("~/Equipe/Listar");
        }
        //LocalHost:5001/Equipe/1
        [Route("{id}")]

        public IActionResult Excluir(int id)
        {
            teamModel.Delete(id);

            ViewBag.teams = teamModel.ReadAll();

            return LocalRedirect("~/Equipe/Listar");
        }
        
    }
}