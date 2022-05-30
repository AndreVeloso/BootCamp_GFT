using System;
using System.Collections.Generic;

public class Program
{
    static void Demo6()
    {
        int[] numeros = new int[] { 0, 2, 4, 6, 8 };
        System.Console.WriteLine($"Digite o numero que gostaria de encontrar: ");
        var numero = int.Parse(System.Console.ReadLine());
        var idxEncontrado = EncontrarNumero(numeros, numero);
        if (idxEncontrado >= 0)
        {
            System.Console.WriteLine($"O numero digitado está na posição: {idxEncontrado}");
        }
        else
        {
            System.Console.WriteLine($"O numero digitado não foi encontrado");
        }
    }
    static void Demo5()
    {
        int[] pares = new int[] { 0, 2, 4, 6, 8 };
        MudarParaImpar(pares);

        System.Console.WriteLine($"Os impares {string.Join(", ", pares)}");
    }
    static void Demo4()
    {
        string nome = "Andre";
        TrocarNome(nome, "José");
        System.Console.WriteLine($"O novo nome é {nome}");
        /// <summary>
        /// Aqui a copia se perde quando acontece o descarte das variaveis locais
        /// </summary>
    }
    static void Demo3()
    {
        /// <summary>
        /// Fazer com criação de arquivo Struct e fazer chamada pelos termos de struct
        /// Fazer ficarem na Stack...
        /// </summary>
    }
    static void Demo2()
    {
        Pessoa p1 = new Pessoa() { };
        p1.Nome = "Andre";
        p1.Idade = 28;
        p1.Documento = "1234";

        Pessoa p2 = p1.Clone();

        TrocarNome(p1, "José");

        System.Console.WriteLine($@"
        O nome de p1 é :{p1.Nome}
        O nome de p2 é :{p2.Nome}
         ");
    }
    static void Demo1()
    {
        int a = 2;
        a = Adicionar20(a);

        Console.WriteLine($"O valor da variável a é {a}");
    }
    static int Adicionar20(int x)
    {
        return x + 20;
    }

    static void TrocarNome(Pessoa p1, string nomeNovo)
    {
        p1.Nome = nomeNovo;
    }
    static void TrocarNome(string nome, string nomeNovo)
    {
        nome = nomeNovo;
    }
    static void MudarParaImpar(int[] pares)
    {
        for (int i = 0; i < pares.Length; i++)
        {
            pares[i] = pares[i] + 1;
        }
    }
    static int EncontrarNumero(int[] numeros, int numero)
    {
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] == numero)
                return i;
        }
        return -1;
    }

    static bool EncontrarPessoa(List<Pessoa> pessoas, Pessoa pessoa)
    {
        foreach (var item in pessoas)
        {
            if (item.Nome == pessoa.Nome)
            {
                return true;
            }

        }
        return false;
    }
    public static void Main()
    {
        List<Pessoa> pessoas = new List<Pessoa>()
        {
            new Pessoa(){Nome = "Andre"},
            new Pessoa(){Nome = "José"},
            new Pessoa(){Nome = "Maria"},
            new Pessoa(){Nome = "Fabiana"},
            new Pessoa(){Nome = "Eduardo"},
        };

        System.Console.WriteLine("Digite a pessoa que gostaria de localizar:");
        var nome = System.Console.ReadLine();
        var pessoa = new Pessoa() { Nome = nome };
        var encontrado = EncontrarPessoa(pessoas, pessoa);
        if (encontrado)
        {
            System.Console.WriteLine("Pessoa localizada!");
        }
        else
        {
            System.Console.WriteLine("Pessoa não localizada!");
        }

    }

}
