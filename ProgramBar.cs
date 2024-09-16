using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoBar
{
    public class Consumidor
    {
        public string Nome { get; set; }
        public string CPF { get; set; }

        public Consumidor(string nome, string cpf)
        {
            Nome = nome;
            CPF = cpf;
        }
    }

    public class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }

        public Produto(string nome, decimal preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Nome: {Nome}, Preço: {Preco:C}, Quantidade: {Quantidade}");
        }
    }

    public class Fornecedor
    {
        public string Nome { get; set; }
        public string CNPJ { get; set; }

        public Fornecedor(string nome, string cnpj)
        {
            Nome = nome;
            CNPJ = cnpj;
        }
    }

    public class Dados
    {
        public List<Consumidor> Consumidores { get; set; }
        public List<Produto> Produtos { get; set; }
        public List<Fornecedor> Fornecedores { get; set; }
    }
}