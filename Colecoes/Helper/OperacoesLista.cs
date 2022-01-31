using System.Collections.Generic;

namespace Colecoes.Helper
{
    public class OperacoesLista
    {
        public void ImprimirListaString(List<string> lista)
        {
            foreach (var item in lista)
            {
                System.Console.WriteLine(item);
            } 
            System.Console.WriteLine();
                //OU 
            for (int i = 0; i < lista.Count; i++)
            {
                System.Console.WriteLine($"Índice {i}, valor: {lista[i]}");
            }
        }
    }
}