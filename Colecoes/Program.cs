using System;
using Colecoes.Helper;
using System.Collections.Generic;

namespace Colecoes{
    class Program{
        static void Main(string[] args){

            //Implemtando uma pilha
            System.Console.WriteLine("---------------------------");
            System.Console.WriteLine("Implemtando uma pilha:");
            System.Console.WriteLine();
            Stack<string> pilha = new Stack<string>();
            pilha.Push("Livro");
            pilha.Push("Revista");
            pilha.Push("Jornal");
                //Ler a pilha e removendo
                System.Console.WriteLine($"O que tem para ler: {pilha.Count}");
                System.Console.WriteLine();
            while (pilha.Count > 0)
            {
                System.Console.WriteLine($"O próximo a ler: {pilha.Peek()}");
                System.Console.WriteLine($"{pilha.Pop()} lido");
            }
            System.Console.WriteLine();
            System.Console.WriteLine($"O que tem para ler: {pilha.Count}");

            //Implemtando uma fila
            System.Console.WriteLine("---------------------------");
            System.Console.WriteLine("Implemtando uma fila:");
            System.Console.WriteLine();
            Queue<string> fila = new Queue<string>();
            fila.Enqueue("Márcia");
            fila.Enqueue("Maria");
            fila.Enqueue("Marcela");
                //Ler a fila e removendo
            System.Console.WriteLine($"Pessoas na fila: {fila.Count}");
            System.Console.WriteLine();
            while (fila.Count > 0)
            {
                System.Console.WriteLine($"Vez de: {fila.Peek()}");//Retorna o que está no começo da fila sem remover
                System.Console.WriteLine($"{fila.Dequeue()} atendida");
            }
            System.Console.WriteLine();
            System.Console.WriteLine($"Pessoas na fila: {fila.Count}");

            //Declarando uma lista
            OperacoesLista opLista = new OperacoesLista();
            List<string> estado = new List<string>{"BA"};
            string[] estadosArray = new string[2] {"SC", "MT"};

            //Adicionando elemento na lista
            estado.Add("SP");
            estado.Add("RJ");
            estado.Add("MA");
            //Acessando uma lista
            System.Console.WriteLine("---------------------------");
            System.Console.WriteLine($"Quantidade de elementos na lista: {estado.Count}");
            //Percorrendo a lista
                //Classe OperacoesLista
            opLista.ImprimirListaString(estado);

            //Removendo elemento da lista
            System.Console.WriteLine("---------------------------");
            System.Console.WriteLine("Removendo elemento da lista:");
            estado.Remove("MA");
            opLista.ImprimirListaString(estado);

            //Adicionar elementos de outra coleção
            System.Console.WriteLine("---------------------------");
            System.Console.WriteLine("Adicionar elementos de outra coleção:");
            estado.AddRange(estadosArray);
            opLista.ImprimirListaString(estado);

            //Adicionar elemento em um índice
            System.Console.WriteLine("---------------------------");
            System.Console.WriteLine("Adicionar elemento em um índice:");
            estado.Insert(1, "BH");
            opLista.ImprimirListaString(estado); 

            //Ordenação
            OperacoesArray op = new OperacoesArray();
            int[] array = new int[5] {6, 3, 7, 2, 8};
            int[] arrayCopia = new int[10];
            string[] arrayString = op.ConverterParaArrayString(array);

            int valorProcurado = 7;
            bool existe = op.Existe(array, valorProcurado);

            bool todosMaiorQue = op.TodosMaiorQue(array, valorProcurado);

            int valorAchado = op.ObterValor(array, valorProcurado);

            int indice = op.ObterIndice(array,valorProcurado);

            //Converter o tipo do array
            System.Console.WriteLine("---------------------------");
            System.Console.WriteLine("Converter o tipo do array: ");


            //Aumentando a capacidade do array em execução
            System.Console.WriteLine("---------------------------");
            System.Console.WriteLine("Aumentando a capacidade do array em execução: ");
            System.Console.WriteLine($"- Capacidade atual do array: {array.Length}");
            op.RedimensionarArray(ref array, array.Length * 2);
            System.Console.WriteLine($"- Capacidade atual do array após redimensionar: {array.Length}");

            //Encontrar um elemento e retornar o seu índice
            System.Console.WriteLine("---------------------------");
            System.Console.WriteLine("Encontrar um elemento e retornar o seu índice: ");
            if (indice > -1)
            {
                System.Console.WriteLine($"O índice do elemento {valorProcurado} é: {indice}");   
            }else
            {
                System.Console.WriteLine($"Valor {valorProcurado} não existente no {indice}");
            }

            //Encontrar um elemento e retornar o seu valor
            System.Console.WriteLine("---------------------------");
            System.Console.WriteLine("Encontrar um elemento e retornar o seu valor: ");
            if (valorAchado > 0)
            {
                System.Console.WriteLine($"Encontrei o valor {valorProcurado}");
            }else
            {
                System.Console.WriteLine($"Não encontrei o valor {valorProcurado}");
            }

            //Ver se atendem uma determinada condição
            System.Console.WriteLine("---------------------------");
            System.Console.WriteLine("Ver se atendem uma determinada condição: ");
            if (todosMaiorQue)
            {
                System.Console.WriteLine($"Todos os valores são maior que {valorProcurado}");
            }else
            {
                System.Console.WriteLine($"Existe valores que não são maiores do que {valorProcurado}");
            }

            //Ver se existe 
            System.Console.WriteLine("---------------------------");
            System.Console.WriteLine("Ver se existe: ");
            if (existe)
            {
                System.Console.WriteLine($"Encontrei o valor {valorProcurado}");
            } else
            {
                System.Console.WriteLine($"Não encontrei o valor {valorProcurado}");
            }


            System.Console.WriteLine("---------------------------");
            System.Console.WriteLine("Array original: ");
            op.ImprimirArray(array);

            //Bubble Sort
            op.OrdenarBubbleSort(ref array);

            System.Console.WriteLine("---------------------------");
            System.Console.WriteLine("Array ordenado Bubble Sort: ");
            op.ImprimirArray(array);

            //Ordenar com a classe Array
            op.Ordenar(ref array);

            System.Console.WriteLine("---------------------------");
             System.Console.WriteLine("Array antes da cópia: ");
             op.ImprimirArray(arrayCopia);

             op.Copiar(ref array, ref arrayCopia);

             System.Console.WriteLine("---------------------------");
             System.Console.WriteLine("Array depois da cópia: ");
             op.ImprimirArray(arrayCopia);

            // //Criando um array
            // int[] arrayInteiros = new int [3];

            // //Armazenando no array
            // arrayInteiros[0] = 10; //1
            // arrayInteiros[1] = 20; //2
            // arrayInteiros[2] = 30; //3

            // //Imprimir
            // System.Console.WriteLine("Com FOR: ");
            // for (int i = 0; i  < arrayInteiros.Length; i++)
            // {
            //     System.Console.WriteLine(arrayInteiros[i]);
            // }

            // System.Console.WriteLine("Com FOREACH: ");
            // foreach (int item in arrayInteiros)
            // {
            //     System.Console.WriteLine(item);
            // }
        }
    }
}