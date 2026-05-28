namespace webtudo.Services
{
    public class ProdutoImagemResolver(IWebHostEnvironment env)
    {
        private const string PastaRelativa = "/images/produtos";

        public string Resolver(int id, string imagemUrl, string nomeProduto)
        {
            var arquivoLocal = Path.Combine(env.WebRootPath, "images", "produtos", $"{id}.jpg");
            if (File.Exists(arquivoLocal))
                return $"{PastaRelativa}/{id}.jpg";

            var legado = ProdutoImagensLegacy.Obter(id);
            if (!string.IsNullOrEmpty(legado))
                return legado;

            if (UrlExternaValida(imagemUrl))
                return imagemUrl;

            return Placeholder(nomeProduto);
        }

        public string Placeholder(string nomeProduto) =>
            $"https://placehold.co/280x170/3d9ad4/0e3552?text={Uri.EscapeDataString(ResumirNome(nomeProduto))}";

        private static bool UrlExternaValida(string? url) =>
            !string.IsNullOrWhiteSpace(url)
            && !url.StartsWith("img-produto", StringComparison.OrdinalIgnoreCase)
            && !url.Contains("placehold.co", StringComparison.OrdinalIgnoreCase);

        private static string ResumirNome(string nome)
        {
            if (nome.Length <= 28)
                return nome;
            return nome[..25] + "...";
        }
    }
}
