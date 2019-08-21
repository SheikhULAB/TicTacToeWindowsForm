using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTac
{
    public partial class TTT : Form
    {
        bool turn = true;
        int turn_count = 0;
        public TTT()
        {
            InitializeComponent();
        }

        private void Button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (turn)
            {
                button.Text = "X";
            }
            else
            {
                button.Text = "0";
            }

            turn = !turn;
            button.Enabled = false;
            turn_count++;
            check_win();
        }

        private void check_win()
        {
            bool is_winner = false;
            // horizontally
            if((button1.Text == button2.Text) && (button2.Text == button3.Text) && (!button1.Enabled && !button2.Enabled && !button3.Enabled))
            {
                is_winner = true;
            }
           else if ((button4.Text == button5.Text) && (button5.Text == button6.Text) && (!button4.Enabled && !button5.Enabled && !button6.Enabled))
            {
                is_winner = true;
            }
            else if ((button7.Text == button8.Text) && (button8.Text == button9.Text) && (!button7.Enabled && !button8.Enabled && !button9.Enabled))
            {
                is_winner = true;
            }

            //vertically
            if ((button1.Text == button4.Text) && (button4.Text == button7.Text) && (!button1.Enabled && !button4.Enabled && !button7.Enabled))
            {
                is_winner = true;
            }
            else if ((button2.Text == button5.Text) && (button5.Text == button8.Text) && (!button2.Enabled && !button5.Enabled && !button8.Enabled))
            {
                is_winner = true;
            }
            else if ((button3.Text == button6.Text) && (button6.Text == button9.Text) && (!button3.Enabled && !button6.Enabled && !button9.Enabled))
            {
                is_winner = true;
            }

            //diagonally

            if ((button1.Text == button5.Text) && (button5.Text == button9.Text) && (!button1.Enabled && !button5.Enabled && !button9.Enabled))
            {
                is_winner = true;
            }
            else if ((button3.Text == button5.Text) && (button5.Text == button7.Text) && (!button3.Enabled && !button5.Enabled && !button7.Enabled))
            {
                is_winner = true;
            }
           



            if (is_winner)
            {
                disable_button();
                String winner = "";

                if (turn)
                {
                    winner = "0";
                }
                else
                {
                    winner = "X";
                }

                MessageBox.Show(winner + " Wins");
            }
            else
            {
                if(turn_count == 9)
                {
                    MessageBox.Show("Game drawn");
                }
            }

        }

        private void disable_button()
        {
            foreach(Control C in Controls)
            {
                Button button = (Button)C;
                button.Enabled = false;
            }
        }
    }
}
