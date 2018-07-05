using System;
namespace PartidaDeTenis
{
    /*
     * TODO:
     * - Colocar os AAA nos testes
     * - Arrumar nome do método (pontuacaoDoJogador, CalcularPontos)
     * - Orienntacao a Objetos SRP
     * - Criar classe Jogador para rodar os pontos
     * - Ler livro: Use a cabeça Orientação a Objetos (Head First)
     * */

    public class PartidaDeTenis
    {
        public PartidaDeTenis(Jogador jogador1, Jogador jogador2)
        {
            Jogador1 = jogador1;
            Jogador2 = jogador2;
        }
        int[] pontuacaoDoGame = { 0, 15, 30, 40 };

        public Jogador Jogador1 { get; set; }
        public Jogador Jogador2 { get; set; }

        public string GerarPlacar()
        {
            if (Jogador1.pontuacao >= 4 && Jogador1.pontuacao >= Jogador2.pontuacao + 2)
            {
                return "Vitoria do Jogador 1!";
            }

            if (Jogador2.pontuacao >= 4 && Jogador2.pontuacao >= Jogador1.pontuacao + 2)
            {
                return "Vitoria do Jogador 2!";
            }

            if (Jogador1.pontuacao >= 3 && Jogador2.pontuacao == Jogador1.pontuacao)
            {
                return "Deuce!";
            }

            if (Jogador1.pontuacao >= 4 && Jogador1.pontuacao == Jogador2.pontuacao + 1)
            {
                return "Advantage Jogador 1!";
            }

            if (Jogador2.pontuacao >= 4 && Jogador2.pontuacao == Jogador1.pontuacao + 1)
            {
                return "Advantage Jogador 2!";
            }

            return pontuacaoDoGame[Jogador1.pontuacao] + " - " + pontuacaoDoGame[Jogador2.pontuacao];
        }

        
    }
}