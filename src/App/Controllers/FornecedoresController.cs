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

        public async Task<IActionResult> Visualizar(int id)
        {
            var fornecedor = _mapper.Map<FornecedorViewModel>(await _fornecedorService.ObterPorId(id));

            if (fornecedor == null) return NotFound();

            return View(fornecedor);
        }
        
        public async Task<IActionResult> Editar(int id)
        {
            var fornecedor = _mapper.Map<FornecedorViewModel>(await _fornecedorService.ObterPorId(id));
            return View(fornecedor);
        }        

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(FornecedorViewModel fornecedorViewModel)
        {
            var fornecedor = _mapper.Map<Fornecedor>(fornecedorViewModel);
            await _fornecedorService.Editar(fornecedor);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Excluir(int id)
        {
            var fornecedor = _mapper.Map<FornecedorViewModel>(await _fornecedorService.ObterPorId(id));

            if (fornecedor == null) return NotFound();

            return View(fornecedor);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Excluir(FornecedorViewModel fornecedorViewModel)
        {
            var fornecedor = _mapper.Map<Fornecedor>(fornecedorViewModel);
            await _fornecedorService.Excluir(fornecedor);

            return RedirectToAction(nameof(Index));
        }
    }
}
