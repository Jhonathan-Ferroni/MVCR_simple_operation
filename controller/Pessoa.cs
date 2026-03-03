using Programa.model;

namespace Programa.controller;

public class ControllerPessoa
{
    public static void Criar(string nome, int idade)
    {
        new Pessoa(nome, idade);
    }
    public static void Alterar(int indice, string nome, int idade)
    {
        Pessoa.Alterar(indice, nome, idade);
    }
    public static void Deletar(int indice)
    {
        Pessoa.Deletar(indice);
    }
    public static List<Pessoa> Listar()
    {
        return Pessoa.Listar();       
    }
}