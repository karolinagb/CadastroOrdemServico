using CadastroOrdemServico.Models;
using CadastroOrdemServico.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroOrdemServico.Controllers
{
    public class OrdensServicoController : Controller
    {
        private readonly IOrdemServicoRepository _ordemServicoRepository;

        public OrdensServicoController(IOrdemServicoRepository ordemServicoRepository)
        {
            _ordemServicoRepository = ordemServicoRepository;
        }

        public ActionResult Index(string sortOrder)
        {
            ViewData["NumeroSortParm"] = String.IsNullOrEmpty(sortOrder) ? "numero_desc" : "";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";

            var ordensServico = _ordemServicoRepository.FindAll();

            switch (sortOrder)
            {
                case "numero_desc":
                    ordensServico = ordensServico.OrderByDescending(s => s.Numero).ToList();
                    break;
                case "Date":
                    ordensServico = ordensServico.OrderBy(s => s.Data).ToList();
                    break;
                case "date_desc":
                    ordensServico = ordensServico.OrderByDescending(s => s.Data).ToList();
                    break;
                default:
                    ordensServico = ordensServico.OrderBy(s => s.Numero).ToList();
                    break;
            }
            return View(ordensServico);
        }

        //public IActionResult Index()
        //{
        //    var ordensServico = _ordemServicoRepository.FindAll();
        //    return View(ordensServico);
        //}

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

                TempData["Message"] = "Ordem de serviço criada com sucesso";
                TempData["ColorMessage"] = "success";

                return RedirectToAction("Index");
            }

            return View(ordemServico);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido"});
            }

            var model = _ordemServicoRepository.GetById(id.Value);

            if(model == null)
            {
                return RedirectToAction("Error", new { message = "Ordem de Serviço não encontrada" });
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(OrdemServico ordemServico, int id)
        {
            if(id != ordemServico.Id)
            {
                return RedirectToAction("Error", new { message = "Id não corresponde a Ordem de Serviço" });
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _ordemServicoRepository.Update(ordemServico);

                    TempData["Message"] = "Edição salva com sucesso";
                    TempData["ColorMessage"] = "success";

                    return RedirectToAction("Index");
                }
                catch (Exception)
                {
                    return RedirectToAction("Error", new { message = "Ocorreu um erro ao tentar realizar essa ação" });
                }
            }

            return View(ordemServico);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido" });
            }

            var model = _ordemServicoRepository.GetById(id.Value);

            if (model == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Ordem de Serviço não encontrada" });
            }

            return View(model);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido" });
            }

            var model = _ordemServicoRepository.GetById(id.Value);

            if (model == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Ordem de Serviço não encontrada" });
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(OrdemServico ordemServico, int id)
        {
            if (id != ordemServico.Id)
            {
                return RedirectToAction("Error", new { message = "Id não corresponde a Ordem de Serviço" });
            }

            try
            {
                _ordemServicoRepository.Remove(id);

                TempData["Message"] = "Ordem de serviço excluída";
                TempData["ColorMessage"] = "success";

                return RedirectToAction("Index");

            }
            catch (Exception)
            {
                return RedirectToAction("Error", new { message = "Ocorreu um erro ao tentar realizar essa ação" });
            }

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public ActionResult Error(string message)
        {
            return View(new ErrorViewModel { Message = message, RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
