using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quiron.LojaVirtual.Web.Models
{
    public class Paginacao
    {
        public int ItensTotal { get; set; } //qtos intem tem no banco.
        public int ItensPorPagina { get; set; } //qtos itens tem por página.
        public int PaginaAtual { get; set; } //qual a página exibida no momento.
        public int TotalPagina //Qtas páginas terei.
        {
            get { return (int) Math.Ceiling((decimal) ItensTotal / ItensPorPagina);}
        }
    }
}