using System;
namespace PartidaDeTenis
{
    public class Jogador
    {
        public int pontuacao = 0;

        public void Pontuar()
        {
            if (pontuacao < 5)
            {
                pontuacao++;
            }
        }
    }
}
