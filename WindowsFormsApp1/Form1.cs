using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Plansza myGame;
        private Graphics g;
        private const int filedSize= 25;


        public Form1()
        { 
        InitializeComponent();
            myGame = new Plansza(new Size(10, 10));
            pictureBoxVisualization.Image = new Bitmap(myGame.size.Width * filedSize,
                                                     myGame.size.Height * filedSize);
            g = Graphics.FromImage(pictureBoxVisualization.Image);

            DrawBoard();
        }

        private void DrawBoard()
        {
            for(int col=0;col<myGame.size.Height;col++)
            {
                for (int row = 0; row < myGame.size.Height; row++)
                    {
                    g.DrawRectangle(new Pen(Color.Black), col * filedSize, row * filedSize, filedSize, filedSize);
                    }
            }
            

            //throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
