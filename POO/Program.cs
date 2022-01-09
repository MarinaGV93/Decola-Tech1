using System;
using POO.Models;


namespace POO
{
    class Program{
        static void Main(string[] args){
            System.Console.WriteLine("Classes abstratas:");
            Corrente c = new Corrente();
            c.Creditar(100);

            c.ExibirSaldo();

            System.Console.WriteLine("--------------------------------------");
            System.Console.WriteLine("Polimorfismo - Em tempo de execuçao: ");
            
            Aluno a2 = new Aluno();
            a2.Nome = "Bob";
            a2.Idade = 10;
            a2.Nota = 10;
            a2.Apresentar();

            Professor p3 = new Professor();
            p3.Nome = "Fred";
            p3.Idade = 40;
            p3.Salario = 2000;
            p3.Apresentar();

            System.Console.WriteLine("--------------------------------------");
            System.Console.WriteLine("Polimorfismo - Em tempo de compilaçao: ");
            
            Calculadora calc = new Calculadora();
            System.Console.WriteLine($"Resultado da 1ª soma: {calc.Somar(10,10)}");
            System.Console.WriteLine($"Resultado da 2ª soma: {calc.Somar(10,10,10)}");

            System.Console.WriteLine("--------------------------------------");
            System.Console.WriteLine("Herança: ");

            Aluno a1 = new Aluno();
            a1.Nome = "Bob";
            a1.Idade = 10;
            a1.Nota = 10;
            a1.Apresentar();

            Professor p2 = new Professor();
            p2.Nome = "Fred";
            p2.Idade = 40;
            p2.Salario = 2000;
            p2.Apresentar();

            System.Console.WriteLine("--------------------------------------");
            System.Console.WriteLine("Encapsulamento - Valores válidos:");
            
            Retangulo r = new Retangulo();
            r.DefinirMedidas(30,30);
            System.Console.WriteLine($"Área: {r.ObterArea()}");

            System.Console.WriteLine("--------------------------------------");
            System.Console.WriteLine("Encapsulamento - Valores inválidos:");
            
            Retangulo r2 = new Retangulo();
            r2.DefinirMedidas(0,0);
            System.Console.WriteLine($"Área: {r2.ObterArea()}");

            System.Console.WriteLine("--------------------------------------");
            System.Console.WriteLine("Abstraçao:");
        
            Pessoa p1 = new Pessoa();

            p1.Nome = "Bob";
            p1.Idade = 20;

            p1.Apresentar();

        }
    }
    
}