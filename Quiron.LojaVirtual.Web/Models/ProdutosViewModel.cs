using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Quiron.LojaVirtual.Dominio.Entidades;

namespace Quiron.LojaVirtual.Web.Models
{
    //Classe que vai representar itens do meu Dominio.
    public class ProdutosViewModel
    {
        public IEnumerable<Produto> Produtos{ get; set; }

        public Paginacao Paginacao { get; set; }

    }
}