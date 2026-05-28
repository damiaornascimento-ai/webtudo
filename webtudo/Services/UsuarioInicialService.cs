using Microsoft.EntityFrameworkCore;
using webtudo.Context;
using webtudo.Models;

namespace webtudo.Services
{
    public static class UsuarioInicialService
    {
        public static async Task GarantirUsuariosPadraoAsync(AppDbContext context)
        {
            var alterou = false;

            if (!await context.Usuarios.AnyAsync(u => u.Email == "admin@webtudotech.com"))
            {
                context.Usuarios.Add(new Usuario
                {
                    Nome = "Administrador",
                    Email = "admin@webtudotech.com",
                    Senha = SenhaService.GerarHash("admin123"),
                    Perfil = PerfilUsuario.Administrador
                });
                alterou = true;
            }

            if (!await context.Usuarios.AnyAsync(u => u.Email == "cliente@webtudotech.com"))
            {
                context.Usuarios.Add(new Usuario
                {
                    Nome = "Cliente Demo",
                    Email = "cliente@webtudotech.com",
                    Senha = SenhaService.GerarHash("cliente123"),
                    Perfil = PerfilUsuario.Cliente
                });
                alterou = true;
            }

            if (alterou)
            {
                await context.SaveChangesAsync();
            }
        }
    }
}
