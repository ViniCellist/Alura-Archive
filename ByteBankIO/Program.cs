using System.Text;
using ByteBankIO;

partial class Program
{
    static void Main(string[] args)
    {
        var enderecoDeArquivo = "contas.txt";

        using(var fluxoDeArquivo = new FileStream(enderecoDeArquivo, FileMode.Open))
        {
            var leitor = new StreamReader(fluxoDeArquivo);

            // var linha = leitor.ReadLine();

            // var texto = leitor.ReadToEnd();

            // var numero = leitor.Read();

            while(!leitor.EndOfStream)
            {
                var linha = leitor.ReadLine();
                Console.WriteLine(linha);
            }

            
        }

        Console.ReadLine();  
    }

}