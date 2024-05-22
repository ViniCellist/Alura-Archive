using System.Text;
using ByteBankIO;

partial class Program
{
    static void LidandoComFileStreamDiretamente()
    {
        var enderecoDoArquivo = "contas.txt";

        using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var numeroDeBytesLidos = -1;
            var buffer = new byte[1024];
            numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
            while(numeroDeBytesLidos != 0)
            {
                fluxoDoArquivo.Read(buffer, 0, 1024);
                Console.WriteLine($"Bytes lidos: {numeroDeBytesLidos}");
                EscreverBuffer(buffer, numeroDeBytesLidos);
            }
            fluxoDoArquivo.Close();
            Console.ReadLine();
        }    
    }

    static void EscreverBuffer(byte[] buffer, int bytesLidos)
    {
        var utf8 = new UTF32Encoding();
        var texto = utf8.GetString(buffer, 0, bytesLidos);

        Console.Write(texto);

        // foreach(var meuByte in buffer)
        // {
        //     Console.Write(meuByte);
        //     Console.Write(" ");
        // }
    }

}