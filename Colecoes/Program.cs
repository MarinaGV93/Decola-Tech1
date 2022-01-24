using System;
using Colecoes.Helper;

namespace Colecoes{
    class Program{
        static void Main(string[] args){

            //Ordenação
            //Bubble Sort
            OperacoesArray op = new OperacoesArray();
            int[] array = new int[5] {6, 3, 7, 2, 8};

            System.Console.WriteLine("---------------------------");
            System.Console.WriteLine("Array original: ");
            op.ImprimirAArray(array);

            System.Console.WriteLine("---------------------------");
            // op.OrdenarBubbleSort(ref array);
            
            //Ordenar com a classe Array
            op.Ordenar(ref array);

            System.Console.WriteLine("Array ordenado Bubble Sort: ");
            op.ImprimirAArray(array);

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