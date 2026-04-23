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

            // 🔵 Categorias
            modelBuilder.Entity<Categoria>().HasData(
                new Categoria { CategoriaId = 1, Nome = "Entradas" },
                new Categoria { CategoriaId = 2, Nome = "Pratos Principais" },
                new Categoria { CategoriaId = 3, Nome = "Bebidas" },
                new Categoria { CategoriaId = 4, Nome = "Sobremesas" }
            );

            // 🔵 Produtos
            modelBuilder.Entity<Produto>().HasData(

                // 🍽️ ENTRADAS
                new Produto { ProdutoId = 1, Nome = "Bruschetta Benedita", Descricao = "Entrada leve com pão e tomate", Preco = 24.90m, ImagemUrl = "Entradas/Bruschetta.png", Disponivel = true, CategoriaId = 1 },
                new Produto { ProdutoId = 2, Nome = "Carpaccio Especial da Casa", Descricao = "Finas fatias de carne", Preco = 29.90m, ImagemUrl = "Entradas/Carpaccio.png", Disponivel = true, CategoriaId = 1 },
                new Produto { ProdutoId = 3, Nome = "Batata Rústica da Dona Benedita", Descricao = "Batatas crocantes", Preco = 19.90m, ImagemUrl = "Entradas/Batata.png", Disponivel = true, CategoriaId = 1 },
                new Produto { ProdutoId = 4, Nome = "Bolinho Dourado da Vovó", Descricao = "Bolinho crocante", Preco = 22.90m, ImagemUrl = "Entradas/Bolinho.png", Disponivel = true, CategoriaId = 1 },
                new Produto { ProdutoId = 5, Nome = "Dadinhos Crocantes da Casa", Descricao = "Petisco especial", Preco = 21.90m, ImagemUrl = "Entradas/Dadinhos.png", Disponivel = true, CategoriaId = 1 },

                // 🥩 PRATOS PRINCIPAIS
                new Produto { ProdutoId = 6, Nome = "Picanha da Dona Benedita", Descricao = "Carne grelhada especial", Preco = 64.90m, ImagemUrl = "Pratos/picanha.png", Disponivel = true, CategoriaId = 2 },
                new Produto { ProdutoId = 7, Nome = "Costela da Casa ao Molho Barbecue", Descricao = "Costela suculenta", Preco = 61.90m, ImagemUrl = "Pratos/Costela.png", Disponivel = true, CategoriaId = 2 },
                new Produto { ProdutoId = 8, Nome = "Filé Mignon ao Molho da Vovó", Descricao = "Filé com molho especial", Preco = 69.90m, ImagemUrl = "Pratos/FileMignon.png", Disponivel = true, CategoriaId = 2 },
                new Produto { ProdutoId = 9, Nome = "Contra Filé Especial na Brasa", Descricao = "Carne na brasa", Preco = 49.90m, ImagemUrl = "Pratos/contra.png", Disponivel = true, CategoriaId = 2 },
                new Produto { ProdutoId = 10, Nome = "Lombo Suíno Assado da Fazenda", Descricao = "Lombo assado", Preco = 44.90m, ImagemUrl = "Pratos/Lombo.png", Disponivel = true, CategoriaId = 2 },

                // 🍰 SOBREMESAS
                new Produto { ProdutoId = 11, Nome = "Pudim Cremoso da Dona Benedita", Descricao = "Sobremesa da casa", Preco = 12.00m, ImagemUrl = "Sobremesas/Pudim.png", Disponivel = true, CategoriaId = 4 },
                new Produto { ProdutoId = 12, Nome = "Brownie Quentinho da Casa", Descricao = "Brownie quente", Preco = 18.90m, ImagemUrl = "Sobremesas/Brownie.png", Disponivel = true, CategoriaId = 4 },
                new Produto { ProdutoId = 13, Nome = "Mousse de Chocolate Especial", Descricao = "Mousse cremoso", Preco = 14.90m, ImagemUrl = "Sobremesas/Mousse.jpg", Disponivel = true, CategoriaId = 4 },
                new Produto { ProdutoId = 14, Nome = "Doce Tentação de Frutas Vermelhas", Descricao = "Sobremesa com frutas", Preco = 19.90m, ImagemUrl = "Sobremesas/DoceTentacao.png", Disponivel = true, CategoriaId = 4 },
                new Produto { ProdutoId = 15, Nome = "Delícia de Chocolate com Coração Quente", Descricao = "Chocolate especial", Preco = 22.90m, ImagemUrl = "Sobremesas/DeliciaChocolate.png", Disponivel = true, CategoriaId = 4 },

                // 🍹 BEBIDAS
                new Produto { ProdutoId = 16, Nome = "Refrigerante Gelado", Descricao = "Lata 350ml", Preco = 6.00m, ImagemUrl = "Bebidas/refri_latas.jpg", Disponivel = true, CategoriaId = 3 },
                new Produto { ProdutoId = 17, Nome = "Suco Natural da Casa", Descricao = "Suco natural", Preco = 9.90m, ImagemUrl = "Bebidas/Suco.png", Disponivel = true, CategoriaId = 3 },
                new Produto { ProdutoId = 18, Nome = "Água Mineral", Descricao = "Água sem gás", Preco = 4.00m, ImagemUrl = "Bebidas/Agua.png", Disponivel = true, CategoriaId = 3 },
                new Produto { ProdutoId = 19, Nome = "Cerveja Long Neck", Descricao = "Cerveja gelada", Preco = 8.00m, ImagemUrl = "Bebidas/Cervejas.png", Disponivel = true, CategoriaId = 3 },
                new Produto { ProdutoId = 20, Nome = "Cerveja Artesanal da Casa", Descricao = "Cerveja especial", Preco = 14.00m, ImagemUrl = "Bebidas/Cervejas.png", Disponivel = true, CategoriaId = 3 }
            );
        }
    }
}