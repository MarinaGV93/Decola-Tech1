namespace Construtores.Models
{
    public class Log
    {
        private static Log _log;
        public string PropriedadeLog { get; set; }

        //Construtor privado
        private Log()
        {
            
        }

        //Obter a instancia desse metodo
        public static Log GetInstance(){
            if (_log == null)
            {
                _log = new Log();
            }
            return _log;
        }
    }
}