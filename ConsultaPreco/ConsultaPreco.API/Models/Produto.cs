namespace ConsultaPreco.API.Models
{
    public class Produto
    {
        public Produto(int id, string codbarras, string nome, string precoVenda)
        {
            Id = id;
            Codbarras = codbarras;
            Nome = nome;
            PrecoVenda = precoVenda;
        }

        public int Id { get; private set; }
        public string Codbarras { get; private set; }
        public string Nome { get; private set; }
        public string PrecoVenda { get; private set; }
    }
}
