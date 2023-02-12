using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_4.Theacher
{
    public partial class GameXandO : Form
    {
        public GameXandO()
        {
            InitializeComponent();
        }
        string player1 = "X", player2 = "Y";
        int step = 0;



        private void b1_Click(object sender, EventArgs e)
        {
            
            b1.Text = Step(b1.Text);
            GameOver();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            b2.Text = Step(b2.Text);
            GameOver();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            b3.Text = Step(b3.Text);
            GameOver();
        }

        private void b4_Click(object sender, EventArgs e)
        {
            b4.Text = Step(b4.Text);
            GameOver();
        }

        private void b5_Click(object sender, EventArgs e)
        {
            b5.Text = Step(b5.Text);
            GameOver();
        }

        private void b6_Click(object sender, EventArgs e)
        {
            b6.Text = Step(b6.Text);
            GameOver();
        }

        private void b7_Click(object sender, EventArgs e)
        {
            b7.Text = Step(b7.Text);
            GameOver();
        }

        private void b8_Click(object sender, EventArgs e)
        {
            b8.Text = Step(b8.Text);
            GameOver();
        }

        private void b9_Click(object sender, EventArgs e)
        {
            b9.Text = Step(b9.Text);
            GameOver();
        }
        string Step ( string chek)
        {
            if(chek == "")
            {
                if(step %2 == 0)
                {
                    
                    step++;
                    return player1;
                }
                else
                {
                    step++;
                    return player2;
                }
            }
            else
            {
                return chek;
            }

        }
        void Reset()
        {
            b1.Text = "";
            b2.Text = "";
            b3.Text = "";
            b4.Text = "";
            b5.Text = "";
            b6.Text = "";
            b7.Text = "";
            b8.Text = "";
            b9.Text = "";
            
            step = 0;
        }

        private void GameXandO_Load(object sender, EventArgs e)
        {
           
        }
        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void GameOver()
        {
            if (b1.Text == b2.Text && b2.Text == b3.Text && b1.Text != "")
            {   
                label2.Text = $" Last match win {b1.Text}";
                Reset();
            }
            else if (b4.Text == b5.Text && b5.Text == b6.Text&& b4.Text!="")
            {
                label2.Text = $" Last match win {b4.Text}";
                Reset();
            }
            else if (b7.Text == b8.Text && b8.Text == b9.Text && b7.Text != "")
            {
                
                label2.Text = $" Last match win {b7.Text}";
                Reset();
            }
            else if (b1.Text == b4.Text && b4.Text == b7.Text && b1.Text != "")
            {
                
                label2.Text = $" Last match win {b1.Text}";
                Reset();
            }
            else if (b2.Text == b5.Text && b5.Text == b8.Text && b2.Text != "")
            {
               
                label2.Text = $" Last match win {b2.Text}";
                Reset();
            }
            else if (b3.Text == b6.Text && b6.Text == b9.Text && b3.Text != "")
            {
                
                label2.Text = $" Last match win {b3.Text}";
                Reset();
            }
            else if (b1.Text == b5.Text && b5.Text == b9.Text && b1.Text != "")
            {
                
                label2.Text = $" Last match win {b1.Text}";
                Reset();
            }
            else if (b3.Text == b5.Text && b5.Text == b7.Text && b3.Text != "")
            {
                
                label2.Text = $" Last match win {b3.Text}";
                Reset();
            }
            else if (b1.Text != "" && b2.Text != "" && b3.Text != "" && b4.Text != "" && b5.Text != "" && b6.Text != "" && b7.Text != "" && b8.Text != "" && b9.Text != "")
            {
                label2.Text = $" Nichia {b1.Text}";
                Reset();
            }



        }
    }
}
