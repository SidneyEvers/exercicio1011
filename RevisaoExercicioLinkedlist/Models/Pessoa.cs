namespace RevisaoExercicioLinkedlist.Models;

internal class Pessoa
{
    private static SortedList<string, Pessoa> listaPessoa = new SortedList<string, Pessoa>();

    public string Sobrenome { get; set; }

    public Pessoa(string sobrenome)
    {
        Sobrenome = sobrenome;
    }

    public void AdicionarNaLista(string nome, Pessoa pessoa)
    {
        listaPessoa.Add(nome, pessoa);
    }

    public void MostrarNaLista()
    {
        foreach(var x in listaPessoa)
        {
            Console.WriteLine($"Nome: {x.Key} Sobrenome: {x.Value.Sobrenome}");
            
        }
    }

}
