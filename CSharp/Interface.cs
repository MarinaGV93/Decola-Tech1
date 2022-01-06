using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    interface IAnimal
    {
        void Nome(string nome);
        void Dono(String nomeDono);
        void Especie(String especie);
    }

    class Animal : IAnimal
    {
        //Metodos
        public string Nome { get; set; }
        public string NomeDono { get; set; }
        public string Especie { get; set; }    

        void IAnimal.Nome(string nome)
        {
            this.Nome = nome;
        }
        void IAnimal.Dono(string nomeDono)
        {
            this.NomeDono = nomeDono;
        }
        void IAnimal.Especie(string especie)
        {
            this.Especie = especie; 
        }
    }
}
