using ArquiteturaLimpa.Domain.Accounts.Entities;


namespace ArquiteturaLimpa.Domain.Test.Accounts.Entities
{
    public class StudentTest 
    {
        [Fact]
        public void Test1()
        {
            var student = new Student("Test", "Test", "teste@gmail.com", "1234");
            
        }
    }
}
