using System;

namespace Colecoes.Helper
{
    public class OperacoesArray
    {
        //Bubble Sort
        public void OrdenarBubbleSort(ref int[] array)
        {
            var temp = 0;
            for (int i = 0; i < array.Length; i++) //Percorrer o array
            {
                for (int j = 0; j < array.Length - 1; j++) //Percorrer o numero
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        //Metodos em comum para os Arrays 
        public void ImprimirArray(int[] array)
        {
            //Imprimir em 1 linha
            var linha = string.Join(", ", array);

            System.Console.WriteLine(linha);

            // for (int i = 0; i < array.Length; i++)
            // {
            //     System.Console.WriteLine(array[i]);
            // }
        }

        public void Ordenar(ref int[] array)
        {
            //Chamar a classe array
            Array.Sort(array);
        }

        public void Copiar(ref int[] array, ref int[] arrayDestino)
        {
            Array.Copy(array, arrayDestino, array.Length); //Copiar tudo
        }

        //Ver se existe 
        public bool Existe(int[] array, int valor) //valor = se é o elemento que existe
        {
            return Array.Exists(array, elemento => elemento == valor); //elemento = expressao que quer que retorne
        }
    }
}