using System;
using CSharp;
using interface;


namespace CSharp
{
    class Program
    {
        static void Main(String[] args)
        {
            //Enum
            var pessoa = (Pessoas)0;
            Pessoas pessoa2 = Pessoas.Marina;

            //Objeto
            Pessoa person = new Pessoa();
            person.Nome = "Marina";
            person.Estado = "SP";
            person.Idade = 28;

            var person2 = new Pessoa();
            person2.Nome = "Julia";
            person2.Estado = "SP";
            person2.Idade = 24;

            Animal animal = new Animal();
            animal.Nome = "Fiona";
            animal.NomeDono = "Marina";
            animal.Especie = "Cachorro"
        }
    }
}
