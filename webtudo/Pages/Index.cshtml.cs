using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using webtudo.Models;
using webtudo.Services;

namespace webtudo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public IList<ProdutoItem> Produtos { get; private set; } = [];
        public IList<CategoriaResumo> Categorias { get; private set; } = [];
        public IList<string> MarcasDisponiveis { get; private set; } = [];

        [BindProperty(SupportsGet = true)]
        public string? Categoria { get; set; }

        [BindProperty(SupportsGet = true)]
        public decimal? PrecoMin { get; set; }

        [BindProperty(SupportsGet = true)]
        public decimal? PrecoMax { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? Marca { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? Avaliacao { get; set; }

        [BindProperty(SupportsGet = true)]
        public bool FreteGratis { get; set; }

        [BindProperty(SupportsGet = true)]
        public bool EntregaRapida { get; set; }

        [BindProperty(SupportsGet = true)]
        public bool ProdutoNovo { get; set; }

        [BindProperty(SupportsGet = true)]
        public bool EmEstoque { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Ordenacao { get; set; } = "relevancia";

        public void OnGet()
        {
            var todos = ProdutoCatalogo.ObterTodos();

            Categorias = todos
                .GroupBy(p => p.Categoria)
                .Select(g => new CategoriaResumo { Nome = g.Key, Quantidade = g.Count() })
                .OrderBy(c => c.Nome)
                .ToList();

            MarcasDisponiveis = ["Todas", .. todos.Select(p => p.Marca).Distinct().OrderBy(m => m)];

            var query = todos.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(Categoria))
            {
                query = query.Where(p =>
                    p.Categoria.Equals(Categoria, StringComparison.OrdinalIgnoreCase));
            }

            if (PrecoMin.HasValue)
            {
                query = query.Where(p => p.Preco >= PrecoMin.Value);
            }

            if (PrecoMax.HasValue)
            {
                query = query.Where(p => p.Preco <= PrecoMax.Value);
            }

            if (!string.IsNullOrWhiteSpace(Marca) && !Marca.Equals("Todas", StringComparison.OrdinalIgnoreCase))
            {
                query = query.Where(p =>
                    p.Marca.Equals(Marca, StringComparison.OrdinalIgnoreCase));
            }

            if (double.TryParse(Avaliacao, out var minAvaliacao))
            {
                query = query.Where(p => p.Avaliacao >= minAvaliacao);
            }

            if (FreteGratis)
            {
                query = query.Where(p => p.FreteGratis);
            }

            if (EntregaRapida)
            {
                query = query.Where(p => p.EntregaRapida);
            }

            if (ProdutoNovo)
            {
                query = query.Where(p => p.ProdutoNovo);
            }

            if (EmEstoque)
            {
                query = query.Where(p => p.EmEstoque);
            }

            query = Ordenacao switch
            {
                "menor-preco" => query.OrderBy(p => p.Preco),
                "maior-preco" => query.OrderByDescending(p => p.Preco),
                "mais-vendidos" => query.OrderByDescending(p => p.Vendas),
                "mais-avaliados" => query.OrderByDescending(p => p.Avaliacao),
                "mais-recentes" => query.OrderByDescending(p => p.ProdutoNovo).ThenByDescending(p => p.Id),
                _ => query.OrderByDescending(p => p.Vendas)
            };

            Produtos = query.ToList();
        }

        public string ObterImagem(ProdutoItem produto) =>
            ProdutoImagensLegacy.Obter(produto.Id) ?? produto.ImagemUrl;

        public string LinkCategoria(string nome) =>
            Url.Page("/Index", new
            {
                Categoria = nome,
                PrecoMin,
                PrecoMax,
                Marca,
                Avaliacao,
                FreteGratis,
                EntregaRapida,
                ProdutoNovo,
                EmEstoque,
                Ordenacao
            }) ?? "?";

        public bool CategoriaAtiva(string nome) =>
            !string.IsNullOrWhiteSpace(Categoria) &&
            Categoria.Equals(nome, StringComparison.OrdinalIgnoreCase);
    }
}
