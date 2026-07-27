using ArquiteturaLimpa.Domain.Accounts.ValueObjects;

namespace ArquiteturaLimpa.Domain.Test.Accounts.ValueObjects
{    
    public class NameTest
    {
        [Fact]
        public void ShouldOverrideTOStringMethod()
        {
            var name = new Name("Vitor", "Teste");
            Assert.Equal("Vitor Teste", name.ToString());
        }
        

    }
}
