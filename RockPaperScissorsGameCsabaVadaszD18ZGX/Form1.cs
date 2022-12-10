using System.CodeDom;
using System.Net.NetworkInformation;

namespace RockPaperScissorsGameCsabaVadaszD18ZGX
{
    public partial class Game : Form
    {
        public static int round = 0;
        public static int scorePlayer1 = 0;
        public static int scorePlayer2 = 0;
        public string message = "";

        public Game()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            round++;

            flowLayoutPanel1.Controls.Clear();
            UserControl_Player userControlPlayer1 = new UserControl_Player(1);
            UserControl_Player userControlPlayer2 = new UserControl_Player(2);
            flowLayoutPanel1.Controls.Add(userControlPlayer1);
            flowLayoutPanel1.Controls.Add(userControlPlayer2);

            string message1 = userControlPlayer1.resultOfShowing;
            string message2 = userControlPlayer2.resultOfShowing;

            if (round == 1)
            {
                scorePlayer1 = 0;
                scorePlayer2 = 0;
            }

            if (round < 3)
            {
                string message = checkWinner(message1, message2);
                MessageBox.Show(message);
            }
            else
            {
                string message = checkWinner(message1, message2);

                if (isScoreEqual(scorePlayer1, scorePlayer2))
                {
                    MessageBox.Show("It is a tie, final game starts!");
                    round = 2;
                }
                else
                {
                    if (scorePlayer1 > scorePlayer2)
                    {
                        MessageBox.Show("Winner is Player 1");
                        round = 0;
                    }
                    else if (scorePlayer1 < scorePlayer2)
                    {
                        MessageBox.Show("Winner is Player 1");
                        round = 0;
                    }
                }
            }
        }

        private bool isScoreEqual(int score1, int score2)
        {
            return score1 == score2;
        }

        private string checkWinner (string firstPlayerShow, string secondPlayerShow)
        {
            string message = "";
            switch (firstPlayerShow)
            {
                case "Rock":
                    if (secondPlayerShow.Equals(Showing.Rock.ToString())) {
                        message = "It is a tie!";
                    }
                        
                    else if (secondPlayerShow.Equals(Showing.Paper.ToString()))
                    {
                        scorePlayer2++;
                        message = "Player2 win! Score: " + scorePlayer2;
                    }
                    else
                    {
                        scorePlayer1++;
                        message = "Player1 win! Score: " + scorePlayer1;
                    }
                    break;
                case "Paper":
                    if (secondPlayerShow.Equals(Showing.Rock.ToString()))
                    {
                        scorePlayer1++;
                        message = "Player1 win! Score: " + scorePlayer1;
                    }

                    else if (secondPlayerShow.Equals(Showing.Paper.ToString()))
                    {
                        message = "It is a tie!";
                    }
                    else
                    {
                        scorePlayer2++;
                        message = "Player2 win! Score: " + scorePlayer2;
                    }
                    break;
                case "Scissors":
                    if (secondPlayerShow.Equals(Showing.Rock.ToString()))
                    {
                        scorePlayer2++;
                        message = "Player2 win! Score: " + scorePlayer2;
                    }

                    else if (secondPlayerShow.Equals(Showing.Paper.ToString()))
                    {
                        scorePlayer1++;
                        message = "Player1 win! Score: " + scorePlayer1;
                    }
                    else
                    {
                        message = "It is a tie!";
                    }
                    break;
            }
            return message;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}