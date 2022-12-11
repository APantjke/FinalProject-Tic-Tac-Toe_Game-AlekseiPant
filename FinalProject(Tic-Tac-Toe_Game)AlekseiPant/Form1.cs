using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_Tic_Tac_Toe_Game_AlekseiPant
{
    public partial class Form1 : Form
    {
        bool checker;
        bool winner;
        int wincount;
        int turncount = 0;

        void Enable_False()
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
        }

        void score()
        {
            if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X")
            {
                btn1.BackColor = Color.GreenYellow;
                btn2.BackColor = Color.GreenYellow;
                btn3.BackColor = Color.GreenYellow;

                welcomeLabel.Text = "The winner is Player 1";
                wincount = int.Parse(player1label.Text);
                player1label.Text = Convert.ToString(wincount + 1);
                Enable_False();
                winner = true;
            }

            if (btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X")
            {
                btn1.BackColor = Color.GreenYellow;
                btn4.BackColor = Color.GreenYellow;
                btn7.BackColor = Color.GreenYellow;

                welcomeLabel.Text = "The winner is Player 1";
                wincount = int.Parse(player1label.Text);
                player1label.Text = Convert.ToString(wincount + 1);
                Enable_False();
                winner = true;
            }

            if (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X")
            {
                btn1.BackColor = Color.GreenYellow;
                btn5.BackColor = Color.GreenYellow;
                btn9.BackColor = Color.GreenYellow;

                welcomeLabel.Text = "The winner is Player 1";
                wincount = int.Parse(player1label.Text);
                player1label.Text = Convert.ToString(wincount + 1);
                Enable_False();
                winner = true;
            }

            if (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X")
            {
                btn2.BackColor = Color.GreenYellow;
                btn5.BackColor = Color.GreenYellow;
                btn8.BackColor = Color.GreenYellow;

                welcomeLabel.Text = "The winner is Player 1";
                wincount = int.Parse(player1label.Text);
                player1label.Text = Convert.ToString(wincount + 1);
                Enable_False();
                winner = true;
            }

            if (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X")
            {
                btn3.BackColor = Color.GreenYellow;
                btn5.BackColor = Color.GreenYellow;
                btn7.BackColor = Color.GreenYellow;

                welcomeLabel.Text = "The winner is Player 1";
                wincount = int.Parse(player1label.Text);
                player1label.Text = Convert.ToString(wincount + 1);
                Enable_False();
                winner = true;
            }

            if (btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X")
            {
                btn3.BackColor = Color.GreenYellow;
                btn6.BackColor = Color.GreenYellow;
                btn9.BackColor = Color.GreenYellow;

                welcomeLabel.Text = "The winner is Player 1";
                wincount = int.Parse(player1label.Text);
                player1label.Text = Convert.ToString(wincount + 1);
                Enable_False();
                winner = true;
            }

            if (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X")
            {
                btn4.BackColor = Color.GreenYellow;
                btn5.BackColor = Color.GreenYellow;
                btn6.BackColor = Color.GreenYellow;

                welcomeLabel.Text = "The winner is Player 1";
                wincount = int.Parse(player1label.Text);
                player1label.Text = Convert.ToString(wincount + 1);
                Enable_False();
                winner = true;
            }

            if (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X")
            {
                btn7.BackColor = Color.GreenYellow;
                btn8.BackColor = Color.GreenYellow;
                btn9.BackColor = Color.GreenYellow;

                welcomeLabel.Text = "The winner is Player 1";
                wincount = int.Parse(player1label.Text);
                player1label.Text = Convert.ToString(wincount + 1);
                Enable_False();
                winner = true;
            }

            if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O")
            {
                btn1.BackColor = Color.GreenYellow;
                btn2.BackColor = Color.GreenYellow;
                btn3.BackColor = Color.GreenYellow;

                welcomeLabel.Text = "The winner is Player 2";
                wincount = int.Parse(player2label.Text);
                player2label.Text = Convert.ToString(wincount + 1);
                Enable_False();
                winner = true;
            }

            if (btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O")
            {
                btn1.BackColor = Color.GreenYellow;
                btn4.BackColor = Color.GreenYellow;
                btn7.BackColor = Color.GreenYellow;

                welcomeLabel.Text = "The winner is Player 2";
                wincount = int.Parse(player2label.Text);
                player2label.Text = Convert.ToString(wincount + 1);
                Enable_False();
                winner = true;
            }

            if (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O")
            {
                btn1.BackColor = Color.GreenYellow;
                btn5.BackColor = Color.GreenYellow;
                btn9.BackColor = Color.GreenYellow;

                welcomeLabel.Text = "The winner is Player 2";
                wincount = int.Parse(player2label.Text);
                player2label.Text = Convert.ToString(wincount + 1);
                Enable_False();
                winner = true;
            }

            if (btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O")
            {
                btn2.BackColor = Color.GreenYellow;
                btn5.BackColor = Color.GreenYellow;
                btn8.BackColor = Color.GreenYellow;

                welcomeLabel.Text = "The winner is Player 2";
                wincount = int.Parse(player2label.Text);
                player2label.Text = Convert.ToString(wincount + 1);
                Enable_False();
                winner = true;
            }

            if (btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O")
            {
                btn3.BackColor = Color.GreenYellow;
                btn5.BackColor = Color.GreenYellow;
                btn7.BackColor = Color.GreenYellow;

                welcomeLabel.Text = "The winner is Player 2";
                wincount = int.Parse(player2label.Text);
                player2label.Text = Convert.ToString(wincount + 1);
                Enable_False();
                winner = true;
            }

            if (btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O")
            {
                btn3.BackColor = Color.GreenYellow;
                btn6.BackColor = Color.GreenYellow;
                btn9.BackColor = Color.GreenYellow;

                welcomeLabel.Text = "The winner is Player 2";
                wincount = int.Parse(player2label.Text);
                player2label.Text = Convert.ToString(wincount + 1);
                Enable_False();
                winner = true;
            }

            if (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O")
            {
                btn4.BackColor = Color.GreenYellow;
                btn5.BackColor = Color.GreenYellow;
                btn6.BackColor = Color.GreenYellow;

                welcomeLabel.Text = "The winner is Player 2";
                wincount = int.Parse(player2label.Text);
                player2label.Text = Convert.ToString(wincount + 1);
                Enable_False();
                winner = true;
            }

            if (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O")
            {
                btn7.BackColor = Color.GreenYellow;
                btn8.BackColor = Color.GreenYellow;
                btn9.BackColor = Color.GreenYellow;

                welcomeLabel.Text = "The winner is Player 2";
                wincount = int.Parse(player2label.Text);
                player2label.Text = Convert.ToString(wincount + 1);
                Enable_False();
                winner = true;
            }
            if (turncount == 9 && winner == false)
            {
                welcomeLabel.Text = "There is a tie";
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn1.Text = "X";
                checker = true;
                welcomeLabel.Text = "turn: player 2";
            }
            else
            {
                btn1.Text = "O";
                checker = false;
                welcomeLabel.Text = "turn: player 1";
            }
            turncount++;
            score();
            btn1.Enabled = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn2.Text = "X";
                checker = true;
                welcomeLabel.Text = "turn: player 2";
            }
            else
            {
                btn2.Text = "O";
                checker = false;
                welcomeLabel.Text = "turn: player 1";
            }
            turncount++;
            score();
            btn2.Enabled = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn3.Text = "X";
                checker = true;
                welcomeLabel.Text = "turn: player 2";
            }
            else
            {
                btn3.Text = "O";
                checker = false;
                welcomeLabel.Text = "turn: player 1";
            }
            turncount++;
            score();
            btn3.Enabled = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn4.Text = "X";
                checker = true;
                welcomeLabel.Text = "turn: player 2";
            }
            else
            {
                btn4.Text = "O";
                checker = false;
                welcomeLabel.Text = "turn: player 1";
            }
            turncount++;
            score();
            btn4.Enabled = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn5.Text = "X";
                checker = true;
                welcomeLabel.Text = "turn: player 2";
            }
            else
            {
                btn5.Text = "O";
                checker = false;
                welcomeLabel.Text = "turn: player 1";
            }
            turncount++;
            score();
            btn5.Enabled = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn6.Text = "X";
                checker = true;
                welcomeLabel.Text = "turn: player 2";
            }
            else
            {
                btn6.Text = "O";
                checker = false;
                welcomeLabel.Text = "turn: player 1";
            }
            turncount++;
            score();
            btn6.Enabled = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn7.Text = "X";
                checker = true;
                welcomeLabel.Text = "turn: player 2";
            }
            else
            {
                btn7.Text = "O";
                checker = false;
                welcomeLabel.Text = "turn: player 1";
            }
            turncount++;
            score();
            btn7.Enabled = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn8.Text = "X";
                checker = true;
                welcomeLabel.Text = "turn: player 2";
            }
            else
            {
                btn8.Text = "O";
                checker = false;
                welcomeLabel.Text = "turn: player 1";
            }
            turncount++;
            score();
            btn8.Enabled = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn9.Text = "X";
                checker = true;
                welcomeLabel.Text = "turn: player 2";

            }
            else
            {
                btn9.Text = "O";
                checker = false;
                welcomeLabel.Text = "turn: player 1";
            }
            turncount++;
            score();
            btn9.Enabled = false;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            btn1.Visible = true;
            btn2.Visible = true;
            btn3.Visible = true;
            btn4.Visible = true;
            btn5.Visible = true;
            btn6.Visible = true;
            btn7.Visible = true;
            btn8.Visible = true;
            btn9.Visible = true;

            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";

            btn1.BackColor = Color.WhiteSmoke;
            btn2.BackColor = Color.WhiteSmoke;
            btn3.BackColor = Color.WhiteSmoke;
            btn4.BackColor = Color.WhiteSmoke;
            btn5.BackColor = Color.WhiteSmoke;
            btn6.BackColor = Color.WhiteSmoke;
            btn7.BackColor = Color.WhiteSmoke;
            btn8.BackColor = Color.WhiteSmoke;
            btn9.BackColor = Color.WhiteSmoke;

            winner = false;
            turncount = 0;
        }

        private void btnExit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset(object sender, EventArgs e)
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";

            player1label.Text = "0";
            player2label.Text = "0";

            btn1.BackColor = Color.WhiteSmoke;
            btn2.BackColor = Color.WhiteSmoke;
            btn3.BackColor = Color.WhiteSmoke;
            btn4.BackColor = Color.WhiteSmoke;
            btn5.BackColor = Color.WhiteSmoke;
            btn6.BackColor = Color.WhiteSmoke;
            btn7.BackColor = Color.WhiteSmoke;
            btn8.BackColor = Color.WhiteSmoke;
            btn9.BackColor = Color.WhiteSmoke;

            winner = false;
            turncount = 0;
        }
    }
}
