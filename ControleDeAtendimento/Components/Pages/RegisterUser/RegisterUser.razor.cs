using Microsoft.AspNetCore.Components;
using Models;
using Persistence;

namespace ControleDeAtendimento.Components.Pages.RegisterUser{
    public partial class RegisterUser : ComponentBase
    {
        private Usuario usuarioModelo = new Usuario();
        private List<Usuario> listaUsuario = new List<Usuario>();

        private void HandleRegisterUsuario()
        {
            var dbPath = Path.Combine(FileSystem.AppDataDirectory, "utfpr_poo.db");
            new Repository($"Data Source={dbPath}").Create(usuarioModelo);
            // listaUsuario.Add(new Usuario
            // {
            //     Nome = usuarioModelo.Nome,
            //     SobreNome = usuarioModelo.SobreNome,
            //     NomeDeUsuario = usuarioModelo.NomeDeUsuario,
            //     Senha = usuarioModelo.Senha
            // });

            
            usuarioModelo = new Usuario();
        }
    }
}
