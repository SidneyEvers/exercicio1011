using RevisaoExercicioLinkedlist.Models;

namespace RevisaoExercicioLinkedlist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exercicio1();
            //exercicio2();
            exercicio3();
            Console.ReadKey();

            void exercicio1()
            {
                Pessoa pessoa = new("Evers");
                pessoa.AdicionarNaLista("Sidney", pessoa);

                Pessoa pessoa1 = new("Vandall");
                pessoa1.AdicionarNaLista("Breno", pessoa1);

                pessoa.MostrarNaLista();
            }

            void exercicio2()
            {
                Produtos produto = new("Carne", 20.99f);
                produto.AdicionarProduto(produto);

                Produtos produto2 = new("Banana", 10.55f);
                produto2.AdicionarProduto(produto2);

                Produtos produto3 = new("Carne", 20.99f);
                produto3.AdicionarProduto(produto3);

                produto.MostrarProdutos();

            }

            void exercicio3()
            {
                List<Produtos> listaProdutos = new();
                Produtos produto = new("Coca-Cola", 5.99f);
                
                listaProdutos.Add(produto);

                Categoria categoria = new(1, "Bebidas");

                categoria.AdicionarNaListaCategoria(categoria, listaProdutos);

                categoria.MostrarListaDeProdutos(listaProdutos);

                 
            }

        }

        
    }
}