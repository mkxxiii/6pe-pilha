using EstruturaPilha.Entidades;
using System;

namespace EstruturaPilha
{
    class Program
    {
        static void Main(string[] args)
        {
            PilhaEstatica p = new PilhaEstatica();
            PilhaEstatica x = new PilhaEstatica();
            // PilhaDinamica p = new PilhaDinamica();
            bool flVazia = p.EstaVazia();
            p.Empilha(1);
            p.Empilha(2);
            p.Empilha(3);
            x.Empilha(1);
            x.Empilha(2);
            x.Empilha(3);
            var numeros = p.RetornaTodosElementos();
            int maior = p.MaiorElemento();
            int menor = p.MenorElemento();
            float media = p.Media();

            bool compare = p.Igual(x);

            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
            p.Desempilha();
            Console.WriteLine("E agora");
            numeros = p.RetornaTodosElementos();
            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }
    }
}
