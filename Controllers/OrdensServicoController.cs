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
            var ordensServico = _ordemServicoRepository.FindAll();
            return View(ordensServico);
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

        public ActionResult Edit(int? id)
        {
            var model = _ordemServicoRepository.GetById(id.Value);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(OrdemServico ordemServico)
        {
            if (ModelState.IsValid)
            {
                _ordemServicoRepository.Update(ordemServico);
                return RedirectToAction("Index");
            }

            return View(ordemServico);
        }
    }
}
