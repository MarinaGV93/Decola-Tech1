//Polimorfismo
//Em tempo de execuçao

namespace POO.Models
{
    public class Calculadora
    {
        public int Somar(int n1, int n2){
            return n1 + n2;
        }
        public int Somar(int n1, int n2, int n3){
            return n1 + n2 + n3;
        }
    }
}