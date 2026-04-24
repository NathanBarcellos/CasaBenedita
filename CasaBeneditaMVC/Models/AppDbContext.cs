using Microsoft.EntityFrameworkCore;

namespace CasaBeneditaMVC.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Mesa> Mesas { get; set; }
        public DbSet<Reserva> Reservas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Categoria>().HasData(
                new Categoria { CategoriaId = 1, Nome = "Entradas" },
                new Categoria { CategoriaId = 2, Nome = "Pratos Principais" },
                new Categoria { CategoriaId = 3, Nome = "Bebidas" },
                new Categoria { CategoriaId = 4, Nome = "Sobremesas" }
            );

            modelBuilder.Entity<Produto>().HasData(

                // ENTRADAS
                new Produto { ProdutoId = 1, Nome = "Bruschetta Benedita", Descricao = "Entrada leve com pão e tomate", Preco = 24.90m, ImagemUrl = "Entradas/Bruschetta.png", Disponivel = true, CategoriaId = 1 },
                new Produto { ProdutoId = 2, Nome = "Carpaccio Especial da Casa", Descricao = "Finas fatias de carne", Preco = 29.90m, ImagemUrl = "Entradas/Carpaccio.png", Disponivel = true, CategoriaId = 1 },
                new Produto { ProdutoId = 3, Nome = "Batata Rústica da Dona Benedita", Descricao = "Batatas crocantes", Preco = 19.90m, ImagemUrl = "Entradas/Batata.png", Disponivel = true, CategoriaId = 1 },
                new Produto { ProdutoId = 4, Nome = "Bolinho Dourado da Vovó", Descricao = "Bolinho crocante", Preco = 22.90m, ImagemUrl = "Entradas/Bolinho.png", Disponivel = true, CategoriaId = 1 },
                new Produto { ProdutoId = 5, Nome = "Dadinhos Crocantes da Casa", Descricao = "Petisco especial", Preco = 21.90m, ImagemUrl = "Entradas/Dadinhos.png", Disponivel = true, CategoriaId = 1 },

                // PRATOS
                new Produto { ProdutoId = 6, Nome = "Picanha da Dona Benedita", Descricao = "Carne grelhada especial", Preco = 64.90m, ImagemUrl = "Pratos/picanha.png", Disponivel = true, CategoriaId = 2 },
                new Produto { ProdutoId = 7, Nome = "Costela da Casa", Descricao = "Costela suculenta", Preco = 61.90m, ImagemUrl = "Pratos/Costela.png", Disponivel = true, CategoriaId = 2 },
                new Produto { ProdutoId = 8, Nome = "Filé Mignon", Descricao = "Filé com molho especial", Preco = 69.90m, ImagemUrl = "Pratos/FileMignon.png", Disponivel = true, CategoriaId = 2 },
                new Produto { ProdutoId = 9, Nome = "Contra Filé", Descricao = "Carne na brasa", Preco = 49.90m, ImagemUrl = "Pratos/contra.png", Disponivel = true, CategoriaId = 2 },
                new Produto { ProdutoId = 10, Nome = "Lombo Suíno", Descricao = "Lombo assado", Preco = 44.90m, ImagemUrl = "Pratos/Lombo.png", Disponivel = true, CategoriaId = 2 }
            );
        }
    }
}