using Quiron.LojaVirtual.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quiron.LojaVirtual.Web.Areas.Administrativo.Controllers
{
    public class ProdutoController : Controller
    {
        //inicia instanciado o repositorio
        private ProdutosRepositorio _repositotio;

        public ActionResult Index()
        {
            _repositotio = new ProdutosRepositorio();
            var produtos = _repositotio.Produtos;
            return View(produtos);
        }
    }
}