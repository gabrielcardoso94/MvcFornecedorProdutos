using App.ViewModels;
using AutoMapper;
using Business.Models;
using Business.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace App.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly ProdutoService _produtoService;
        private readonly FornecedorService _fornecedorService;
        private readonly IMapper _mapper;

        public ProdutosController(ProdutoService produtoService, FornecedorService fornecedorService, IMapper mapper)
        {
            _produtoService = produtoService;
            _fornecedorService = fornecedorService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var listaProdutos = _mapper.Map<List<ProdutoViewModel>>(await _produtoService.ObterTodos());
            return View(listaProdutos);
        }

        public async Task<IActionResult> Adicionar()
        {
            var viewModel = new ProdutoViewModel();
            viewModel.Fornecedores = _mapper.Map<List<FornecedorViewModel>>(await _fornecedorService.ObterTodos());
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Adicionar(ProdutoViewModel produtoViewModel)
        {
            if (!ModelState.IsValid)
            {
                produtoViewModel.Fornecedores = _mapper.Map<List<FornecedorViewModel>>(await _fornecedorService.ObterTodos());
                return View(produtoViewModel);
            }

            var produto = _mapper.Map<Produto>(produtoViewModel);
            await _produtoService.Adicionar(produto);

            return RedirectToAction(nameof(Index));
        }
    }
}
