using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace webtudo.Pages
{
    public class ComprarModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string? Nome { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? Preco { get; set; }

        [BindProperty]
        public string? NomeCompleto { get; set; }

        [BindProperty]
        public string? Email { get; set; }

        [BindProperty]
        public string? Endereco { get; set; }

        [BindProperty]
        public int Quantidade { get; set; } = 1;

        public string? MensagemSucesso { get; set; }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(Nome))
            {
                Nome = "Produto";
            }

            if (string.IsNullOrWhiteSpace(Preco))
            {
                Preco = "0";
            }
        }

        public IActionResult OnPost()
        {
            if (string.IsNullOrWhiteSpace(NomeCompleto) || string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Endereco))
            {
                ModelState.AddModelError(string.Empty, "Preencha todos os campos obrigatórios.");
                return Page();
            }

            if (Quantidade < 1)
            {
                Quantidade = 1;
            }

            MensagemSucesso = $"Pedido de {Quantidade}x {Nome} enviado com sucesso! Entraremos em contato em {Email}.";
            return Page();
        }
    }
}
