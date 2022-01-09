//Classe abstrata

namespace POO.Models
{
    public class Corrente : Conta
    {   
        //Sobrescrever o metodo abstrato
        public override void Creditar(double valor)
        {
            //base = o atributo pertence a classe pai (Conta)
            base.saldo = valor;
        }
    }
}