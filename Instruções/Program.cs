using System;

namespace Instrucoes{
    class Program{
        public static string? TaskExtensions { get; private set; }

        static void Declaracoes(){
            int a;
            int b = 2, c = 3;
            //Nao pode mudar o valor 
            const int d = 4;
            a = 1;
            Console.WriteLine(a + b + c + d);
        }
        static void InstrucaoIf(string[] argum){
            if (argum.Length == 0){
                Console.WriteLine("Nenhum argumento");
            }else if (argum.Length == 1){
                Console.WriteLine("Um argumento");
            }else
            {
                Console.WriteLine($"{argum.Length} argumentos");
            }
        }
        static void InstrucaoSwitch(string[] argum){
            int numeroDeArgumentos = argum.Length;
            switch (numeroDeArgumentos){
                case 0:
                    Console.WriteLine("Nenhum argumento");
                    break;
                case 1:
                    Console.WriteLine("Um argumento");
                    break;
                default:
                    Console.WriteLine($"{numeroDeArgumentos} argumentos");
                break;
            }
        }
        static void InstrucaoWhile(string[] argum){
            int i = 0;
            while (i < argum.Length)
            {
                 Console.WriteLine(argum[i]);
                 i++;
            }
        }
        static void InstrucaoDo(string[] argum){
            string texto;
            do
            {
                TaskExtensions = Console.ReadLine();
                Console.WriteLine(texto);
            } while (!string.IsNullOrEmpty(texto));
        }
        static void InstrucaoFor(string[] argum){
            for (int i = 0; i < argum.Length; i++)
            {
                Console.WriteLine(argum[i]);
            }
        }
        static void InstrucaoForeach(string[] argum){
            foreach (string s in argum)
            {
                Console.WriteLine(s);
            }
        }
        static void InstrucaoBreak(string[] argum){
            while (true)
            {
                 string s = Console.ReadLine();

                 if (string.IsNullOrEmpty(s))
                    break;

                Console.WriteLine(s);
            }
        }
        static void InstrucaoContinue(string[] argum){
            for (int i = 0; i < argum.Length; i++)
            {
                //Começar com /
                if (argum[i].StartsWith("/"))
                    continue;

                Console.WriteLine(argum[i]);
            }
        }
        static void InstrucaoReturn(){
            //Metodo alinhado
            int Somar(int a, int b){
                return a + b;
            }

            Console.WriteLine(Somar(1,2));
            Console.WriteLine(Somar(3,4));
            Console.WriteLine(Somar(5,6));

            //Quando coloca return quando tem void, ele vai retornar algo. Ele para a execução quando tem return
            return;
        }
        static void InstrucaoTryCatchFinallyThrow(string[] argum){

            //Metodo alinhado
            double Dividir(double x, double y){
                if (y == 0)
                    throw new DivideByZeroException();
                return x/y;
            }

            //Vai tentar fazer
            try
            {
                 if (argum.Length != 2){
                     throw new InvalidOperationException("Informe 2 numeros");
                 }
                //String para double
                 double x = double.Parse(argum[0]);
                 double y = double.Parse(argum[1]);

                 Console.WriteLine(Dividir(x,y));
            }
            //Se der algum erro
            catch (InvalidOperationException e)
            {
                //Message = Informe 2 numeros
                Console.WriteLine(e.Message);
            }
            //Cai aqui se y == 0 e se for "texto"
            catch(Exception e){
                Console.WriteLine($"Erro genérico: {e.Message}");
            }
            //Sempre cai aqui
            finally{
                Console.WriteLine("Até breve.");
            }
        }
        static void InstrucaoUsing(string[] argum){
            // //Quando tiver operação de IO (input e output), como BD, como escrita e leitura de arquivos, esses objetos sao do tipo "nao gerenciado", e ao final do uso precisa falar que nao precisa mais discar essa memoria 
            // System.IO.TextWriter w;
            // w = System.IO.File.CreateText("teste.txt");

            // w.WriteLine("yz");

            // //Eliminar o objeto
            // w.Dispose();
            
            //OU

            //Criar um arquivo e escrever algumas linhas nele
            using (System.IO.TextWriter w = System.IO.File.CreateText("teste.txt")){
                w.WriteLine("Line 1");
                w.WriteLine("Line 2");
                w.WriteLine("Line 3");
            }
        }
    }
}