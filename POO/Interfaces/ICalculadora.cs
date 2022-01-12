namespace POO.Interfaces
{
    public interface ICalculadora
    {
         int Somar(int n1, int n2);
         int Sub(int n1, int n2);

         //Com implementaçao de metodo
         int Mult(int n1, int n2){
             return n1 * n2;
         }
         int Div(int n1, int n2){
             return n1 / n2;
         }
    }
}