using System;

namespace Models;

public class Senha
{
    // Atributos
    public int Numero { get; set; }
    public DateTime HoraEmissao { get; set; }
    public DateTime? HoraAtendimento { get; set; }

    // Métodos
    public void RegistrarAtendimento()
    {
        HoraAtendimento = DateTime.Now;
    }

    public double TempoDeEspera()
    {
        if (HoraAtendimento.HasValue)
        {
            return (HoraAtendimento.Value - HoraEmissao).TotalMinutes;
        }
        else
        {
            return 0;
        }
    }
}
