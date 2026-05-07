using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using CasaBeneditaMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CasaBeneditaMVC.Controllers
{
    public class PedidoController : Controller
    {
        private readonly AppDbContext _context;

        public PedidoController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FinalizarPedido(
            string carrinhoJson,
            string rua,
            string numero,
            string bairro,
            string cidade,
            string cep,
            string complemento)
        {
            // CONVERTE JSON EM LISTA
            var carrinho = JsonSerializer.Deserialize<List<CarrinhoItem>>(carrinhoJson);

            if (carrinho == null || !carrinho.Any())
            {
                return RedirectToAction("Checkout");
            }

            decimal total = carrinho.Sum(i => i.Preco * i.Quantidade);

            // CRIA PEDIDO
            var pedido = new Pedido
            {
                DataPedido = DateTime.Now,
                ValorTotal = total,
                Status = "Pedido Confirmado",

                Rua = rua,
                Numero = numero,
                Bairro = bairro,
                Cidade = cidade,
                CEP = cep,
                Complemento = complemento,

                UsuarioId = 1
            };

            _context.Pedidos.Add(pedido);
            _context.SaveChanges();

            // SALVA ITENS DO PEDIDO
            foreach (var item in carrinho)
            {
                // VALIDA SE O PRODUTO EXISTE
                var produtoExiste = _context.Produtos
                    .Any(p => p.ProdutoId == item.ProdutoId);

                if (!produtoExiste)
                {
                    continue;
                }

                var itemPedido = new ItemPedido
                {
                    PedidoId = pedido.PedidoId,
                    ProdutoId = item.ProdutoId,
                    Quantidade = item.Quantidade,
                    PrecoUnitario = item.Preco
                };

                _context.ItensPedido.Add(itemPedido);
            }

            // SALVA PAGAMENTO
            var pagamento = new Pagamento
            {
                MetodoPagamento = "Cartão de Crédito",
                Valor = total,
                DataPagamento = DateTime.Now,
                StatusPagamento = "Pago",
                PedidoId = pedido.PedidoId
            };

            _context.Pagamentos.Add(pagamento);

            _context.SaveChanges();

            return RedirectToAction("Sucesso");
        }

        public IActionResult Sucesso()
        {
            return View();
        }
    }
}