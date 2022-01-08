using System;

namespace Revisao{

    class Program{

        static void Main(string[] args){

            Aluno[] alunos = new Aluno[5];
            
            //Para incluir na ordem
            var indiceAluno = 0;
            string opcaoUsuario = OpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do aluno:");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine();

                        Console.WriteLine("Informe a nota do aluno:");

                        // //Converter em decimal
                        // var nota = decimal.Parse(Console.ReadLine());

                        // aluno.Nota = nota;

                        //Consegue ou nao fazer a conversao
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        } else
                        {
                            throw new ArgumentException("O valor da nota deve ser decimal.");
                        }

                        //Colocar no array
                        alunos[indiceAluno] = aluno;

                        Console.WriteLine();

                        Console.WriteLine("ALUNO ADICIONADO.");
                        
                        //Incrementar
                        indiceAluno++;
                        break;
                    case "2":
                        foreach (var a in alunos)
                        {
                            if (!string.IsNullOrEmpty(a.Nome))
                            {
                                Console.WriteLine($"ALUNO {a.Nome} - NOTA {a.Nota}");
                            }
                        }
                        Console.WriteLine("-------------------------------------------");
                        break;
                    case "3":
                        //Média geral
                        break;
                    default:
                    //Esta fora das opcoes
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = OpcaoUsuario();

            }
        }

        private static string OpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X");

            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();

            Console.WriteLine();

            return opcaoUsuario;
        }
    }
}

    
    