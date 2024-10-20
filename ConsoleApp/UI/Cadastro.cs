using System;
using ConsoleApp.Modelo;

namespace ConsoleApp.UI;

public class Cadastro
{
    public static Cidade CadastroCidade()
    {
        Cidade cidade = new();

        Console.Write("Id: ");
        cidade.IdCidade = Console.Read();

        Console.Write("Nome: ");
        cidade.NomeCidade = Console.ReadLine();

        Console.Write("CEP: ");
        cidade.Cep = Console.ReadLine();

        return cidade;
        
    }
}
