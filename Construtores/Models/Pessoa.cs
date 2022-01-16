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




        // //Modificadores
        // //Readonly
        // private readonly string nome1 = "Marina";
        // private readonly string sobrenome1;

        // public Pessoa1()
        // {
        //     nome1 = string.Empty;
        //     sobrenome1 = string.Empty;
        // }
        // //Com parametro  
        // public Pessoa1(string nome1, string sobrenome1)
        // {
        //     this.nome1 = nome1;
        //     this.sobrenome1 = sobrenome1;
        // }
        // public void Apresentar1(){
        //     // this.nome1 = "Teste";
        //     System.Console.WriteLine($"Olá, meu nome é {nome1} {sobrenome1}");
        // }
    }
}