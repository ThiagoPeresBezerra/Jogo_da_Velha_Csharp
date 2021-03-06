﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
Desenvolvido por Thiago Peres Bezerra
Data: 13/08/2017
*/

namespace WindowsFormsJogoDaVelha
{
    public partial class Form1_Jogo_da_Velha : Form
    {
        public string jogador_atual = "X";

        public Form1_Jogo_da_Velha()
        {
            InitializeComponent();
        }

        //Botão Reset.
        private void button_Reset_Click(object sender, EventArgs e)
        {
            resetar();
        }

        //Form principal com label recebendo a variável jogador atual.
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.ForeColor = System.Drawing.Color.Red;
            label1.Text = "Jogador Atual: " + jogador_atual;            
        }

        //Método para inverter o jogador 'X' e 'O'.
        public string inverter_jogador()
        {
            if (jogador_atual == "X")
            {
                label1.ForeColor = System.Drawing.Color.Blue;
                return "O";
            }
            else
            {
                label1.ForeColor = System.Drawing.Color.Red;
                return "X";
            }           
        }

        //Método para zerar o jogo com o botão Reset e retornar o jogador atual 'X'.
        public void resetar()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button6.Text = "";
            button5.Text = "";
            button4.Text = "";
            button9.Text = "";
            button8.Text = "";
            button7.Text = "";
            jogador_atual = "X";
            label1.ForeColor = System.Drawing.Color.Red;
            label1.Text = "Jogador Atual: " + jogador_atual;
        }

        //Caixa de mensagem de jogador vencedor com método resetar.
        public void vitoria()
        {        
            MessageBox.Show("O Jogador "+jogador_atual+" VENCEU!");
            resetar();
        }

        //Função verificar vencedor.
        public bool verificacao_vencedor(string jogador_atual_text)
        {        
            //Função Condicional Vertical.
            if (button1.Text == jogador_atual_text && button6.Text == jogador_atual_text && button9.Text == jogador_atual_text)
            {
                vitoria();
                return true;
            }
            if (button2.Text == jogador_atual_text && button5.Text == jogador_atual_text && button8.Text == jogador_atual_text)
            {
                vitoria();
                return true;
            }
            if (button3.Text == jogador_atual_text && button4.Text == jogador_atual_text && button7.Text == jogador_atual_text)
            {
                vitoria();
                return true;
            }
            //Função Condicional Horizontal.
            if (button1.Text == jogador_atual_text && button2.Text == jogador_atual_text && button3.Text == jogador_atual_text)
            {
                vitoria();
                return true;
            }
            if (button6.Text == jogador_atual_text && button5.Text == jogador_atual_text && button4.Text == jogador_atual_text)
            {
                vitoria();
                return true;
            }
            if (button9.Text == jogador_atual_text && button8.Text == jogador_atual_text && button7.Text == jogador_atual_text)
            {
                vitoria();
                return true;
            }
            //Função Condicional Diogonal
            if (button1.Text == jogador_atual_text && button5.Text == jogador_atual_text && button7.Text == jogador_atual_text)
            {
                vitoria();
                return true;
            }
            if (button3.Text == jogador_atual_text && button5.Text == jogador_atual_text && button9.Text == jogador_atual_text)
            {
                vitoria();
                return true;
            }
            //Caixa de mensagem quando jogo der 'Velha'.
            if (button1.Text.Length != 0 && button2.Text.Length != 0 && button3.Text.Length != 0 && button6.Text.Length != 0 && button5.Text.Length != 0 && button4.Text.Length != 0 && button9.Text.Length != 0 && button8.Text.Length != 0 && button7.Text.Length != 0)            
            {
                MessageBox.Show("Deu VELHA!");
                resetar();
                return true;
            }
            //Retornando jogador atual para 'X'.
            jogador_atual = inverter_jogador();
            label1.Text = "Jogador Atual: " + jogador_atual;
            return false;
        }
        

        //Verificando jogadas do jogador atual por botão.
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                button1.Text = jogador_atual;
                verificacao_vencedor(jogador_atual);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                button2.Text = jogador_atual;
                verificacao_vencedor(jogador_atual);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "")
            {
                button3.Text = jogador_atual;
                verificacao_vencedor(jogador_atual);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button6.Text == "")
            {
                button6.Text = jogador_atual;
                verificacao_vencedor(jogador_atual);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "")
            {
                button5.Text = jogador_atual;
                verificacao_vencedor(jogador_atual);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button4.Text == "")
            {
                button4.Text = jogador_atual;
                verificacao_vencedor(jogador_atual);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button9.Text == "")
            {
                button9.Text = jogador_atual;
                verificacao_vencedor(jogador_atual);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "")
            {
                button8.Text = jogador_atual;
                verificacao_vencedor(jogador_atual);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button7.Text == "")
            {
                button7.Text = jogador_atual;
                verificacao_vencedor(jogador_atual);
            }
        }
    }
}
