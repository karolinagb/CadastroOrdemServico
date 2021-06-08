using CadastroOrdemServico.Models;
using CadastroOrdemServico.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CadastroOrdemServico.Controllers
{
    public class OrdensServicoController : Controller
    {
        private readonly IOrdemServicoRepository _ordemServicoRepository;

        public OrdensServicoController(IOrdemServicoRepository ordemServicoRepository)
        {
            _ordemServicoRepository = ordemServicoRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(OrdemServico ordemServico)
        {
            if (ModelState.IsValid)
            {
                _ordemServicoRepository.Insert(ordemServico);
                return RedirectToAction("Index");
            }

            return View(ordemServico);
        }
    }
}
