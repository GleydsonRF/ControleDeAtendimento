using System;
using Microsoft.Data.Sqlite;
using Models;

namespace Persistence;

public class Repository
{
    private readonly SqliteConnection _connection;
    public Repository(string connectionString)
    {
        _connection = new SqliteConnection(connectionString);
        var dataBaseCreate = new CreateDataBase(connectionString); 
        if(!dataBaseCreate.IsTableExists("tb_usuario")){
            dataBaseCreate.CreateTableUsuario();
        }
    }

    public void Create(Usuario usuario)
    {
        string commandText = @"
            INSERT INTO tb_usuario (nomeDeUsuario, senha, nome, sobreNome)
            VALUES              (@nomeDeUsuario, @senha, @nome, @sobreNome);";
        using (var _command = new SqliteCommand(commandText, _connection))
        {
           _command.Parameters.AddWithValue("@nomeDeUsuario", usuario.NomeDeUsuario);
           _command.Parameters.AddWithValue("@senha", usuario.Senha);
           _command.Parameters.AddWithValue("@nome", usuario.Nome);
           _command.Parameters.AddWithValue("@sobreNome", usuario.SobreNome);

            _connection!.Open();
            _command.ExecuteNonQuery();
            _connection.Close();
        }
    }
}
