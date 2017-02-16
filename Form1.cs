using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class Form1 : Form
    {
        string jogador = "X";
        int vezesXGanhou = 0;
        int vezesOGanhou = 0;
        int contador = 0;
        Image imgX, imgO;
        //Image imgX = Image.FromFile(@"E:\Documents\Visual Studio 2015\Projects\JogoDaVelha\JogoDaVelha\Resources\icon2.png");
        //Image imgO = Image.FromFile(@"E:\Documents\Visual Studio 2015\Projects\JogoDaVelha\JogoDaVelha\Resources\orkut-letter-logo2.png");

        public Form1()
        {
            InitializeComponent();
            imgX = imageX.Image;
            imgO = imageO.Image;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limparCampos();
            panel1.Enabled = true;
            label3.Text = "Vez do X";
            jogador = "X";
            contador = 0;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            limparCampos();
            label1.Text = "O Ganhou: 0";
            label2.Text = "X Ganhou: 0";
            vezesOGanhou = 0;
            vezesXGanhou = 0;
            panel1.Enabled = true;
            label3.Text = "Vez do X";
            jogador = "X";
            contador = 0;
        }

        public void limparCampos()
        {
            btn1.Image = null;
            btn2.Image = null;
            btn3.Image = null;
            btn4.Image = null;
            btn5.Image = null;
            btn6.Image = null;
            btn7.Image = null;
            btn8.Image = null;
            btn9.Image = null;
        }

        public void ganhador()
        {
            if (jogador == "X")
            {
                vezesXGanhou++;
                label2.Text = "X Ganhou: " + Convert.ToString(vezesXGanhou);
            }
            else
            {
                vezesOGanhou++;
                label1.Text = "O Ganhou: " + Convert.ToString(vezesOGanhou);
            }
            MessageBox.Show(jogador + " Venceu");
            string escolhaNovo = MessageBox.Show("Jogar Novamente?", "Novo Jogo", MessageBoxButtons.YesNo).ToString();
            if (escolhaNovo == "Yes")
            {
                limparCampos();
                contador = 0;
            }
            else if(escolhaNovo == "No")
            {
                panel1.Enabled = false;
            }
        }

        public bool testarCampos(Image primeiro, Image segundo, Image terceiro)
        {
            if (primeiro == imgX && segundo == imgX && terceiro == imgX)
                return true;
            else if (primeiro == imgO && segundo == imgO && terceiro == imgO)
                return true;
            else
                return false;
        }

        public void mudarJogador()
        {
            if(contador >= 9)
            {
                string novoJogo = MessageBox.Show("Empate\nNovo Jogo?", "Empate", MessageBoxButtons.YesNo).ToString();
                if(novoJogo == "Yes")
                {
                    limparCampos();
                    contador = 0;
                }
                else if(novoJogo == "No")
                {
                    panel1.Enabled = false;
                }
            }
            else
            {
                if (string.Equals(btn1.Image, btn2.Image) && string.Equals(btn1.Image, btn3.Image))
                    if (testarCampos(btn1.Image, btn2.Image, btn3.Image))
                        ganhador();
                if (string.Equals(btn4.Image, btn5.Image) && string.Equals(btn4.Image, btn6.Image))
                    if (testarCampos(btn4.Image, btn5.Image, btn6.Image))
                        ganhador();
                if (string.Equals(btn7.Image, btn8.Image) && string.Equals(btn7.Image, btn9.Image))
                    if (testarCampos(btn7.Image, btn8.Image, btn9.Image))
                        ganhador();

                if (string.Equals(btn1.Image, btn4.Image) && string.Equals(btn1.Image, btn7.Image))
                    if (testarCampos(btn1.Image, btn4.Image, btn7.Image))
                        ganhador();
                if (string.Equals(btn2.Image, btn5.Image) && string.Equals(btn2.Image, btn8.Image))
                    if (testarCampos(btn2.Image, btn5.Image, btn8.Image))
                        ganhador();
                if (string.Equals(btn3.Image, btn6.Image) && string.Equals(btn3.Image, btn9.Image))
                    if (testarCampos(btn3.Image, btn6.Image, btn9.Image))
                        ganhador();

                if (string.Equals(btn1.Image, btn5.Image) && string.Equals(btn1.Image, btn9.Image))
                    if (testarCampos(btn1.Image, btn5.Image, btn9.Image))
                        ganhador();
                if (string.Equals(btn3.Image, btn5.Image) && string.Equals(btn3.Image, btn7.Image))
                    if (testarCampos(btn3.Image, btn5.Image, btn7.Image))
                        ganhador();
                if (jogador == "X")
                {
                    jogador = "O";
                }
                else
                {
                    jogador = "X";
                }
                label3.Text = "Vez do " + jogador;
                if (panel1.Enabled == false)
                {
                    label3.Text = "Vez do ";
                }
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (btn1.Image == null)
            {
                contador++;
                if (jogador == "X")
                    btn1.Image = imgX;
                else
                    btn1.Image = imgO;
                mudarJogador();
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (btn2.Image == null)
            {
                contador++;
                if (jogador == "X")
                    btn2.Image = imgX;
                else
                    btn2.Image = imgO;
                mudarJogador();
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (btn3.Image == null)
            {
                contador++;
                if (jogador == "X")
                    btn3.Image = imgX;
                else
                    btn3.Image = imgO;
                mudarJogador();
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (btn4.Image == null)
            {
                contador++;
                if (jogador == "X")
                    btn4.Image = imgX;
                else
                    btn4.Image = imgO;
                mudarJogador();
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (btn5.Image == null)
            {
                contador++;
                if (jogador == "X")
                    btn5.Image = imgX;
                else
                    btn5.Image = imgO;
                mudarJogador();
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (btn6.Image == null)
            {
                contador++;
                if (jogador == "X")
                    btn6.Image = imgX;
                else
                    btn6.Image = imgO;
                mudarJogador();
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (btn7.Image == null)
            {
                contador++;
                if (jogador == "X")
                    btn7.Image = imgX;
                else
                    btn7.Image = imgO;
                mudarJogador();
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (btn8.Image == null)
            {
                contador++;
                if (jogador == "X")
                    btn8.Image = imgX;
                else
                    btn8.Image = imgO;
                mudarJogador();
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (btn9.Image == null)
            {
                contador++;
                if (jogador == "X")
                    btn9.Image = imgX;
                else
                    btn9.Image = imgO;
                mudarJogador();
            }
        }
    }
}
