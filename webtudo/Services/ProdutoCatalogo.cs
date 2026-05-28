using webtudo.Models;

namespace webtudo.Services
{
    public static class ProdutoCatalogo
    {
        public static IReadOnlyList<ProdutoItem> ObterTodos() => ProdutoCatalogoFabrica.Criar();
    }
}
