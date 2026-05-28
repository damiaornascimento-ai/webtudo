using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using webtudo.Context;
using webtudo.Models;
using webtudo.Services;

namespace webtudo.Pages.Admin
{
    [Authorize(Roles = "Administrador")]
    public class CadastrarUsuarioModel : PageModel
    {
        private readonly AppDbContext _context;

        public CadastrarUsuarioModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public UsuarioInput Input { get; set; } = new();

        public List<SelectListItem> Perfis { get; set; } = [];

        public string? MensagemSucesso { get; set; }

        public string? MensagemErro { get; set; }

        public void OnGet()
        {
            CarregarPerfis();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            CarregarPerfis();

            if (!ModelState.IsValid)
            {
                return Page();
            }

            var email = Input.Email.Trim().ToLowerInvariant();

            if (await _context.Usuarios.AnyAsync(u => u.Email.ToLower() == email))
            {
                MensagemErro = "Ja existe um usuario com este e-mail.";
                return Page();
            }

            var usuario = new Usuario
            {
                Nome = Input.Nome.Trim(),
                Email = email,
                Senha = SenhaService.GerarHash(Input.Senha),
                Perfil = Input.Perfil
            };

            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();

            MensagemSucesso = $"Usuario {usuario.Nome} cadastrado com sucesso.";
            Input = new UsuarioInput();
            ModelState.Clear();
            CarregarPerfis();

            return Page();
        }

        private void CarregarPerfis()
        {
            Perfis =
            [
                new SelectListItem("Cliente", PerfilUsuario.Cliente),
                new SelectListItem("Administrador", PerfilUsuario.Administrador)
            ];
        }

        public class UsuarioInput
        {
            [Required(ErrorMessage = "Informe o nome.")]
            [StringLength(120, ErrorMessage = "Nome muito longo.")]
            public string Nome { get; set; } = string.Empty;

            [Required(ErrorMessage = "Informe o e-mail.")]
            [EmailAddress(ErrorMessage = "E-mail invalido.")]
            public string Email { get; set; } = string.Empty;

            [Required(ErrorMessage = "Informe a senha.")]
            [StringLength(100, MinimumLength = 6, ErrorMessage = "A senha deve ter entre 6 e 100 caracteres.")]
            [DataType(DataType.Password)]
            public string Senha { get; set; } = string.Empty;

            [Required(ErrorMessage = "Confirme a senha.")]
            [Compare(nameof(Senha), ErrorMessage = "As senhas nao conferem.")]
            [DataType(DataType.Password)]
            public string ConfirmarSenha { get; set; } = string.Empty;

            [Required(ErrorMessage = "Selecione o perfil.")]
            public string Perfil { get; set; } = PerfilUsuario.Cliente;
        }
    }
}
