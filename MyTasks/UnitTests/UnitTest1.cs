using Taskfy.Api.Models;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void deve_criar_uma_tarefa()
        {
            var tarefa = new Tarefa("Meu titulo", "Minha descricao");

            Assert.NotNull(tarefa);
        }
    }
}
