using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jokenpo
{
    public partial class JokenPo : Form
    {
        public JokenPo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void StartGame(int opcao)
        {
            Game jogar = new Game();
            
            switch (jogar.Jogar(opcao))
            {
                case Game.Resultado.Ganhar:
                    picResultado.BackgroundImage = Image.FromFile("images/ganhar.png");
                    goto default;
                case Game.Resultado.Perder:
                    picResultado.BackgroundImage = Image.FromFile("images/perder.png");
                    goto default;
                case Game.Resultado.Empatar:
                    picResultado.BackgroundImage = Image.FromFile("images/empatar.png");
                    goto default;
                default:
                    picJogador.BackgroundImage = Game.ImgJogador;
                    picPC.BackgroundImage = Game.ImgPC;
                break;
                 

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartGame(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartGame(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StartGame(2);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
