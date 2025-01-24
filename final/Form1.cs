using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace final
{
    public partial class Form1 : Form
    {


        Random random = new Random();

        Rectangle player = new Rectangle(10, 150, 10, 10);

        Rectangle Dot = new Rectangle(75, 195, 15, 15);

        int playerScore = 0;
        int playerSpeed = 4;

        bool wPressed = false;
        bool sPressed = false;
        bool aPressed = false;
        bool dPressed = false;
        
        
        


       
        Pen blackPen = new Pen(Color.Black, 5);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wPressed = true;
                    break;
                case Keys.S:
                    sPressed = true;
                    break ;
                case Keys.A:
                    aPressed = true;
                    break;
                case Keys.D:
                    dPressed = true;
                    break;
             

                       

               
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wPressed = false;
                        break;
                case Keys.S:
                    sPressed = false;
                    break;
                case Keys.A:
                    aPressed = false;
                    break;
                case Keys.D:
                    dPressed = false;
                    break;
                

                  
            }


        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(blackPen, player);
            e.Graphics.DrawRectangle(blackPen, Dot);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            playerBox.Text = $"player's Score is {playerScore}";


            if (wPressed == true && player.Y > 0)
            {
                player.Y -= playerSpeed;
            }

            if (sPressed == true && player.Y < this.Height - 10)
            {
                player.Y += playerSpeed;

            }
            Refresh();

            if (aPressed == true && player.X > 0)
            {
                player.X -= playerSpeed;
            }

            if (dPressed == true && player.X < this.Width - 10)
            {
                player.X += playerSpeed;
            }


            if (player.IntersectsWith(Dot))
            {
                int randomX = random.Next(25,400);
                int randomY = random.Next(25, 400);

                Dot = new Rectangle(randomX, randomY, 15, 15);


                playerScore++;

            }

            Refresh();

            if(playerScore == 20)
            {
                
            }

        }
    }
}


