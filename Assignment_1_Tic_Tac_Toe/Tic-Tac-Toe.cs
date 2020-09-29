using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCostaAssignment1
{
    public partial class Form1 : Form
    {
        private readonly Image imgX = Properties.Resources.ImageX;
        private readonly Image imgO = Properties.Resources.ImageO;

        bool wasXUsed = false;
        int rounds;

        public Form1()
        {
            InitializeComponent();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            writeXOrO(pictureBox1);
            rounds++;
            checkWinner();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            writeXOrO(pictureBox2);
            rounds++;
            checkWinner();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            writeXOrO(pictureBox3);
            rounds++;
            checkWinner();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            writeXOrO(pictureBox4);
            rounds++;
            checkWinner();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            writeXOrO(pictureBox5);
            rounds++;
            checkWinner();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            writeXOrO(pictureBox6);
            rounds++;
            checkWinner();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            writeXOrO(pictureBox7);
            rounds++;
            checkWinner();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            writeXOrO(pictureBox8);
            rounds++;
            checkWinner();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            writeXOrO(pictureBox9);
            rounds++;
            checkWinner();
        }

        private void writeXOrO(PictureBox pictureBox)
        {
            if (pictureBox.Image == null && wasXUsed == false)
            {
                pictureBox.Image = imgX;
                wasXUsed = true;
            }
            else if (pictureBox.Image == null)
            {
                pictureBox.Image = imgO;
                wasXUsed = false;

            }
        }

        private void checkWinner()
        {
            bool someoneWon = false;

            if ((pictureBox1.Image == pictureBox2.Image) && (pictureBox2.Image == pictureBox3.Image) && (pictureBox1.Image != null))
            {
                someoneWon = true;
            }
            if ((pictureBox4.Image == pictureBox5.Image) && (pictureBox5.Image == pictureBox6.Image) && (pictureBox4.Image != null))
            {
                someoneWon = true;
            }
            if ((pictureBox7.Image == pictureBox8.Image) && (pictureBox8.Image == pictureBox9.Image) && (pictureBox7.Image != null))
            {
                someoneWon = true;
            }

            if ((pictureBox1.Image == pictureBox4.Image) && (pictureBox4.Image == pictureBox7.Image) && (pictureBox1.Image != null))
            {
                someoneWon = true;
            }
            if ((pictureBox2.Image == pictureBox5.Image) && (pictureBox5.Image == pictureBox8.Image) && (pictureBox2.Image != null))
            {
                someoneWon = true;
            }
            if ((pictureBox3.Image == pictureBox6.Image) && (pictureBox6.Image == pictureBox9.Image) && (pictureBox3.Image != null))
            {
                someoneWon = true;
            }

            if ((pictureBox1.Image == pictureBox5.Image) && (pictureBox5.Image == pictureBox9.Image) && (pictureBox1.Image != null))
            {
                someoneWon = true;
            }
            if ((pictureBox3.Image == pictureBox5.Image) && (pictureBox5.Image == pictureBox7.Image) && (pictureBox3.Image != null))
            {
                someoneWon = true;
            }


            if (someoneWon && wasXUsed)
            {
                MessageBox.Show("X Wins!\nPress OK to play a new game.");
                restartGame();
            }
            else if (someoneWon && !wasXUsed)
            {
                MessageBox.Show("O Wins!\nPress OK to play a new game.");
                restartGame();

            }
            else if (rounds == 9)
            {
                MessageBox.Show("It's a draw!\nPress OK to play a new game.");
                restartGame();
            }

        }

        private void restartGame()
        {
            foreach (PictureBox pictureBox in Controls.OfType<PictureBox>())
            {
                pictureBox.Image = null;
            }
            rounds = 0;
            wasXUsed = false;
        }

    }
}
