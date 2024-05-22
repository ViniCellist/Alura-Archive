using System.Text;
using ByteBankIO;

class Program
{
    static void Main(string[] args)
    {
        var enderecoDoArquivo = "contas.txt";
        var numeroDeBytesLidos = -1;

        var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);

        var buffer = new byte[1024];

        numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);

        while(numeroDeBytesLidos != 0)
        {
            fluxoDoArquivo.Read(buffer, 0, 1024);
            EscreverBuffer(buffer);
        }

        Console.ReadLine();
    }

    static void EscreverBuffer(byte[] buffer)
    {
        var utf8 = new UTF32Encoding();
        var texto = utf8.GetString(buffer);
        foreach(var meuByte in buffer)
        {
            Console.Write(meuByte);
            Console.Write(" ");
        }
    }

}