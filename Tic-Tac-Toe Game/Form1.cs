using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Game.Properties;

namespace Tic_Tac_Toe_Game
{


    public partial class Form1 : Form
    {
        stGameStatus GameStatus;
        enPlayer PlayerTurn = enPlayer.Player1;
        enum enPlayer
        {
            Player1,
            Player2
        }

        enum enWinner
        {
            Player1,
            Player2,
            Draw,
            GameInProgress
        }

        struct stGameStatus
        {
            public enWinner Winner;
            public bool GameOver;
            public short PlayCount;

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.FromArgb(255, 255, 255);
            Pen pen = new Pen(White);
            pen.Width = 10;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            e.Graphics.DrawLine(pen, 300, 220, 750, 220);
            e.Graphics.DrawLine(pen, 300, 330, 750, 330);
            e.Graphics.DrawLine(pen, 460, 120, 460, 430);
            e.Graphics.DrawLine(pen, 610, 120, 610, 430);

        }
        public void CheckWinner()
        {
            if (CheckValus(button1, button2, button3))
                return;
            if (CheckValus(button4, button5, button6))
                return;
            if (CheckValus(button7, button8, button9))
                return;
            if (CheckValus(button1, button4, button7))
                return;
            if (CheckValus(button2, button5, button8))
                return;
            if (CheckValus(button3, button6, button9))
                return;
            if (CheckValus(button1, button5, button9))
                return;
            if (CheckValus(button3, button5, button7))
                return;

        }
        public void EndGame()
        {
            lePlyer_Turn.Text = "Game Over";
            switch (GameStatus.Winner)
            {
                case enWinner.Player1:
                    leHow_Winner.Text = enPlayer.Player1.ToString();
                    break;
                case enWinner.Player2:
                    leHow_Winner.Text = enPlayer.Player2.ToString();
                    break;
                default:
                    leHow_Winner.Text = enWinner.Draw.ToString();
                    break;
            }
            MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public bool CheckValus(Button btn1, Button btn2, Button btn3)
        {
            if (btn1.Tag.ToString() != "?" && btn1.Tag.ToString() == btn2.Tag.ToString() && btn1.Tag.ToString() == btn3.Tag.ToString())
            {

                btn1.BackColor = Color.YellowGreen;
                btn2.BackColor = Color.YellowGreen;
                btn3.BackColor = Color.YellowGreen;
                if (btn1.Tag.ToString() == "X")
                {
                    GameStatus.Winner = enWinner.Player1;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
                else
                {
                    GameStatus.Winner = enWinner.Player2;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }

            }
            GameStatus.GameOver = false;
            return false;
        }

        public void ChangeImge(Button btn)
        {
            if (btn.Tag.ToString() == "?")
            {
                if (lePlyer_Turn.Text == enPlayer.Player1.ToString())
                {
                    btn.Image = Resources.X;
                    btn.Tag = "X";
                    lePlyer_Turn.Text = enPlayer.Player2.ToString();
                    GameStatus.PlayCount++;
                    CheckWinner();
                }
                else
                {
                    btn.Image = Resources.O;
                    btn.Tag = "O";
                    lePlyer_Turn.Text = enPlayer.Player1.ToString();
                    GameStatus.PlayCount++;
                    CheckWinner();
                }
            }
            else
            {
                MessageBox.Show("No Its Alrde Plyed", "You Can't");
            }
            if (GameStatus.PlayCount == 9)
            {
                GameStatus.GameOver = true;
                GameStatus.Winner = enWinner.Draw;
                EndGame();
            }
        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            ChangeImge(button2);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ChangeImge(button1);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangeImge(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChangeImge(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangeImge(button5);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ChangeImge(button6);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            ChangeImge(button7);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            ChangeImge(button8);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            ChangeImge(button9);

        }

        public void RestartBut(Button btn)
        {
            btn.Tag= "?";
            btn.Image = Resources.question_mark_96;
            btn.BackColor = Color.Transparent;
        }
        private void button0_Click(object sender, EventArgs e)
        {
            RestartBut(button1 );
            RestartBut(button2 );
            RestartBut(button3 );
            RestartBut(button4 );
            RestartBut(button5 );
            RestartBut(button6 );
            RestartBut(button7 );
            RestartBut(button8 );
            RestartBut(button9 );
            PlayerTurn = enPlayer.Player1;
            lePlyer_Turn.Text = enPlayer.Player1.ToString();
            GameStatus.PlayCount = 0;
            GameStatus.GameOver = false;
            GameStatus.Winner = enWinner.GameInProgress;
            lePlyer_Turn.Text = "In Progress";
        }
    }
}
