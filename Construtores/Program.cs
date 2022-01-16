using System;
using Construtores.Models;

namespace Construtores
{
    class Program
    {
        public delegate void Operacao(int x, int y);
        static void Main(string[] args){
            System.Console.WriteLine("-----------------------");
            System.Console.WriteLine("Delegate:");
            Operacao op = Calculadora.Somar;
            // Operacao op = new Operacao(Calculadora.Somar);
            // op.Invoke(10,10);
            // op(10,10);
            System.Console.WriteLine("Mult Cast Delegate:");
            op += Calculadora.Sub;
            op.Invoke(10,10);

            System.Console.WriteLine("-----------------------");
            System.Console.WriteLine("Modificadores - Constante:");
            const double pi = 3.14;
            System.Console.WriteLine(pi);
            // pi = 0;

            System.Console.WriteLine("-----------------------");
            System.Console.WriteLine("Get e Set:");
            Data data = new Data();
            // data.SetMes(2);
            // data.SetMes(20);
            data.Mes = 12;
            data.Mes = 20;
            //System.Console.WriteLine(data.Mes);
            data.ApresentarMes();

            System.Console.WriteLine("-----------------------");
            System.Console.WriteLine("Construtores - com parâmetros:");
            Pessoa p1 = new Pessoa("Marina", "GV");
            p1.Apresentar();

            System.Console.WriteLine("-----------------------");
            System.Console.WriteLine("Construtores - sem parâmetros:");
            Pessoa p2 = new Pessoa();
            p2.Apresentar();

            System.Console.WriteLine("-----------------------");
            System.Console.WriteLine("Chamando construtor privado:");
            Log log = Log.GetInstance();

            log.PropriedadeLog = "Teste instancia";

            System.Console.WriteLine("-----------------------");
            System.Console.WriteLine("Chamando construtor privado:");
            Log log2 = Log.GetInstance();
            System.Console.WriteLine(log2.PropriedadeLog);

            System.Console.WriteLine("-----------------------");
            System.Console.WriteLine("Construtores de herança:");
            Aluno a1 = new Aluno("Marina", "GV", "Teste");
            a1.Apresentar();
            System.Console.WriteLine();
        }
    }
}
