using System;

namespace Models;

public class Servico
{
    // Atributos
    public required int Id { get; set; }
    public required string Nome { get; set; }
    public string? Descricao { get; set; }

    // Métodos
    public void ExibirInformacoes()
    {
        Console.WriteLine("Id: " + Id);
        Console.WriteLine("Nome: " + Id);
        if (Descricao != null)
        {
            Console.WriteLine("Desc: " + Id);
        }
    }
}
