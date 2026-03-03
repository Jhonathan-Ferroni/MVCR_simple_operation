using Programa.view;

namespace Programa;
    public class Program
{
    public static void Main()
    {
        //Criar um crud:
        int op = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("[1] - Para criar");
            Console.WriteLine("[2] - Para alterar");
            Console.WriteLine("[3] - Para deletar");
            Console.WriteLine("[4] - Para listar");
            Console.WriteLine("[5] - Para encerrar");
            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    ViewPessoa.Criar();
                    break;
                case 2:
                    ViewPessoa.Alterar();
                    break;
                case 3:
                    ViewPessoa.Deletar();
                    break;
                case 4:
                    ViewPessoa.Listar();
                    break;
                case 5:
                    Console.WriteLine("Encerrando o programa");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }while(op!=5);
    }
}