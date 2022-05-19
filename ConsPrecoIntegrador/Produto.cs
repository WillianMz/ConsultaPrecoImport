namespace ConsPrecoIntegrador
{
    public class Produto
    {
        public Produto(int id, string? codbarras, string? nome, string? precoVenda)
        {
            this.id = id;
            this.codbarras = codbarras;
            this.nome = nome;
            preco_venda = precoVenda;
        }

        public int id { get; private set; }
        public string? codbarras { get; private set; }
        public string? nome { get; private set; }
        public string? preco_venda { get; private set; }
    }
}
