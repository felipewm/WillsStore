using WillsStore.Core.DomainObjects;

namespace WillsStore.Catalogo.Domain
{
    public class Categoria : Entity
    {
        public string Nome { get; private set; }
        public int Codigo { get; private set;}

        //EF Relation
        public ICollection<Produto> Produtos { get; set; }

        public Categoria(string nome, int codigo)
        {
            Nome = nome;
            Codigo = codigo;

        }

        protected Categoria()
        {
            
        }
        public override string ToString()
        {
            return $"{Nome} - {Codigo}"; 
        }
    }

}
