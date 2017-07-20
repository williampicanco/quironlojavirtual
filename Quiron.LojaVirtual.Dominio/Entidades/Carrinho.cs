using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiron.LojaVirtual.Dominio.Entidades
{
    public class Carrinho
    {
        private readonly List<ItemCarrinho> _itemCarrinho = new List<ItemCarrinho>();

        /*
        Método Adicionar:
        objetivo: recebe como parâmetro o produto, faço uma query para ver se na minha lista já tem esse produto,
        se eu não tiver esse produto eu adiciono ele na lista, agora se eu já tiver esse produto eu o somo.      
        */
        public void AdicionarItem(Produto produto, int quantidade)
        {
            ItemCarrinho item = _itemCarrinho.FirstOrDefault(p => p.Produto.ProdutoId == produto.ProdutoId);

            //qdo não tiver esse produto na lista então ele é adicionado pela 1º vez.
            if(item == null)
            {
                _itemCarrinho.Add(new ItemCarrinho
                {
                    Produto = produto,
                    Quantidade = quantidade
                });
            }
            else
            {   //qdo o produto já tiver sido add ele será somado com ele mesmo.
                item.Quantidade += quantidade;
            }
        }

        //Método Remover item
        public void RemoverItem(Produto produto)
        {
            _itemCarrinho.RemoveAll(l => l.Produto.ProdutoId == produto.ProdutoId);
        }


        //Método Obter o valor total
        public decimal ObterValorTotal()
        {
            return _itemCarrinho.Sum(e => e.Produto.Preco * e.Quantidade);
        }


        //Método Limpar carrinho
        public void LimparCarrinho()
        {
            _itemCarrinho.Clear();
        }

        //Método Itens do carrinho
        public IEnumerable<ItemCarrinho> ItensCarrinho
        {
            get{ return _itemCarrinho; }
        }

    }

    public class ItemCarrinho
    {
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
    }
}
