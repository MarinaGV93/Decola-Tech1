using System;
namespace Métodos
{
    public class Out
    {
        static void Dividir(int x, int y, out int resultado, out int resto){
            resultado = x / y;
            resto = x % y;
        }
        public static void Dividir(){
            Dividir(10,3,out int resultado, out int resto);
            Console.WriteLine("{0} {1}", resultado, resto); //3 1
        }
    }
}