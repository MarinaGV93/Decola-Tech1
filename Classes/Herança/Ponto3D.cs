namespace Classes.Herança
{
    //: = herdar
    public class Ponto3D : Ponto
    {
        public int z;
        public Ponto3D(int x, int y, int z) : base(x,z){
            this.z = z;
            CalcularDistancia();
        }
        //static = pertence a classe
        public static void Calcular(){
            //Faz alguma coisa
        }
        public override void CalcularDistancia3(){
            //Faz outra coisa
            base.CalcularDistancia3();
        }

    }
}