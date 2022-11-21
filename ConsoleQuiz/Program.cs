// See https://aka.ms/new-console-template for more information
using ConsoleQuiz;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

      
        Resposta resposta0 = new Resposta("Victor",0);
        Resposta resposta1 = new Resposta("Joao",1);
        Resposta resposta2 = new Resposta("Maicon",2);
        Resposta resposta3 = new Resposta("Everton",3);
        



        Pergunta pergunta1 = new Pergunta("Qual meu nome", resposta0);

        var listaRespostas = new List<Resposta> { resposta0, resposta1, resposta2, resposta3 };

        Questao questao = new Questao(pergunta1, listaRespostas);

        var sera = questao.VerificaAcertou(pergunta1, resposta1);

        Console.WriteLine(sera);

            




}
}