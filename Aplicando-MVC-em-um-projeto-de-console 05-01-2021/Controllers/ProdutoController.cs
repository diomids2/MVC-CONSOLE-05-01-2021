using System.Collections.Generic;
using Aplicando_MVC_em_um_projeto_de_console.Models;
using Aplicando_MVC_em_um_projeto_de_console.Views;

namespace Aplicando_MVC_em_um_projeto_de_console.Controllers
{
    public class ProdutoController
    {
        Produto produto = new Produto();

        ProdutoView produtoView = new ProdutoView();

        public void Listar()
        {
            List<Produto> lista = produtoModel.Ler();
            produtoView.MostrarNoConsole(lista);
        }

        public void Buscar(string termo)
        {
            List<Produto> lista = produtoModel.Ler().FindAll(x => x.Preco == float.Parse(termo));
            produtoView.MostrarNoConsole(lista);
        
        }
    }
}