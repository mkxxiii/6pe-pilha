using EstruturaPilha.Entidades;
using System;

namespace EstruturaPilha
{
    class Program
    {
        static void Main(string[] args)
        {
            Questao7Revisao();
            Console.ReadLine();
        }

        public static void Questao7Revisao()
        {
            var p = new PilhaEstatica();
            p.Empilha(1);
            p.Empilha(2);
            p.Empilha(3);
            p.Empilha(4);
            p.Empilha(5);
            p.Empilha(6);
            var listaPops = p.MultiPop(6);
            foreach(var item in listaPops){
                Console.WriteLine(item);
            }
        }

        public static void SegundoExercicioLista2()
        {
            Console.WriteLine("Digite o seu texto abaixo, apenas os 30 primeiros caracteres serão considerados: ");
            var texto = Console.ReadLine();

            if (texto.Length > 30)
                texto = texto.Substring(0, 30);

            var pilha = new PilhaParenteses();

            foreach (var caractere in texto)
            {
                if (caractere == '(')
                {
                    pilha.Empilha(caractere);
                }
                else if (caractere == ')')
                {
                    if (pilha.EstaVazia())
                    {
                        Console.WriteLine("Texto inválido");
                        return;
                    }
                    pilha.Desempilha();
                }
            }

            if (pilha.EstaVazia())
                Console.WriteLine("Texto válido");
            else
                Console.WriteLine("Texto inválido");
        }

        public static void PrimeiroExercicioLista1()
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
            Console.ReadLine();
            p.Desempilha();
            Console.WriteLine("E agora");
            numeros = p.RetornaTodosElementos();
            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }
        }
    }
}
