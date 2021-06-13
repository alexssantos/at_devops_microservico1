using System;

namespace Taskfy.Api.Models
{
    public class Tarefa
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataDeCriacao { get; set; }

        public DateTime? DataUltimaAtualizacao { get; set; }

        public Tarefa(string titulo, string descricao)
        {
            Id = Guid.NewGuid();
            DataDeCriacao = DateTime.Now;
            Titulo = titulo;
            Descricao = descricao;
        }

        public Tarefa AtualizaTarefa(string titulo, string descricao)
        {
            Titulo = titulo;
            Descricao = descricao;
            DataUltimaAtualizacao = DateTime.Now;

            return this;
        }
    }
}
