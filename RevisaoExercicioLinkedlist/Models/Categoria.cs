using System.Collections.Generic;

namespace RevisaoExercicioLinkedlist.Models;

internal class Categoria
{
    static SortedList<Categoria, List<Produtos>> categoriaProdutos = new();

    public int Id { get; set; }
    public string Descricao { get; set; }

    public Categoria(int id, string descricao)
    {
        Id = id;
        Descricao = descricao;
    }

    public void AdicionarNaListaCategoria(Categoria categoria, List<Produtos> listaProdutos)
    {
        categoriaProdutos.Add(categoria, listaProdutos);

    }

    public void MostrarListaDeProdutos(List<Produtos> listProdutos)
    {
        foreach(KeyValuePair < Categoria, List<Produtos>> kv in  categoriaProdutos)
        {
            Console.WriteLine($"Categoria: {kv.Key.Id} {kv.Key.Descricao} Produto: ");

            for(int i = 0; i < listProdutos.Count; i++)
            {
                Console.WriteLine($"{listProdutos[i].Nome} Valor: {listProdutos[i].Preco}");
            }
            
        }
        
    }

}
