using App.ViewModels;
using AutoMapper;
using Business.Models;
using Business.Services;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class FornecedoresController : Controller
    {
        private readonly FornecedorService _fornecedorService;
        private readonly IMapper _mapper;

        public FornecedoresController(FornecedorService fornecedorService, IMapper mapper)
        {
            _fornecedorService = fornecedorService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var listaFornecedores = _mapper.Map<List<FornecedorViewModel>>(await _fornecedorService.ObterTodos());
            return View(listaFornecedores);
        }

        public IActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Adicionar(FornecedorViewModel fornecedorViewModel)
        {
            await _fornecedorService.Adicionar(_mapper.Map<Fornecedor>(fornecedorViewModel));
            return RedirectToAction(nameof(Index));
        }
    }
}
