using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace PartidaDeTenis.Teste
{
    [TestClass]
    public class PartidaDeTenisTeste
    {
        // Arrange  "Preparação"
        // Act      "Teste"
        // Assert   "Resultado"

        [TestMethod]
        public void Deve_iniciar_placar_do_jogo_zerado()
        {
            // Arrange
            Jogador jogador1 = new Jogador();
            Jogador jogador2 = new Jogador();

            PartidaDeTenis outraPartida = new PartidaDeTenis(jogador1, jogador2);
            // Act
            var resultadoObtido = outraPartida.GerarPlacar();

            // Assert
            Assert.AreEqual("0 - 0", resultadoObtido);
        }

        [TestMethod]
        public void Deve_aplicar_primeiro_ponto_para_jogador1()
        {
            // Arrange
            Jogador jogador1 = new Jogador();
            Jogador jogador2 = new Jogador();

            PartidaDeTenis outraPartida = new PartidaDeTenis(jogador1, jogador2);
            outraPartida.Jogador1.Pontuar();

            // Act
            var resultadoObtido = outraPartida.GerarPlacar();

            // Assert
            Assert.AreEqual("15 - 0", resultadoObtido);
        }

        [TestMethod]
        public void Deve_aplicar_segundo_ponto_para_jogador1()
        {
            // Arrange
            Jogador jogador1 = new Jogador();
            Jogador jogador2 = new Jogador();

            PartidaDeTenis outraPartida = new PartidaDeTenis(jogador1, jogador2);
            outraPartida.Jogador1.Pontuar();
            outraPartida.Jogador1.Pontuar();
            
            // Act
            var resultadoObtido = outraPartida.GerarPlacar();

            // Assert
            Assert.AreEqual("30 - 0", resultadoObtido);
        }

        [TestMethod]
        public void Deve_aplicar_terceiro_ponto_para_jogador1()
        {
            // Arrange
            Jogador jogador1 = new Jogador();
            Jogador jogador2 = new Jogador();

            PartidaDeTenis outraPartida = new PartidaDeTenis(jogador1, jogador2);
            outraPartida.Jogador1.Pontuar();
            outraPartida.Jogador1.Pontuar();
            outraPartida.Jogador1.Pontuar();

            // Act
            var resultadoObtido = outraPartida.GerarPlacar();

            // Assert
            Assert.AreEqual("40 - 0", resultadoObtido);
        }

        [TestMethod]
        public void Deve_conceder_vitoria_para_jogador1()
        {
            // Arrange
            Jogador jogador1 = new Jogador();
            Jogador jogador2 = new Jogador();

            PartidaDeTenis outraPartida = new PartidaDeTenis(jogador1, jogador2);
            outraPartida.Jogador1.Pontuar();
            outraPartida.Jogador1.Pontuar();
            outraPartida.Jogador1.Pontuar();
            outraPartida.Jogador1.Pontuar();

            // Act
            var resultadoObtido = outraPartida.GerarPlacar();

            // Assert
            Assert.AreEqual("Vitoria do Jogador 1!", resultadoObtido);
        }

        [TestMethod]
        public void Deve_aplicar_primeiro_ponto_para_jogador2()
        {
            // Arrange
            Jogador jogador1 = new Jogador();
            Jogador jogador2 = new Jogador();

            PartidaDeTenis outraPartida = new PartidaDeTenis(jogador1, jogador2);
            outraPartida.Jogador2.Pontuar();

            // Act
            var resultadoObtido = outraPartida.GerarPlacar();

            // Assert
            Assert.AreEqual("0 - 15", resultadoObtido);
        }

        [TestMethod]
        public void Deve_aplicar_segundo_ponto_para_jogador2()
        {
            // Arrange
            Jogador jogador1 = new Jogador();
            Jogador jogador2 = new Jogador();

            PartidaDeTenis outraPartida = new PartidaDeTenis(jogador1, jogador2);
            outraPartida.Jogador2.Pontuar();
            outraPartida.Jogador2.Pontuar();

            // Act
            var resultadoObtido = outraPartida.GerarPlacar();

            // Assert
            Assert.AreEqual("0 - 30", resultadoObtido);
        }

        [TestMethod]
        public void Deve_aplicar_terceiro_ponto_para_jogador2()
        {
            // Arrange
            Jogador jogador1 = new Jogador();
            Jogador jogador2 = new Jogador();

            PartidaDeTenis outraPartida = new PartidaDeTenis(jogador1, jogador2);
            outraPartida.Jogador2.Pontuar();
            outraPartida.Jogador2.Pontuar();
            outraPartida.Jogador2.Pontuar();

            // Act
            var resultadoObtido = outraPartida.GerarPlacar();

            // Assert
            Assert.AreEqual("0 - 40", resultadoObtido);
        }

        [TestMethod]
        public void Deve_conceder_vitoria_para_jogador2()
        {
            // Arrange
            Jogador jogador1 = new Jogador();
            Jogador jogador2 = new Jogador();

            PartidaDeTenis outraPartida = new PartidaDeTenis(jogador1, jogador2);
            outraPartida.Jogador2.Pontuar();
            outraPartida.Jogador2.Pontuar();
            outraPartida.Jogador2.Pontuar();
            outraPartida.Jogador2.Pontuar();

            // Act
            var resultadoObtido = outraPartida.GerarPlacar();

            // Assert
            Assert.AreEqual("Vitoria do Jogador 2!", resultadoObtido);
        }

        [TestMethod]
        public void Deve_conceder_empate_de_15_a_15_para_os_jogadores()
        {
            // Arrange
            Jogador jogador1 = new Jogador();
            Jogador jogador2 = new Jogador();

            PartidaDeTenis outraPartida = new PartidaDeTenis(jogador1, jogador2);
            outraPartida.Jogador1.Pontuar();
            outraPartida.Jogador2.Pontuar();

            // Act
            var resultadoObtido = outraPartida.GerarPlacar();

            // Assert
            Assert.AreEqual("15 - 15", resultadoObtido);
        }

        [TestMethod]
        public void Deve_conceder_empate_de_30_a_30_para_os_jogadores()
        {
            // Arrange
            Jogador jogador1 = new Jogador();
            Jogador jogador2 = new Jogador();

            PartidaDeTenis outraPartida = new PartidaDeTenis(jogador1, jogador2);
            outraPartida.Jogador1.Pontuar();
            outraPartida.Jogador2.Pontuar();
            outraPartida.Jogador1.Pontuar();
            outraPartida.Jogador2.Pontuar();

            // Act
            var resultadoObtido = outraPartida.GerarPlacar();

            // Assert
            Assert.AreEqual("30 - 30", resultadoObtido);
        }

        [TestMethod]
        public void Deve_conceder_empate_para_jogadores()
        {
            // Arrange
            Jogador jogador1 = new Jogador();
            Jogador jogador2 = new Jogador();

            PartidaDeTenis outraPartida = new PartidaDeTenis(jogador1, jogador2);
            outraPartida.Jogador1.Pontuar();
            outraPartida.Jogador2.Pontuar();
            outraPartida.Jogador1.Pontuar();
            outraPartida.Jogador2.Pontuar();
            outraPartida.Jogador1.Pontuar();
            outraPartida.Jogador2.Pontuar();

            // Act
            var resultadoObtido = outraPartida.GerarPlacar();

            // Assert
            Assert.AreEqual("Deuce!", resultadoObtido);
        }

        [TestMethod]
        public void Deve_conceder_advantage_para_jogador1()
        {
            // Arrange
            Jogador jogador1 = new Jogador();
            Jogador jogador2 = new Jogador();

            PartidaDeTenis outraPartida = new PartidaDeTenis(jogador1, jogador2);
            outraPartida.Jogador1.Pontuar();
            outraPartida.Jogador2.Pontuar();
            outraPartida.Jogador1.Pontuar();
            outraPartida.Jogador2.Pontuar();
            outraPartida.Jogador1.Pontuar();
            outraPartida.Jogador2.Pontuar();
            outraPartida.Jogador1.Pontuar();

            // Act
            var resultadoObtido = outraPartida.GerarPlacar();

            // Assert
            Assert.AreEqual("Advantage Jogador 1!", resultadoObtido);
        }

        [TestMethod]
        public void Deve_conceder_vitoria_para_jogador1_depois_do_advantage()
        {
            // Arrange
            Jogador jogador1 = new Jogador();
            Jogador jogador2 = new Jogador();

            PartidaDeTenis outraPartida = new PartidaDeTenis(jogador1, jogador2);
            outraPartida.Jogador1.Pontuar();
            outraPartida.Jogador2.Pontuar();
            outraPartida.Jogador1.Pontuar();
            outraPartida.Jogador2.Pontuar();
            outraPartida.Jogador1.Pontuar();
            outraPartida.Jogador2.Pontuar();
            outraPartida.Jogador1.Pontuar();
            outraPartida.Jogador1.Pontuar();

            // Act
            var resultadoObtido = outraPartida.GerarPlacar();

            // Assert
            Assert.AreEqual("Vitoria do Jogador 1!", resultadoObtido);
        }

        [TestMethod]
        public void Deve_conceder_advantage_para_jogador2()
        {
            // Arrange
            Jogador jogador1 = new Jogador();
            Jogador jogador2 = new Jogador();

            PartidaDeTenis outraPartida = new PartidaDeTenis(jogador1, jogador2);
            outraPartida.Jogador1.Pontuar();
            outraPartida.Jogador2.Pontuar();
            outraPartida.Jogador1.Pontuar();
            outraPartida.Jogador2.Pontuar();
            outraPartida.Jogador1.Pontuar();
            outraPartida.Jogador2.Pontuar();
            outraPartida.Jogador2.Pontuar();
            // Act
            var resultadoObtido = outraPartida.GerarPlacar();
            // Assert
            Assert.AreEqual("Advantage Jogador 2!", resultadoObtido);
        }

        [TestMethod]
        public void Deve_conceder_vitoria_para_jogador2_depois_do_advantage()
        {
            // Arrange
            Jogador jogador1 = new Jogador();
            Jogador jogador2 = new Jogador();

            PartidaDeTenis outraPartida = new PartidaDeTenis(jogador1, jogador2);
            outraPartida.Jogador1.Pontuar();
            outraPartida.Jogador2.Pontuar();
            outraPartida.Jogador1.Pontuar();
            outraPartida.Jogador2.Pontuar();
            outraPartida.Jogador1.Pontuar();
            outraPartida.Jogador2.Pontuar();
            outraPartida.Jogador2.Pontuar();
            outraPartida.Jogador2.Pontuar();

            // Act
            var resulltadoObtido = outraPartida.GerarPlacar();

            // Assert
            Assert.AreEqual("Vitoria do Jogador 2!", resulltadoObtido);
        }
    }
}
