using Taskfy.Api.Models;
using Xunit;

namespace UnitTests
{
    public class TarefaTestes
    {
        [Fact]
        public void deve_criar_uma_tarefa()
        {
            var tarefa = new Tarefa("Meu titulo", "Minha descricao");

            Assert.NotNull(tarefa);
        }

        [Fact]
        public void deve_atualizar_uma_tarefa()
        {
            var titulo = "Meu titulo 2";
            var tarefa = new Tarefa("Meu titulo", "Minha descricao");

            tarefa.AtualizaTarefa(titulo, "Minha descricao");

            Assert.Equal(titulo, tarefa.Titulo);
        }
    }
}
