using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokenpo
{
    internal class Game
    {
        public enum Resultado
            {
                Ganhar, Perder, Empatar
            }

        public static Image[] images =
        {
            Image.FromFile("images/Pedra.png"),
            Image.FromFile("images/Papel.png"),
            Image.FromFile("images/Tesoura.png")
        };

        public static Image ImgJogador {  get; set; }

        public static Image ImgPC {  get; set; }
        public Resultado Jogar(int jogador)
        {
            int pc = JogadaPC();
            ImgJogador = images[jogador];
            ImgPC = images[pc];
            
            if (jogador == pc)
            {
                return Resultado.Empatar;
            } else if ((jogador == 0 && pc == 1) || (jogador == 2 && pc == 0) || (jogador == 1 && pc == 2))
            {
                return Resultado.Perder;
            }
            else { return Resultado.Ganhar; }
        }

        private int JogadaPC()
        {
            Random r = new Random();
            return r.Next(3);
        }
         
    }
}
