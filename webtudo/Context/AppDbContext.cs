using webtudo.Models;
using Microsoft.EntityFrameworkCore;

namespace webtudo.Context
{
    // O ": DbContext" é o que faz a mágica acontecer
    public class AppDbContext : DbContext
    {
        // Este construtor é necessário para o Program.cs passar as configurações
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 
        }
        public DbSet<Usuario> Usuarios { get; set; }
        
        // Aqui você vai adicionar suas tabelas depois, por exemplo:
        // public DbSet<Usuario> Usuarios { get; set; }
    }
}