using System;
using System.Collections.Generic;
using System.IO;


Console.WriteLine("\n\nPressione [enter] para finalizar");
Console.ReadLine();

static void CriarCsv()
{
    var path = Path.Combine(
    Environment.CurrentDirectory,
    "Saida"
    );

    var pessoas = new List<Pessoa>(){
            new Pessoa()
            {
                Nome = "José da Silva",
                Email = "js@gmail.com",
                Telefone = 123456,
                Nascimento = new DateOnly(year: 1970, month: 2, day: 14)
            },
            new Pessoa(){
                Nome = "Felipe da Silva",
                Email = "fl´p@gmail.com",
                Telefone = 345123,
                Nascimento = new DateOnly(year: 1988, month: 11, day: 7)

            },
            new Pessoa(){
                Nome = "Vinicius de Oliveira",
                Email = "vinicin@gmail.com",
                Telefone = 456345,
                Nascimento = new DateOnly(year: 1995, month: 6, day: 28)
                
            },
            new Pessoa(){
                Nome = "Andre Veloso",
                Email = "js@gmail.com",
                Telefone = 123456,
                Nascimento = new DateOnly(year: 1993, month: 9, day: 28)

            },
            new Pessoa(){
                Nome = "José da Silva",
                Email = "js@gmail.com",
                Telefone = 123456,
                Nascimento = new DateOnly(year: 2000, month: 5, day: 12)

            },

    };

    var di = new DirectoryInfo(path);
    if(!di.Exists)
    {
        di.Create();
        path = Path.Combine(path, "usuarios.csv");
    }
    using var sw = new StreamWriter(path);
    sw.WriteLine("nome,email,telefone,nascimento");
    foreach (var pessoa in pessoas)
    {
        var linha = $"{pessoa.Nome},{pessoa.Email},{pessoa.Telefone},{pessoa.Nascimento}";
        sw.WriteLine(linha);
    }

}


static void LerCsv()
{
    var path = Path.Combine(
    Environment.CurrentDirectory,
    "Entrada",
    "usuarios-exportacao.csv");
    if (File.Exists(path))
    {
        using var sr = new StreamReader(path);
        var cabecalho = sr.ReadLine()?.Split(',');
        while (true)
        {
            var registro = sr.ReadLine()?.Split(',');
            if (registro == null) break;
            if (cabecalho.Length != registro.Length)
            {
                Console.WriteLine("Arquivo fora do padrão");
                break;
            }
            for (int i = 0; i < registro.Length; i++)
            {
                Console.WriteLine($"{cabecalho?[i]}:{registro[i]}");
            }
        }
    }
}

class Pessoa
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public int Telefone { get; set; }
    public DateOnly Nascimento { get; set; }
}