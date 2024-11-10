using System;
using Microsoft.Data.Sqlite;

namespace Persistence;

public class CreateDataBase
{
    private readonly SqliteConnection _connection;
    public CreateDataBase(string connectionString)
    {
        _connection = new SqliteConnection(connectionString);

    }
    public void CreateTableUsuario()
    {   
        string commandText = @"
            CREATE TABLE tb_usuario (
                usuarioId INTEGER PRIMARY KEY AUTOINCREMENT,
                nomeDeUsuario TEXT NOT NULL UNIQUE,
                senha TEXT NOT NULL,
                nome TEXT NOT NULL,
                sobreNome TEXT NOT NULL
            );
        ";
        using (var _command = new SqliteCommand(commandText, _connection)) { 
            _connection.Open();
            _command.ExecuteNonQuery();
            _connection.Close();
        }
    }

    public bool IsTableExists(string tableName)
    {
        string commandText = "SELECT count(*) FROM sqlite_master WHERE type = 'table' AND name=@tableName";
        using (var _command = new SqliteCommand(commandText, _connection))
        {
            _command.Parameters.AddWithValue("@tableName", tableName);
            _connection.Open();
            int count = Convert.ToInt16(_command.ExecuteScalar());
            _connection.Close();
            return count > 0;
        }
    }
}
