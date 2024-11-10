using System;

namespace Models;

public class Usuario
{
    // Atributos
    public int Id { get; set; }
    public string NomeDeUsuario { get; set; }
    public string Senha { get; set; }
    public string Nome { get; set; }
    public string SobreNome { get; set; }
    private Dictionary<string, bool> niveisDeAcesso = new Dictionary<string, bool>();

    // Métodos
    public void ConfigurarAcesso(string modulo, bool acesso)
    {
        niveisDeAcesso[modulo] = acesso;
    }

    public void RegistrarUsuario(){
        Console.WriteLine("Usuario: " + NomeDeUsuario);
        Console.WriteLine("Registrado Com Sucesso");
    }
    public void ExibirInformacoes()
    {
        Console.WriteLine("Nome de Usuario: " + NomeDeUsuario);
        Console.WriteLine("Nome Completo: " + Nome + " " + SobreNome);
        Console.WriteLine("Nível de Acesso:");
        
        // Exibe todos os módulos configurados
        foreach (var modulo in niveisDeAcesso)
        {
            Console.WriteLine($"{modulo.Key}: " + (modulo.Value ? "Acesso" : "Sem acesso"));
        }
    }
    public bool VerificarAcesso(string modulo)
    {
        return niveisDeAcesso.TryGetValue(modulo, out bool acesso) && acesso;
    }
}
