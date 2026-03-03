namespace Programa.model;

using Programa.repository;

public class Pessoa
{
    public string Nome{get; set;}
    public int Idade{get;set;}

    public Pessoa(string nome, int idade){
        Nome = nome;
        Idade = idade;

        PessoaR.pessoas.Add(this);
    }

    public static List<Pessoa> Listar()
    {
        return PessoaR.pessoas;
    }

    public static void Alterar(int indice, string nome, int idade)
    {
        PessoaR.pessoas[indice].Nome = nome;
        PessoaR.pessoas[indice].Idade = idade;
    }

    public static void Deletar(int indice)
    {
        PessoaR.pessoas.RemoveAt(indice);
    }
}