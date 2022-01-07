using System;

Console.WriteLine("Informe a opção desejada: ");
Console.WriteLine("1 - Inserir novo aluno");
Console.WriteLine("2 - Listar alunos");
Console.WriteLine("3 - Calcular média geral");
Console.WriteLine("X");
Console.WriteLine();

string opcaoUsuario = Console.ReadLine();

while (opcaoUsuario.ToUpper() != "X")
{
    switch (opcaoUsuario)
    {
        case "1":
            //Adicionar alunos
            break;
        case "2":
            //Listar alunos
            break;
        case "3":
            //Média geral
            break;
        default:
        //Esta fora das opcoes
            throw new ArgumentOutOfRangeException();
    }

    Console.WriteLine("Informe a opção desejada: ");
    Console.WriteLine("1 - Inserir novo aluno");
    Console.WriteLine("2 - Listar alunos");
    Console.WriteLine("3 - Calcular média geral");
    Console.WriteLine("X");
    Console.WriteLine();

    Console.ReadLine();

}