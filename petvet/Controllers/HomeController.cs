using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using petvet.Models;

namespace petvet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Servico()
        {
            return View();
        }
        public IActionResult Agendamento()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Agendamento(Agenda novoAgendamento)
        {
            Dados.ConsutaAtual.Incluir(novoAgendamento);
            return View();
        }
        public IActionResult Confirmacao()
        {
            List<Agenda> petvet = Dados.ConsutaAtual.Listar();
            return View(petvet);
        }

        /*public IActionResult Confirmacao()
        {
           List<Agenda> listaAgenda = Dados.ConsutaAtual.Listar();

           return View(listaAgenda);
        }*/

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
