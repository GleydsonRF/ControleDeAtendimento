using System;

namespace Models;

public class Fila
    {
        // Atributos
        public required Servico Servico { get; set; }
        public Queue<Senha> Senhas { get; set; }

        public Fila()
        {
            Senhas = new Queue<Senha>();
        }

        // Métodos
        public void AdicionarSenha(Senha senha)
        {
            Senhas.Enqueue(senha);
        }

        public Senha? ChamarProximaSenha()
        {
            return Senhas.Count > 0 ? Senhas.Dequeue() : null;
        }
    }
