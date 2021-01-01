using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPS
{
    public partial class game : Form
    {
        string won = "You Won";
        string loss = "You Lost";
        string tie = "Match Tied";       
        public game()
        {
            InitializeComponent();            
        }

        int playerscore, enemyscore = 0;
        private void rock_Click(object sender, EventArgs e)
        {            
            playround(1);
        }

        private void paper_Click(object sender, EventArgs e)
        {           
            playround(2);
        }

        private void scissors_Click(object sender, EventArgs e)
        {            
            playround(3);
        }
        private void playround(int selection)
        {
            Random rnd = new Random();
            int enemyselection = rnd.Next(1, 4);

            setimage(userpic, selection);
            setimage(compic, enemyselection);

            if (enemyselection == selection)
            {
                status.Text = tie;
                return;
            }

            switch(selection)
            {
                case 1:
                    if (enemyselection == 3)
                        updatescore(true);
                    else
                        updatescore(false);
                    break;
                case 2:
                    if (enemyselection == 1)
                        updatescore(true);
                    else
                        updatescore(false);
                    break;
                case 3:
                    if (enemyselection == 2)
                        updatescore(true);
                    else
                        updatescore(false);
                    break;
            }
        }

        private void updatescore(bool playerwon)
        {
            if (playerwon)
            {
                playerscore++;
                status.Text = won;
                userscore.Text = playerscore.ToString();
            }
            else
            {
                enemyscore++;
                status.Text = loss;
                comscore.Text = enemyscore.ToString();
            }
        }
        private void setimage (PictureBox pb, int img)
        {
            if (img == 1)
            {
                pb.Image = global::RPS.Properties.Resources.rock;
            }
            else if (img == 2)
            {
                pb.Image = global::RPS.Properties.Resources.paper;
            }
            else if (img == 3)
            {
                pb.Image = global::RPS.Properties.Resources.scissors;
            }
        }
    }
}



