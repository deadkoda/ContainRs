using ContainRs.WebApp.Models;

namespace ContainRs.Testes
{
    public class EmailCtor
    {
        [Fact]
        public void Deve_Lancar_ArgumentoException_Quando_Valor_Invalido()
        {
            //arrange
            string emailInvalido = "email invalidos";
            //act & assert
            Assert.Throws<ArgumentException>(() => new Email(emailInvalido));
        }
    }
}