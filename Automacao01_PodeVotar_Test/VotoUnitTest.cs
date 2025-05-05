using Automacao01_PodeVotar;

namespace Automacao01_PodeVotar_Test
{
    [TestClass]
    public sealed class VotoUnitTest
    {
        private Voto voto;

        [TestInitialize]
        public void setup()
        {
            voto = new Voto();
        }

        [TestMethod]
        public void Teste_Idade21_DevePoderVotar()
        {
            //Arrange - Preparação do ambiente de teste
            //Voto voto = new Voto();
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
            //Voto voto = new Voto();
            int idade = 18;
            string esperado = "Pode votar!";

            //Act - Execução da chamada do artefato a ser testado
            string obtido = voto.podeVotar(idade);

            //Assert - Comparando resultados para saber se passou
            Assert.AreEqual(esperado, obtido);
        }

        [TestMethod]
        [DataRow(15, "Não pode votar!")]
        [DataRow(16, "Voto opcional!")]
        [DataRow(17, "Voto opcional!")]
        [DataRow(18, "Pode votar!")]
        [DataRow(21, "Pode votar!")]
        public void Teste_Idade_DeveRetornarStatusVoto(int idade, string esperado)
        {
            //Arrange - Preparação do ambiente de teste
            //Voto voto = new Voto();

            //Act - Execução da chamada do artefato a ser testado
            string obtido = voto.podeVotar(idade);

            //Assert - Comparando resultados para saber se passou
            Assert.AreEqual(esperado, obtido);
        }
    }
}
