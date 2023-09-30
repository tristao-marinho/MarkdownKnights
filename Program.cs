using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Verifica se foi fornecido o argumento esperado.
        if (args.Length < 1)
        {
            Console.WriteLine("Uso: programa.exe <caminho_com_nome_do_arquivo>");
            return;
        }

        // Recupera o caminho completo do arquivo dos argumentos.
        string caminhoArquivo = args[0];

        // Obtém o nome do arquivo a partir do caminho completo.
        string nomeArquivo = Path.GetFileName(caminhoArquivo);

        // Obtém o diretório a partir do caminho completo.
        string diretorio = Path.GetDirectoryName(caminhoArquivo);

        // Verifica se o diretório não existe e o cria, se necessário.
        if (!Directory.Exists(diretorio))
        {
            Directory.CreateDirectory(diretorio);
        }

        // Lê a entrada padrão (stdin) até o final.
        string input = Console.In.ReadToEnd();

        // Formata o texto como Markdown.
        string markdownText = FormatAsMarkdown(input);

        // Cria o caminho completo do arquivo.
        string caminhoCompleto = Path.Combine(diretorio, nomeArquivo);

        // Escreve o texto formatado no arquivo especificado.
        File.WriteAllText(caminhoCompleto, markdownText);

        Console.WriteLine($"Texto formatado e salvo em {caminhoCompleto}.");
    }

    static string FormatAsMarkdown(string input)
    {
        // Implemente aqui a lógica de formatação desejada.
        // Por exemplo, se quiser que cada linha seja precedida por um asterisco (*):
        // string[] lines = input.Split('\n');
        // for (int i = 0; i < lines.Length; i++)
        // {
        //     lines[i] = $"* {lines[i]}";
        // }
        // return string.Join("\n", lines);

        // Para este exemplo, vamos apenas encapsular o texto com blocos de código Markdown.
        return $"```\n{input}\n```";
    }
}
