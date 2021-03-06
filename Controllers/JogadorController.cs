using System;
using E_Players_AspNetCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Players_AspNetCore.Controllers
{
    [Route("Jogador")]
    public class JogadorController : Controller
    {
        Jogador playerModel = new Jogador();
        
        Equipe teamModel = new Equipe();
    
        public IActionResult Index()
        {
            //ViewBag como apoio e retorno para listar os jogadores disponíveis
            
            ViewBag.teams = teamModel.ReadAll();
            ViewBag.players = playerModel.ReadAll();
            return View();
        }

        [Route("CadastroPlayer")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            Jogador newPlayer = new Jogador();
            newPlayer.IdJogador = Int32.Parse(form["IdJogador"]);
            newPlayer.Nome = form["Nome"];
            newPlayer.Email = form["Email"];
            newPlayer.Senha = form["Senha"];

            playerModel.Create(newPlayer);
            ViewBag.players = playerModel.ReadAll();

            return LocalRedirect("~/Jogador");
        }
       
    
    }
}