using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static twoDicePig.gameForm;

namespace twoDicePig
{
    public partial class gameForm : Form
    {
        public gameForm()
        {
            InitializeComponent();

            // Initialize game by resetting on start
            reset();
        }

        //Player data struct
        public struct Player
        {
            public int die1Roll;
            public int die2Roll;
            public int turnTotal;
            public int gameTotal;
        }

        // initialize players
        Player P1, P2;

        // P1 = 1, P2 = 2, Game Not Started = 0;
        int playerTurn = 0;

        // random Num Generator
        Random randomGenerator = new Random();

        public int win(ref Player player)
        {
            // Returns 1 if player won, 0 if not
            if (player.gameTotal >= 100)
                return 1;
            else
                return 0;
        }
        public void enableButtons(bool playP1, bool holdP1, bool playP2, bool holdP2)
        {
            // Enables/disables buttons using arguments given by function
            btnPlayP1.Enabled = playP1;
            btnHoldP1.Enabled = holdP1;
            btnPlayP2.Enabled = playP2;
            btnHoldP2.Enabled = holdP2;
        }
        public void reset()
        {
            // Reset scores
            P1.turnTotal = 0;
            P1.gameTotal = 0;
            P2.turnTotal = 0;
            P2.gameTotal = 0;

            //Update txt
            txtGameScoreP1.Text = P1.turnTotal.ToString();
            txtGameScoreP2.Text = P1.gameTotal.ToString();
            txtTurnScoreP1.Text = P2.turnTotal.ToString();
            txtTurnScoreP2.Text = P2.gameTotal.ToString();

            // Reset buttons
            enableButtons(false, false, false, false);
        }
        public void changeTurn()
        {
            // Changes turn
            if (playerTurn == 1)
            {
                playerTurn = 2;
                enableButtons(false, false, true, false);
                txtTurn.Text = "Player 2";
            }
            else
            {
                playerTurn = 1;
                enableButtons(true, false, false, false);
                txtTurn.Text = "Player 1";
            }
        }


        public string diceRoll(ref Player player)
        {
            // Roll random number
            player.die1Roll = randomGenerator.Next(1,7);
            player.die2Roll = randomGenerator.Next(1, 7);

            // UPDATE PICTUREBOX
            pbDice1.BackgroundImage = Image.FromFile(player.die1Roll.ToString() + ".png");
            pbDice2.BackgroundImage = Image.FromFile(player.die2Roll.ToString() + ".png");

            // Adds sum to turnTotal
            player.turnTotal += player.die1Roll + player.die2Roll;
            
            // Output string depending on output
            if (player.die1Roll == 1 && player.die2Roll == 1)
            {
                return "snake eyes";
            }
            else if(player.die1Roll == 1 || player.die2Roll == 1)
            {
                return "one";
            }
            else if(player.die1Roll == player.die2Roll)
            {
                return "double";
            }
            return "can hold";
        }
       

        private void btnPlayP1_Click(object sender, EventArgs e)
        {
            try
            {
                // Rolls Dice and updates txt
                string rollType = diceRoll(ref P1);
                txtTurnScoreP1.Text = P1.turnTotal.ToString();

                // Does corresponding actions depending on type of roll
                if (rollType == "snake eyes")
                {
                    MessageBox.Show("You got snake eyes. Your turn and game score is now 0 and it will be P2 turn.");

                    P1.turnTotal = 0;
                    P1.gameTotal = 0;
                    txtTurnScoreP1.Text = P1.turnTotal.ToString();
                    txtGameScoreP1.Text = P1.gameTotal.ToString();
                    changeTurn();
                }
                else if (rollType == "one")
                {
                    MessageBox.Show("You rolled a one. Your turn score will become 0 and it will be P2 turn.");
                    P1.turnTotal = 0;
                    txtTurnScoreP1.Text = P1.turnTotal.ToString();
                    changeTurn();
                }
                else if (rollType == "double")
                {
                    MessageBox.Show("You rolled a double. You must roll.");
                    enableButtons(true, false, false, false);
                    return;
                }
                else
                {
                    enableButtons(true, true, false, false);
                }

                // Win Condition Message
                if ((P1.turnTotal + P1.gameTotal) >= 100)
                {
                    MessageBox.Show("You are in a win situation.");
                }
            }
            catch
            {
                // Gives error message and resets game
                MessageBox.Show("ERROR! PLEASE CONTACT A DEVELOPER!");
                reset();
            }
        }

        private void btnHoldP1_Click(object sender, EventArgs e)
        {
            try
            {
                // Updates P1 Game Score
                P1.gameTotal += P1.turnTotal;
                P1.turnTotal = 0;
                txtTurnScoreP1.Text = P1.turnTotal.ToString();
                txtGameScoreP1.Text = P1.gameTotal.ToString();

                // Checks if player won and takes corresponding action
                if (win(ref P1) == 1)
                {
                    MessageBox.Show("Player 1 Wins!!!");
                    reset();
                }
                else
                    changeTurn();
            }
            catch
            {
                // Gives error message and resets game
                MessageBox.Show("ERROR! PLEASE CONTACT A DEVELOPER!");
                reset();
            }
        }

        private void btnPlayP2_Click(object sender, EventArgs e)
        {
            try
            {
                // Rolls Dice and updates txt
                string rollType = diceRoll(ref P2);
                txtTurnScoreP2.Text = P2.turnTotal.ToString();

                // Does corresponding actions depending on type of roll
                if (rollType == "snake eyes")
                {
                    MessageBox.Show("You got snake eyes. Your turn and game score is now 0 and it will be P2 turn.");
                    P2.turnTotal = 0;
                    P2.gameTotal = 0;
                    txtTurnScoreP2.Text = P2.turnTotal.ToString();
                    txtGameScoreP2.Text = P2.gameTotal.ToString();
                    changeTurn();
                }
                else if (rollType == "one")
                {
                    MessageBox.Show("You rolled a one. Your turn score will become 0 and it will be P2 turn.");
                    P2.turnTotal = 0;
                    txtTurnScoreP2.Text = P2.turnTotal.ToString();
                    changeTurn();
                }
                else if (rollType == "double")
                {
                    MessageBox.Show("You rolled a double. You must roll.");
                    enableButtons(false, false, true, false);
                    return;
                }
                else
                {
                    enableButtons(false, false, true, true);
                }

                // Win condition message
                if ((P2.turnTotal + P2.gameTotal) >= 100)
                {
                    MessageBox.Show("You are in a win situation.");
                }
            }
            catch
            {
                // Gives error message and resets game
                MessageBox.Show("ERROR! PLEASE CONTACT A DEVELOPER!");
                reset();
            }
        }

        private void btnHoldP2_Click(object sender, EventArgs e)
        {
            // Updates P2 Game Score and changes turn
            P2.gameTotal += P2.turnTotal;
            P2.turnTotal = 0;
            txtTurnScoreP2.Text = P2.turnTotal.ToString();
            txtGameScoreP2.Text = P2.gameTotal.ToString();

            // Checks if player won and takes corresponding action
            if (win(ref P2) == 1)
            {
                MessageBox.Show("Player 2 Wins!!!");
                reset();
            }
            else
                changeTurn();
        }
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            try
            {
                // Reset scores, chooses player's turn, and sets up that player
                reset();
                playerTurn = randomGenerator.Next(1, 3);
                if(playerTurn == 1)
                {
                    txtTurn.Text = "Player 1";
                    enableButtons(true, false, false, false);
                }
                else if(playerTurn == 2)
                {
                    txtTurn.Text = "Player 2";
                    enableButtons(false, false, true, false);
                }
                
            }
            catch
            {
                // Gives error message and resets game
                MessageBox.Show("ERROR! PLEASE CONTACT A DEVELOPER!");
                reset();
            }
        }
    }
}
