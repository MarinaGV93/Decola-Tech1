namespace Colecoes{
    class Program{
        static void Main(string[] args){
            //Criando um array
            int[] arrayInteiros = new int [3];

            //Armazenando no array
            arrayInteiros[0] = 10; //1
            arrayInteiros[1] = 20; //2
            arrayInteiros[2] = 30; //3

            //Imprimir
            System.Console.WriteLine("Com FOR: ");
            for (int i = 0; i  < arrayInteiros.Length; i++)
            {
                System.Console.WriteLine(arrayInteiros[i]);
            }

            System.Console.WriteLine("Com FOREACH: ");
            foreach (int item in arrayInteiros)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}