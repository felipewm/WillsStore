using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WillsStore.Core.DomainObjects;

namespace WillsStore.Catalogo.Domain
{
    public class Produto : Entity, IAgregateRoot
    {

        public Guid CategoriaId { get; private set; }
        public string Nome { get; private set; }

        public string Descricao { get; private set; }

        public bool Ativo { get; private set; }

        public decimal Valor { get; private set; }

        public DateTime DataCadastro { get; private set; }

        public string Imagem { get; private set; }

        //public int QuantidadeEstoque { get; private set; }

        public Categoria Categoria { get; private set; }

        public Produto(string nome, string descricao, bool ativo, decimal valor, Guid categoriaId, DateTime dataCadastro, string imagem)
        {
            CategoriaId = categoriaId;
            Nome = nome;
            Descricao = descricao;
            Ativo = ativo;
            Valor = valor;
            DataCadastro = dataCadastro;
            Imagem = imagem;
        }

        public void Ativar() => Ativo = true;

        public void Desativar() => Ativo = false;

        public void AlterarCategoria(Categoria categoria)
        {
            Categoria = categoria;
            CategoriaId = categoria.Id;

        }

        public void AlterarDescricao(string descricao)
        {
            Descricao = descricao;
        }

        public void Validar()
        {

        }
    }

    public class Categoria : Entity
    {
        public string Nome { get; private set; }

        public string Codigo { get; private set;}

        public Categoria(string nome, string codigo)
        {
            Nome = nome;
            Codigo = codigo;

        }

        public override string ToString()
        {
            return $"{Nome} - {Codigo}"; 
        }
    }

}
