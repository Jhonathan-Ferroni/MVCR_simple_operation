using System.Numerics;
using Programa.model;
using Programa.controller;

namespace Programa.view;

public class ViewPessoa
{
    public static void Criar()
    {
        Console.WriteLine("--Criando uma pessoa--");
        Console.WriteLine("--Informe o nome: --");
        string nome = Console.ReadLine()??"";
        Console.WriteLine("--Informe a idade da pessoa: --");
        int idade = Convert.ToInt32(Console.ReadLine());
        ControllerPessoa.Criar(nome, idade);
        Console.WriteLine(nome+" criado");
    }
    public static void Alterar()
    {
        Console.WriteLine("--Alterando uma pessoa--");
        Console.WriteLine("--Informe o Índice: --");
        int indice = Convert.ToInt32(Console.ReadLine()??"");
        Console.WriteLine("--Informe o nome: --");
        string nome = Console.ReadLine()??"";
        Console.WriteLine("--Informe a idade da pessoa: --");
        int idade = Convert.ToInt32(Console.ReadLine());
        ControllerPessoa.Alterar(indice,nome, idade);
        Console.WriteLine(indice+" alterado");
        
    }
    public static void Deletar()
    {
        Console.WriteLine("--Alterando uma pessoa--");
        Console.WriteLine("--Informe o Índice: --");
        int indice = Convert.ToInt32(Console.ReadLine()??"");
        ControllerPessoa.Deletar(indice);
        Console.WriteLine(indice+" deletado");
    }
    public static void Listar()
    {
        Console.WriteLine("Listando as pessoas");
        List<Pessoa> pessoas = ControllerPessoa.Listar();
        int indice = 0;
        foreach (Pessoa pessoa in pessoas)
        {
            Console.WriteLine($"{indice} - {pessoa.Nome} - {pessoa.Idade}");
            indice++;
        }
        Console.WriteLine("Pressione qualquer tecla para continuar ");
        Console.ReadLine();
    }
}