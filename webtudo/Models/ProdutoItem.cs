namespace webtudo.Models
{
    public class ProdutoItem
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Categoria { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;
        public decimal Preco { get; set; }
        public string PrecoCompra { get; set; } = string.Empty;
        public double Avaliacao { get; set; }
        public int Vendas { get; set; }
        public bool FreteGratis { get; set; }
        public bool EntregaRapida { get; set; }
        public bool ProdutoNovo { get; set; }
        public bool EmEstoque { get; set; }
        public string ImagemUrl { get; set; } = string.Empty;
    }

    public class CategoriaResumo
    {
        public string Nome { get; set; } = string.Empty;
        public int Quantidade { get; set; }
    }
}
