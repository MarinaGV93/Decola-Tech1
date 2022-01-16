//Evento

namespace Construtores.Models
{
    public class Matematica
    {
        public int X { get; set; }  
        public int Y { get; set; }

        public Matematica(int x, int y){
            X = x;
            Y = y;

            //Inscrever
            Calculadora.EventoCalculadora += EventHandler;
        }
        public void Somar(){
            Calculadora.Somar(X, Y);
        }
        
        //Inscrever eventos. Para ser executado apos o termino da açao
        public void EventHandler(){
            System.Console.WriteLine("Método execcutado.");
        }
    }
}