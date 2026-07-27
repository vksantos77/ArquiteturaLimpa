using ArquiteturaLimpa.Domain.Accounts.ValueObjects;

namespace ArquiteturaLimpa.Domain.Test.Accounts.ValueObjects
{    
    public class NameTest
    {
        private readonly Name _name = Name.Create("Vitor", "Teste");
        [Fact]
        public void ShouldOverrideTOStringMethod()
        {
            Assert.Equal("Vitor Teste", _name);
        }

        [Fact]
        public void ShouldImplicitConvertToString()
        {
            string data = _name;
            Assert.Equal("Vitor Teste", data);
        }
        [Fact]
        public void ShouldImplicitConvertStringToName()
        {
            Assert.Fail();
        }
    }
}
