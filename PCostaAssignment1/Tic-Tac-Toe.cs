/*
 * Assignment 1
 * Programmer: Patricia Canuto Vieira da Costa
 * Revision History:
 *      2020-09-28: UI designed, code written, debbuged
 *      2020-09-29: Bug fixing, comments added, ajustments to meet standards
 *      2020-09-30: Documentation comments added
 */

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
            lblPlayerX.Visible = true;

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
            WriteXOrO(pictureBox1);            
            CheckWinner();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WriteXOrO(pictureBox2);
            CheckWinner();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WriteXOrO(pictureBox3);
            CheckWinner();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            WriteXOrO(pictureBox4);
            CheckWinner();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            WriteXOrO(pictureBox5);
            CheckWinner();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            WriteXOrO(pictureBox6);
            CheckWinner();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            WriteXOrO(pictureBox7);
            CheckWinner();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            WriteXOrO(pictureBox8);
            CheckWinner();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            WriteXOrO(pictureBox9);
            CheckWinner();

        }

        
        /// <summary>
        /// Writes (displays the picture of) an "X", if the picureBox is null and the "X" was not yet used, or an "O", if the pictureBox is null but the "X" was already used.
        /// </summary>
        /// <param name="pictureBox">The name of the pictureBox that will have the X or the O written/displayed on.</param>
        private void WriteXOrO(PictureBox pictureBox)
        {
            if (pictureBox.Image == null && wasXUsed == false)
            {
                pictureBox.Image = imgX;
                wasXUsed = true;
                lblPlayerO.Visible = true;
                lblPlayerX.Visible = false;
                rounds++;
            }
            else if (pictureBox.Image == null)
            {
                pictureBox.Image = imgO;
                rounds++;
                wasXUsed = false;
                lblPlayerO.Visible = false;
                lblPlayerX.Visible = true;
            }
        }

        /// <summary>
        /// Checks who is the winner (X or O) or if there's a tie, and displays it in a message box.
        /// </summary>
        private void CheckWinner()
        {
            bool someoneWon = CheckIfSomeoneWon();

            // Show message box with the winner or if it's a tie
            if (someoneWon && wasXUsed)
            {
                MessageBox.Show("X Wins!\nPress OK to play a new game.", "Tic-Tac-Toe");
                RestartGame();
            }
            else if (someoneWon && !wasXUsed)
            {
                MessageBox.Show("O Wins!\nPress OK to play a new game.", "Tic-Tac-Toe");
                RestartGame();

            }
            else if (rounds == 9)
            {
                MessageBox.Show("We have a tie!\nPress OK to play a new game.", "Tic-Tac-Toe");
                RestartGame();
            }

        }

        /// <summary>
        /// Checks each line, row, and diagonals to see if the same type of image is being displayed, to define if someone won.
        /// </summary>
        /// <returns>True if someone won the game, or false otherwise.</returns>
        private bool CheckIfSomeoneWon()
        {
            bool someoneWon = false;

            // Check lines
            if ((pictureBox1.Image == pictureBox2.Image) && (pictureBox2.Image == pictureBox3.Image) && (pictureBox1.Image != null))
            {
                someoneWon = true;
            }
            else if ((pictureBox4.Image == pictureBox5.Image) && (pictureBox5.Image == pictureBox6.Image) && (pictureBox4.Image != null))
            {
                someoneWon = true;
            }
            else if ((pictureBox7.Image == pictureBox8.Image) && (pictureBox8.Image == pictureBox9.Image) && (pictureBox7.Image != null))
            {
                someoneWon = true;
            }

            // Check rows
            else if ((pictureBox1.Image == pictureBox4.Image) && (pictureBox4.Image == pictureBox7.Image) && (pictureBox1.Image != null))
            {
                someoneWon = true;
            }
            else if ((pictureBox2.Image == pictureBox5.Image) && (pictureBox5.Image == pictureBox8.Image) && (pictureBox2.Image != null))
            {
                someoneWon = true;
            }
            else if ((pictureBox3.Image == pictureBox6.Image) && (pictureBox6.Image == pictureBox9.Image) && (pictureBox3.Image != null))
            {
                someoneWon = true;
            }

            // Check diagonals
            else if ((pictureBox1.Image == pictureBox5.Image) && (pictureBox5.Image == pictureBox9.Image) && (pictureBox1.Image != null))
            {
                someoneWon = true;
            }
            else if ((pictureBox3.Image == pictureBox5.Image) && (pictureBox5.Image == pictureBox7.Image) && (pictureBox3.Image != null))
            {
                someoneWon = true;
            }

            return someoneWon;
        }

        /// <summary>
        /// Sets the game to its initial configuration.
        /// </summary>
        private void RestartGame()
        {
            foreach (PictureBox pictureBox in Controls.OfType<PictureBox>())
            {
                pictureBox.Image = null;
            }
            rounds = 0;
            wasXUsed = false;
            lblPlayerO.Visible = false;
            lblPlayerX.Visible = true;

        }

    }
}
