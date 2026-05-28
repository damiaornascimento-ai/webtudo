using webtudo.Models;

namespace webtudo.Services
{
    public static class ProdutoCatalogo
    {
        public static IReadOnlyList<ProdutoItem> ObterTodos()
        {
            return new List<ProdutoItem>
            {
                new()
                {
                    Id = 1,
                    Nome = "Iphone 14 Pro Max",
                    Categoria = "Celulares",
                    Marca = "Apple",
                    Preco = 7500m,
                    PrecoCompra = "7.500",
                    Avaliacao = 4.8,
                    Vendas = 320,
                    FreteGratis = true,
                    EntregaRapida = true,
                    ProdutoNovo = false,
                    EmEstoque = true,
                    ImagemUrl = "img-produto-1"
                },
                new()
                {
                    Id = 2,
                    Nome = "Iphone 17 Pro Max",
                    Categoria = "Celulares",
                    Marca = "Apple",
                    Preco = 10500m,
                    PrecoCompra = "10.500",
                    Avaliacao = 4.9,
                    Vendas = 180,
                    FreteGratis = true,
                    EntregaRapida = true,
                    ProdutoNovo = true,
                    EmEstoque = true,
                    ImagemUrl = "img-produto-2"
                },
                new()
                {
                    Id = 3,
                    Nome = "Samsung Galaxy S25 Ultra",
                    Categoria = "Celulares",
                    Marca = "Samsung",
                    Preco = 9000m,
                    PrecoCompra = "9.000",
                    Avaliacao = 4.7,
                    Vendas = 250,
                    FreteGratis = true,
                    EntregaRapida = false,
                    ProdutoNovo = true,
                    EmEstoque = true,
                    ImagemUrl = "https://encrypted-tbn3.gstatic.com/shopping?q=tbn:ANd9GcTQj_yjt4n5d9pmboteNKWpbqZX9FmYHHyCOXJnj1_vyrqisjVPACUcNLu_1VlZzGiWmoUZrDYFNUNKizrN4qeEpqjoPcnEVxKjD9LQBI06pf9ISjCtVIl6GyqbZaxfMK_t8KYlstrA9lc&usqp=CAc"
                },
                new()
                {
                    Id = 4,
                    Nome = "Sony PlayStation - Game console",
                    Categoria = "Consoles",
                    Marca = "Sony",
                    Preco = 1426m,
                    PrecoCompra = "1.426",
                    Avaliacao = 4.6,
                    Vendas = 410,
                    FreteGratis = false,
                    EntregaRapida = true,
                    ProdutoNovo = false,
                    EmEstoque = true,
                    ImagemUrl = "img-produto-4"
                },
                new()
                {
                    Id = 5,
                    Nome = "Console PlayStation 4 1TB Edição Limitada Days Of Play - Cinza",
                    Categoria = "Consoles",
                    Marca = "Sony",
                    Preco = 3599m,
                    PrecoCompra = "3.599",
                    Avaliacao = 4.5,
                    Vendas = 95,
                    FreteGratis = true,
                    EntregaRapida = false,
                    ProdutoNovo = false,
                    EmEstoque = true,
                    ImagemUrl = "img-produto-5"
                },
                new()
                {
                    Id = 6,
                    Nome = "Console PlayStation 5",
                    Categoria = "Consoles",
                    Marca = "Sony",
                    Preco = 4235.35m,
                    PrecoCompra = "4.235,35",
                    Avaliacao = 4.9,
                    Vendas = 520,
                    FreteGratis = true,
                    EntregaRapida = true,
                    ProdutoNovo = true,
                    EmEstoque = true,
                    ImagemUrl = "https://encrypted-tbn0.gstatic.com/shopping?q=tbn:ANd9GcQD7IcB7WVDclIxTqmCYDKbn1mtAr_2D7J5aWMIRsFIdyXxLJapw7hawHj0SgLK_fd2ZcTjorZUxtThiX4fBYy9PRq1QdzEzmaXPh_7duINFij-G9YBm-yM_RI3qU5nJPANyfUa0Q&usqp=CAc"
                },
                new()
                {
                    Id = 7,
                    Nome = "Fone Bluetooth Pro",
                    Categoria = "Acessorios",
                    Marca = "Sony",
                    Preco = 299.90m,
                    PrecoCompra = "299,90",
                    Avaliacao = 4.3,
                    Vendas = 780,
                    FreteGratis = true,
                    EntregaRapida = true,
                    ProdutoNovo = false,
                    EmEstoque = true,
                    ImagemUrl = "https://via.placeholder.com/140x110?text=Fone"
                },
                new()
                {
                    Id = 8,
                    Nome = "Notebook Gamer 16\"",
                    Categoria = "Informatica",
                    Marca = "Samsung",
                    Preco = 5899m,
                    PrecoCompra = "5.899",
                    Avaliacao = 4.4,
                    Vendas = 60,
                    FreteGratis = false,
                    EntregaRapida = true,
                    ProdutoNovo = true,
                    EmEstoque = true,
                    ImagemUrl = "https://via.placeholder.com/140x110?text=Notebook"
                },
                new()
                {
                    Id = 9,
                    Nome = "Smart TV 55 4K",
                    Categoria = "Ofertas",
                    Marca = "Samsung",
                    Preco = 2499m,
                    PrecoCompra = "2.499",
                    Avaliacao = 4.6,
                    Vendas = 140,
                    FreteGratis = true,
                    EntregaRapida = false,
                    ProdutoNovo = false,
                    EmEstoque = true,
                    ImagemUrl = "https://via.placeholder.com/140x110?text=Smart+TV"
                },
                new()
                {
                    Id = 10,
                    Nome = "Capa iPhone Premium",
                    Categoria = "Acessorios",
                    Marca = "Apple",
                    Preco = 149.90m,
                    PrecoCompra = "149,90",
                    Avaliacao = 4.2,
                    Vendas = 900,
                    FreteGratis = true,
                    EntregaRapida = true,
                    ProdutoNovo = true,
                    EmEstoque = true,
                    ImagemUrl = "https://via.placeholder.com/140x110?text=Capa"
                },
                new()
                {
                    Id = 11,
                    Nome = "Mouse Gamer RGB",
                    Categoria = "Informatica",
                    Marca = "Sony",
                    Preco = 189.90m,
                    PrecoCompra = "189,90",
                    Avaliacao = 4.1,
                    Vendas = 430,
                    FreteGratis = true,
                    EntregaRapida = false,
                    ProdutoNovo = false,
                    EmEstoque = true,
                    ImagemUrl = "https://via.placeholder.com/140x110?text=Mouse"
                },
                new()
                {
                    Id = 12,
                    Nome = "Controle DualSense",
                    Categoria = "Ofertas",
                    Marca = "Sony",
                    Preco = 449.90m,
                    PrecoCompra = "449,90",
                    Avaliacao = 4.8,
                    Vendas = 310,
                    FreteGratis = true,
                    EntregaRapida = true,
                    ProdutoNovo = false,
                    EmEstoque = true,
                    ImagemUrl = "https://via.placeholder.com/140x110?text=Controle"
                }
            };
        }
    }
}
