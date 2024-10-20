using System;
using ConsoleApp.Modelo;

namespace ConsoleApp.Repositorio;

public class RepositorioCidades
{
    List <Cidade> cidades = [];

    public void Inserir(Cidade cidade)
    {
        cidades.Add(cidade);
    }
}
