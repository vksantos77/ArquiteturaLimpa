using ArquiteturaLimpa.Domain.Accounts.ValueObjects;
using ArquiteturaLimpa.Domain.Accounts.ValueObjects.Exceptions;

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
        public void ShouldCreateNewName()
        {
            var name = Name.Create("Vitor", "Teste");
            Assert.Equal("Vitor Teste", name.ToString());
        }

        [Fact]
        public void ShouldFailIfFirstNameLenghtIsNotValid()
        {
            
            Assert.Throws<InvalidFirstNameLenghtException>(() =>
            {
                var name = Name.Create("a", "Teste");
            });
        }
        [Fact]
        public void ShouldFailIfLastNameLenghtIsNotValid()
        {

            Assert.Throws<InvalidLastNameLenghtException>(() =>
            {
                var name = Name.Create("Teste", "a");
            });
        }
    }
}
