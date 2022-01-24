using System;
using Colecoes.Helper;

namespace Colecoes{
    class Program{
        static void Main(string[] args){

            //Ordenação
            
            OperacoesArray op = new OperacoesArray();
            int[] array = new int[5] {6, 3, 7, 2, 8};
            int[] arrayCopia = new int[10];

            int valorProcurado = 2;
            bool existe = op.Existe(array, valorProcurado);

            //Ver se existe 
            System.Console.WriteLine("---------------------------");
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