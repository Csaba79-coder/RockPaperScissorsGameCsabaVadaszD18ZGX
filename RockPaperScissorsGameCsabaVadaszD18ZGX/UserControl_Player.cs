using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RockPaperScissorsGameCsabaVadaszD18ZGX
{
    public partial class UserControl_Player : UserControl
    {
        int numberOfPlayer;
        public string resultOfShowing = "";

        public UserControl_Player(int player)
        {
            InitializeComponent();
            numberOfPlayer = player;
        }

        private void UserControl_Player_Load(object sender, EventArgs e)
        {
            labelPlayer.Text = "Player " + numberOfPlayer;

            resultOfShowing = randomShowing().ToString();

            switch (resultOfShowing)
            {
                case "Rock":
                    pictureBoxShow.Image = Properties.Resources.rock;
                    break;
                case "Paper":
                    pictureBoxShow.Image = Properties.Resources.paper;
                    break;
                case "Scissors":
                    pictureBoxShow.Image = Properties.Resources.scissors;
                    break;
            }
        }

        private Showing randomShowing()
        { 
            return (Showing) new Random().Next(Enum.GetNames(typeof(Showing)).Length);
        }

        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
        }
    }
}
