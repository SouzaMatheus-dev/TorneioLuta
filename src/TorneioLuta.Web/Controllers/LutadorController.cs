using Microsoft.AspNetCore.Mvc;
using TorneioLuta.Dominio.Interfaces.Servicos;

namespace TorneioLuta.Web.Controllers
{
    public class LutadorController : Controller
    {
        private readonly ILogger<LutadorController> _logger;
        private readonly ILutadoresServico _servico;

        public LutadorController(ILogger<LutadorController> logger,
            ILutadoresServico servico)
        {
            _logger = logger;
            _servico = servico;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var requestLutadores = await _servico.BuscaTodosLutadoresAsync();
            //Pegar retorno dos lutadores e converter em uma viewModel

            return View(requestLutadores);
        }
    }
}