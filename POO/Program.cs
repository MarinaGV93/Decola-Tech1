using System;
using POO.Models;
using POO.Interfaces;
using POO.Helper;
using System.IO;
using System.Collections.Generic;

namespace POO
{
    class Program{
        static void Main(string[] args){
            var caminho = "C:\\POO";
            FileHelper helper = new FileHelper();
            //Armazenar o caminho do arquivo
            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
            var caminhoArquivoMover = Path.Combine(caminho, "arquivo-teste.txt");
            var caminhoArquivoCopia = Path.Combine(caminho, "arquivo-teste-bkp.txt");
            var novoCaminho = Path.Combine(caminho, "Pasta Teste 2", "arquivo-teste-stream.txt");
            var ListaString = new List<string>{"Linha 1", "Linha 2", "Linha 3"};
            var ListaStringContinuacao = new List<string>{"Linha 4", "Linha 5", "Linha 6"};
            
            System.Console.WriteLine("--------------------------------------");
            System.Console.WriteLine("Deletar arquivo:");
            helper.DeletarArquivo(caminhoArquivoCopia); 

            System.Console.WriteLine("--------------------------------------");
            System.Console.WriteLine("Copiando arquivo:");
            helper.CopiarArquivo(caminhoArquivoMover, caminhoArquivoCopia, false); 

            System.Console.WriteLine("--------------------------------------");
            System.Console.WriteLine("Mover arquivo:");
            helper.MoverArquivo(caminhoArquivo, novoCaminho, false); 

            System.Console.WriteLine("--------------------------------------");
            System.Console.WriteLine("Lendo arquivos com stream:");
            helper.LerArquivoStream(caminhoArquivo); 

            System.Console.WriteLine("--------------------------------------");
            System.Console.WriteLine("Adicionar novas linhas com stream:");
            helper.AdicionarTextoStream(caminhoArquivo, ListaStringContinuacao); 

            System.Console.WriteLine("--------------------------------------");
            System.Console.WriteLine("Criar arquivo texto com stream:");
            helper.CriarArquivoTextoStream(caminhoArquivo, ListaString); 

            System.Console.WriteLine("--------------------------------------");
            System.Console.WriteLine("Criar arquivo texto:");
            helper.CriarArquivoTexto(caminhoArquivo, "Olá, testando!!"); 

            System.Console.WriteLine("--------------------------------------");
            System.Console.WriteLine("Apagar diretorio:");
            var caminhoPathCombine1 = Path.Combine(caminho, "Pasta teste 1");
            helper.ApagarDiretorio(caminhoPathCombine1, true); 

            System.Console.WriteLine("--------------------------------------");
            System.Console.WriteLine("Criar diretorio:");
            var caminhoPathCombine = Path.Combine(caminho, "Pasta teste 3", "SubPasta");
            System.Console.WriteLine("Criando diretório: " + caminhoPathCombine);
            helper.CriarDiretorio(caminhoPathCombine); 

            System.Console.WriteLine("--------------------------------------");
            System.Console.WriteLine("Listar arquivo:");
            helper.ListarArquivos(caminho);

            System.Console.WriteLine("--------------------------------------");
            System.Console.WriteLine("Listar diretorio:");
            helper.ListarDiretorio(caminho);

            System.Console.WriteLine("--------------------------------------");
            System.Console.WriteLine("Interface:");
            ICalculadora calc1 = new Calculadora();
            System.Console.WriteLine(calc1.Somar(10,20));

            System.Console.WriteLine("--------------------------------------");
            System.Console.WriteLine("Classe Object - Indiretamente:");
            Computador comp = new Computador();
            System.Console.WriteLine(comp.ToString());

            System.Console.WriteLine("--------------------------------------");
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