﻿using Quiron.LojaVirtual.Dominio.Repositorio;
using Quiron.LojaVirtual.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
        private ProdutosRepositorio _repositorio;
        public int ProdutosPorPagina = 8;
        



        public ViewResult ListaProdutos(int pagina = 1)
        {
            _repositorio = new ProdutosRepositorio();

            ProdutosViewModel model = new ProdutosViewModel
            {

                Produtos = _repositorio.Produtos
                    .OrderBy(p => p.Descricao)
                    .Skip((pagina - 1) * ProdutosPorPagina) //pula os dois primeiros
                    .Take(ProdutosPorPagina),


                Paginacao = new Paginacao
                {
                    PaginaAtual    = pagina,
                    ItensPorPagina = ProdutosPorPagina,
                    ItensTotal     = _repositorio.Produtos.Count()
                }
            };
          


            return View(model);
        }
    }
}