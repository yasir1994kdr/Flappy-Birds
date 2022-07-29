using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8;
        int gravity = 5;
        int score = 0;



        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {

            FlappyBird.Top += gravity;
            pipeBotoom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreText.Text = "score:" + score;

            if (FlappyBird.Top < -15)
            {
                endGame();
            }

            if (pipeBotoom.Left < -150)
            {
                pipeBotoom.Left = 800;
            score++;
            }
            if (pipeTop.Left <- 190)
            {
                pipeTop.Left = 900;
            score++;
            }
            if (FlappyBird.Bounds.IntersectsWith(pipeBotoom.Bounds) ||
                FlappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                FlappyBird.Bounds.IntersectsWith(Ground.Bounds)


                )
            {

                endGame();

            }

            if(score >5)

            {

                pipeSpeed = 15;

                if(FlappyBird.Top < -15)
                {
                    endGame();
                }

            }

        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }

        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }

        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += " Game Over..!!";
        }


    }
}
