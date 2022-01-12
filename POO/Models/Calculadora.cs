//Interfaces
using POO.Interfaces;

//Polimorfismo
//Em tempo de execuça
namespace POO.Models
{
    public class Calculadora : ICalculadora
    {
        // public int Div(int n1, int n2){
        //     return n1 / n2;
        // }
        // public int Mult(int n1, int n2){
        //     return n1 * n2;
        // }
        public int Somar(int n1, int n2){
            return n1 + n2;
        }
        public int Somar(int n1, int n2, int n3){
            return n1 + n2 + n3;
        }
        public int Sub(int n1, int n2){
            return n1 + n2;
        }
    }
}