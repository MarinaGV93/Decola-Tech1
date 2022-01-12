using System.IO;
using System.Collections.Generic;

namespace POO.Helper
{
    public class FileHelper
    {
        //Listar diretorios
        //Chamar a classe directory 
        public void ListarDiretorio(string caminho){
            var retornoCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);

            //Percorrer e imprimir o array
            foreach (var retorno in retornoCaminho)
            {
                System.Console.WriteLine(retorno);
            }
        }
        public void ListarArquivos(string caminho){
        //Listar arquivos
        var retornoArquivos = Directory.GetFiles(caminho, "*", SearchOption.AllDirectories);

        //Percorrer e imprimir o array
            foreach (var retorno in retornoArquivos)
            {
                System.Console.WriteLine(retorno);
            }
        }

        //Criar diretorio
        public void CriarDiretorio(string caminho){
            var retornoCriar = Directory.CreateDirectory(caminho);
            System.Console.WriteLine(retornoCriar.FullName);
        }

        //Apagar diretorio
        public void ApagarDiretorio(string caminho, bool apagarArquivos){
            Directory.Delete(caminho, apagarArquivos);
        }

        //Criar arquivo
        public void CriarArquivoTexto(string caminho, string conteudo){
            if (!File.Exists(caminho))
            {
                File.WriteAllText(caminho, conteudo);
            }
        }

        //Criar arquivo com stream
        public void CriarArquivoTextoStream(string caminho, List<string> conteudo){
            //Terminar a stream depois de usar
            using (var stream = File.CreateText(caminho)){

                foreach (var linha in conteudo)
                {
                    //Escrever linha
                    stream.WriteLine(linha);
                }
            }   
        }

        //Adicionar novas linhas
        public void AdicionarTexto(string caminho, string conteudo){
            File.AppendAllText(caminho, conteudo);
        }

        //Adicionar novas linhas com stream
        public void AdicionarTextoStream(string caminho, List<string> conteudo){
            //Terminar a stream depois de usar
            using (var stream = File.AppendText(caminho)){

                foreach (var linha in conteudo)
                {
                    //Escrever linha
                    stream.WriteLine(linha);
                }
            }   
        }

        //Lendo arquivos
        public void LerArquivo(string caminho){
            var conteudo = File.ReadAllLines(caminho);

            foreach (var linha in conteudo)
            {
                System.Console.WriteLine(linha);
            }
        }

        //Lendo arquivos com stream
        public void LerArquivoStream(string caminho){
            //Leitura da linha atual
            string linha = string.Empty;
            
            using  (var stream = File.OpenText(caminho)){
                while ((linha == stream.ReadLine()) != null)
                {
                     System.Console.WriteLine(linha);
                }
            }
        }

        //Mover arquivo
        public void MoverArquivo(string caminho, string novoCaminho, bool sobrescrever){
            File.Move(caminho, novoCaminho, sobrescrever);
        }

        //Copiando arquivo
        public void CopiarArquivo(string caminho, string novoCaminho, bool sobrescrever){
            File.Copy(caminho, novoCaminho, sobrescrever);
        }

        //Deletar arquivo
        public void DeletarArquivo(string caminho){
            File.Delete(caminho);
        } 
    }
}