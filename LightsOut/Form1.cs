using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightsOut
{
    public partial class Form1 : Form
    {
        static int boardSize = 5;
        Button[,] buttons;  // 2-D array of buttons
        private int move = 0;  // record the counts of user click
        Stack step = new Stack();  // record the process user click
        struct Point_coord
        {
            public int x;
            public int y;

            public Point_coord(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void ClearForm()
        {
            this.Controls.Clear();
        }

        private void CreateBoard()
        {
            buttons = new Button[boardSize, boardSize];
            int y = 50;
            for (int i = 0; i < boardSize; i++)
            {
                int x = 50;
                for (int j = 0; j < boardSize; j++)
                {
                    buttons[i, j] = new Button();
                    string name = "B" + i.ToString() + j.ToString();
                    buttons[i, j].Name = name;
                    buttons[i, j].Size = new Size(50, 50);
                    buttons[i, j].Location = new Point(x, y);
                    buttons[i, j].Click += new System.EventHandler(this.Button_Click);
                    this.Controls.Add(buttons[i, j]);
                    x += 50;
                }
                y += 60;
            }
            ResetBoard();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateBoard();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            ResetBoard();
        }

        private void ResetBoard()
        {
            Random rnd = new Random();
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    int k = rnd.Next(0, 2);
                    buttons[i, j].BackColor = (k==0)? Color.Red: Color.Gray;
                }
            }

            move = 0;
            moveCount.Text = move.ToString();
        }

        private void CheckWin()
        {
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    if(buttons[i,j].BackColor != Color.Gray)
                        return;
                }
            }
            MessageBox.Show("Congratulations, You Won!");  // could do something more fun than this
            ResetBoard();
        }

        private void FlipColor(int i, int j)
        {
            buttons[i, j].BackColor = (buttons[i, j].BackColor == Color.Red) ? Color.Gray : Color.Red;
            return;
        }

        /**
         * Flip the color of this button and its neighbors. 
         */
        private void FlipPlus(int i, int j)
        {
            FlipColor(i, j);
            if (i > 0) //top of click
            {
                FlipColor(i - 1, j);
            }
            if (i < boardSize - 1) //bottom of click
            {
                FlipColor(i + 1, j);
            }
            if (j > 0) //left of click
            {
                FlipColor(i, j - 1);
            }
            if (j < boardSize - 1) //right of click
            {
                FlipColor(i, j + 1);
            }
            return;
        }

        /**
         * A light button is clicked. Flip the color of this button and buttons around. 
         */ 
        private void Button_Click(object sender, EventArgs e)
        {
            Button curr = (Button)sender;
            string name = curr.Name;
            name.ToCharArray();
            int i = name[1] - '0';
            int j = name[2] - '0';
            FlipPlus(i, j);
            move++;  // increase the count of user click

            Point_coord coord = new Point_coord(i, j);
            step.Push(coord);  // record the move
            moveCount.Text = move.ToString();
            CheckWin();
        }

        /**
         * User undo a click.  
         */
        private void Undo_Click(object sender, EventArgs e)
        {
            if(step.Count == 0 || move <= 0)  // should not undo under these circumstances 
            {
                return;
            }
            Point_coord tmp = (Point_coord)step.Pop();
            int x = tmp.x;
            int y = tmp.y;
            FlipPlus(x, y);
            move--;
            moveCount.Text = move.ToString();
        }

        /**
         * Delete all buttons that represent the lights. 
         */ 
        private void DeleteButtons()
        {
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    this.Controls.Remove(buttons[i, j]);
                }
            }
        }

        /**
         * Change the board size according to user input. 
         */
        private void Difficulty_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            var result = f.ShowDialog();
            if(result == DialogResult.OK)
            {
                int tmp = f.ReturnVal;
                DeleteButtons();  // clear the original array of buttons
                boardSize = tmp;
                CreateBoard();
            }
        }
    }
}
