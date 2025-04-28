using Automacao01_PodeVotar;

namespace Automacao01_PodeVotar_Test
{
    [TestClass]
    public sealed class VotoUnitTest
    {
        [TestMethod]
        public void Teste_Idade21_DevePoderVotar()
        {
            //Arrange - Preparação do ambiente de teste
            Voto voto = new Voto();
            int idade = 21;
            string esperado = "Pode votar!";

            //Act - Execução da chamada do artefato a ser testado
            string obtido = voto.podeVotar(idade);

            //Assert - Comparando resultados para saber se passou
            Assert.AreEqual(esperado, obtido);
        }

        [TestMethod]
        public void Teste_Idade18_DevePoderVotar()
        {
            //Arrange - Preparação do ambiente de teste
            Voto voto = new Voto();
            int idade = 18;
            string esperado = "Pode votar!";

            //Act - Execução da chamada do artefato a ser testado
            string obtido = voto.podeVotar(idade);

            //Assert - Comparando resultados para saber se passou
            Assert.AreEqual(esperado, obtido);
        }
    }
}
