namespace Construtores.Models
{
    public class Pessoa
    {
        //Propriedades
        private string nome;
        private string sobrenome;

        //Construtores = ctor
        //Sem parametro/Padrão
        public Pessoa()
        {
            nome = string.Empty;
            sobrenome = string.Empty;
        }
        //Com parametro  
        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            System.Console.WriteLine("Construtor classe pessoa");
        }

        public void Apresentar(){
            System.Console.WriteLine($"Olá, meu nome é {nome} {sobrenome}");
        }
    }
}