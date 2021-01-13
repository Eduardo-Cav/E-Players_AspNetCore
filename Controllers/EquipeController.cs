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
            newTeam.Imagem = form["Imagem"];

            //chamamos o metódo crate para salvar a newTeam no csv
            teamModel.Create(newTeam);
            ViewBag.teams = teamModel.ReadAll();

            return LocalRedirect("~/Equipe/Listar");

        }
    }
}