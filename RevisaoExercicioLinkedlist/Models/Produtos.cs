namespace RevisaoExercicioLinkedlist.Models;

internal class Produtos
{
    static List<Produtos> produtos = new List<Produtos>();

    public string Nome { get; set; }

    public float Preco  { get; set; }

    public Produtos(string nome, float preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public void AdicionarProduto(Produtos produto)
    {
        foreach (var item in produtos)
        {
            if (item.Nome == produto.Nome)
            {
                Console.WriteLine("Produto já existente");
                return;
            }
        }
        produtos.Add(produto);
    }

    public void MostrarProdutos()
    {
        foreach(var produto in produtos)
        {
            Console.WriteLine($"Produto: {produto.Nome} Preço: {produto.Preco}");
        }
    }


}
