using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NotFlappiBiird
{
    public partial class Form1 : Form
    {

        int pipespeed = 8;
        int gravity = 15;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void GamerTimerEvent(object sender, EventArgs e)
        {
            Flappi.Top += gravity;
            PipeBottom.Left -= pipespeed;
            PipeTop.Left -= pipespeed;
            scoretext.Text = score.ToString();

            if(PipeBottom.Left < -70)
            {
                PipeBottom.Left = 620;
                score++;
            }
            if(PipeTop.Left < -80)
            {
                PipeTop.Left = 510;
                
            }

            if  (Flappi.Bounds.IntersectsWith(PipeBottom.Bounds) ||
                    Flappi.Bounds.IntersectsWith(PipeTop.Bounds) ||
                        Flappi.Bounds.IntersectsWith(Ground.Bounds))
                {
                     endGame();
                }


            if (score > 10)
            {
                pipespeed = 15;
            }
          
            if (score > 20)
            {
                pipespeed = 20;
            }

            if (score > 30)
            {
                pipespeed = 30;
            }
            
            if(Flappi.Top < -25)
            {
                endGame();
            }
        }

        private void gamerkeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }

        private void gamerkeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }

       
        private void endGame()
        {
            gamertimer.Stop();
            scoretext.Text += "   Hävisit";
        }
    }
}
