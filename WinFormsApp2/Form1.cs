using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Tictactoetbl : Form
    {
        Boolean checker;
        int plusone;
        
        void Enable_false()
        {
            btontic1.Enabled = false;
            btontic2.Enabled = false;
            btontic3.Enabled = false;
            btontic4.Enabled = false;
            btontic5.Enabled = false;
            btontic6.Enabled = false;
            btontic7.Enabled = false;
            btontic8.Enabled = false;
            btontic9.Enabled = false;
        }
        void score()
        {
            if (btontic1.Text == "X" && btontic4.Text == "X" && btontic7.Text == "X")
            {
                MessageBox.Show("The winner is Player X !", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblscorex.Text);
                lblscorex.Text = Convert.ToString(plusone);
                Enable_false();
            }
            if (btontic1.Text == "X" && btontic2.Text == "X" && btontic3.Text == "X")
            {
                MessageBox.Show("The winner is Player X !", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblscorex.Text);
                lblscorex.Text = Convert.ToString(plusone);
                Enable_false();
            }
            if (btontic1.Text == "X" && btontic5.Text == "X" && btontic9.Text == "X")
            {
                MessageBox.Show("The winner is Player X !", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblscorex.Text);
                lblscorex.Text = Convert.ToString(plusone);
                Enable_false();
            }
            if (btontic2.Text == "X" && btontic5.Text == "X" && btontic8.Text == "X")
            {
                MessageBox.Show("The winner is Player X !", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblscorex.Text);
                lblscorex.Text = Convert.ToString(plusone);
                Enable_false();
            }
            if (btontic4.Text == "X" && btontic5.Text == "X" && btontic6.Text == "X")
            {
                MessageBox.Show("The winner is Player X !", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblscorex.Text);
                lblscorex.Text = Convert.ToString(plusone);
                Enable_false();
            }
            if (btontic7.Text == "X" && btontic8.Text == "X" && btontic9.Text == "X")
            {
                MessageBox.Show("The winner is Player X !", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblscorex.Text);
                lblscorex.Text = Convert.ToString(plusone);
                Enable_false();
            }
            if (btontic3.Text == "X" && btontic6.Text == "X" && btontic9.Text == "X")
            {
                MessageBox.Show("The winner is Player X !", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblscorex.Text);
                lblscorex.Text = Convert.ToString(plusone);
                Enable_false();
            }
            if (btontic3.Text == "X" && btontic5.Text == "X" && btontic7.Text == "X")
            {
                MessageBox.Show("The winner is Player X !", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblscorex.Text);
                lblscorex.Text = Convert.ToString(plusone);
                Enable_false();
            }
            if (btontic1.Text == "O" && btontic4.Text == "O" && btontic7.Text == "O")
            {
                MessageBox.Show("The winner is Player O !", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblscoreo.Text);
                lblscoreo.Text = Convert.ToString(plusone);
                Enable_false();
            }
            if (btontic1.Text == "O" && btontic2.Text == "O" && btontic3.Text == "O")
            {
                MessageBox.Show("The winner is Player O !", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblscoreo.Text);
                lblscoreo.Text = Convert.ToString(plusone);
                Enable_false();
            }
            if (btontic1.Text == "O" && btontic5.Text == "O" && btontic9.Text == "O")
            {
                MessageBox.Show("The winner is Player O !", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblscoreo.Text);
                lblscoreo.Text = Convert.ToString(plusone);
                Enable_false();
            }
            if (btontic2.Text == "O" && btontic5.Text == "O" && btontic8.Text == "O")
            {
                MessageBox.Show("The winner is Player O !", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblscoreo.Text);
                lblscoreo.Text = Convert.ToString(plusone);
                Enable_false();
            }
            if (btontic4.Text == "O" && btontic5.Text == "O" && btontic6.Text == "O")
            {
                MessageBox.Show("The winner is Player O !", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblscoreo.Text);
                lblscoreo.Text = Convert.ToString(plusone);
                Enable_false();
            }
            if (btontic7.Text == "O" && btontic8.Text == "O" && btontic9.Text == "O")
            {
                MessageBox.Show("The winner is Player O !", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblscoreo.Text);
                lblscoreo.Text = Convert.ToString(plusone);
                Enable_false();
            }
            if (btontic3.Text == "O" && btontic6.Text == "O" && btontic9.Text == "O")
            {
                MessageBox.Show("The winner is Player O !", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblscoreo.Text);
                lblscoreo.Text = Convert.ToString(plusone);
                Enable_false();
            }
            if (btontic3.Text == "O" && btontic5.Text == "O" && btontic7.Text == "O")
            {
                MessageBox.Show("The winner is Player O !", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblscoreo.Text);
                lblscoreo.Text = Convert.ToString(plusone);
                Enable_false();
            }
        }
        private void enablefalse()
        {
            throw new NotImplementedException();
        }

        public Tictactoetbl()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Btntic6_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btontic6.Text = "X";
                checker = true;
            }
            else
            {
                btontic6.Text = "O";
                checker = false;
            }
            score();
            btontic6.Enabled = false; 
        }
        private void btontic1_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btontic1.Text = "X";
                checker = true;
            }
            else
            {
                btontic1.Text = "O";
                checker = false;
            }
            score();
            btontic1.Enabled = false;
        }
        private void btontic2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btontic2.Text = "X";
                checker = true;
            }
            else
            {
                btontic2.Text = "O";
                checker = false;
            }
            score();
            btontic2.Enabled = false;
        }
        private void btontic3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btontic3.Text = "X";
                checker = true;
            }
            else
            {
                btontic3.Text = "O";
                checker = false;
            }
            score();
            btontic3.Enabled = false;
        }
        private void btontic4_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btontic4.Text = "X";
                checker = true;
            }
            else
            {
                btontic4.Text = "O";
                checker = false;
            }
            score();
            btontic4.Enabled = false;
        }
        private void btontic5_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btontic5.Text = "X";
                checker = true;
            }
            else
            {
                btontic5.Text = "O";
                checker = false;
            }
            score();
            btontic5.Enabled = false;
        }
        private void btontic7_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btontic7.Text = "X";
                checker = true;
            }
            else
            {
                btontic7.Text = "O";
                checker = false;
            }
            score();
            btontic7.Enabled = false;
        }
        private void btontic8_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btontic8.Text = "X";
                checker = true;
            }
            else
            {
                btontic8.Text = "O";
                checker = false;
            }
            score();
            btontic8.Enabled = false;
        }
        private void btontic9_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btontic9.Text = "X";
                checker = true;
            }
            else
            {
                btontic9.Text = "O";
                checker = false;
            }
            score();
            btontic9.Enabled = false;
        }
        private void btnNewgame_Click(object sender, EventArgs e)
        {
            btontic1.Enabled = true;
            btontic2.Enabled = true;
            btontic3.Enabled = true;
            btontic4.Enabled = true;
            btontic5.Enabled = true;
            btontic6.Enabled = true;
            btontic7.Enabled = true;
            btontic8.Enabled = true;
            btontic9.Enabled = true;

            btontic1.Text = "";
            btontic2.Text = "";
            btontic3.Text = "";
            btontic4.Text = "";
            btontic5.Text = "";
            btontic6.Text = "";
            btontic7.Text = "";
            btontic8.Text = "";
            btontic9.Text = "";
        }
    }
}
