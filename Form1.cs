using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace tictactoe
{
    public partial class Form1 : Form
    {
        // below is the player class which has two value
        // X and O
        // by doing this we can control the player and AI symbols
        public enum Difficulty
        {
            Easy,
            Medium,
            Hard
        }

        public Difficulty gameDifficulty = Difficulty.Hard; // Установим сложный уровень по умолчанию

        private void AImove(object sender, EventArgs e)
        {
            if (buttons.Count > 0)
            {
                Button move = null;

                switch (gameDifficulty)
                {
                    case Difficulty.Easy:
                        move = GetRandomMove(); // Случайный ход
                        break;
                    case Difficulty.Medium:
                        move = GetMediumMove(); // Средний уровень: блокировка игрока
                        break;
                    case Difficulty.Hard:
                        move = GetHardMove(); // Сложный уровень: оптимальная стратегия
                        break;
                }

                if (move != null)
                {
                    move.Enabled = false;
                    currentPlayer = Player.O;
                    move.Text = currentPlayer.ToString();
                    move.BackColor = System.Drawing.Color.DarkSalmon;
                    buttons.Remove(move);
                    Check();
                }
                AImoves.Stop();
            }
        }

        private Button GetRandomMove()
        {
            int index = rand.Next(buttons.Count);
            return buttons[index];
        }

        private Button GetMediumMove()
        {
            // Блокировка выигрыша игрока, но не всегда выбирает оптимальный ход
            Button move = FindWinningMove("X");
            if (move == null)
            {
                move = GetRandomMove(); // Если блокировка не нужна, выбираем случайный ход
            }
            return move;
        }

        private Button GetHardMove()
        {
            // Оптимальный алгоритм с приоритетами
            Button move = FindWinningMove("O"); // Попытка выиграть
            if (move == null)
            {
                move = FindWinningMove("X"); // Попытка заблокировать игрока
            }
            if (move == null)
            {
                move = buttons.FirstOrDefault(b => b == button5); // Занять центр
            }
            if (move == null)
            {
                List<Button> corners = new List<Button> { button1, button3, button7, button9 };
                move = buttons.FirstOrDefault(b => corners.Contains(b)); // Выбрать угол
            }
            if (move == null)
            {
                move = GetRandomMove(); // Случайный ход
            }
            return move;
        }


        public enum Player
        {
            X, O
        }
        Player currentPlayer; // calling the player class 
        List<Button> buttons; // creating a LIST or array of buttons
        Random rand = new Random(); // importing the random number generator class
        int playerWins = 0; // set the player win integer to 0
        int computerWins = 0; // set the computer win integer to 0
        public Form1()
        {
            InitializeComponent();
            resetGame(); // call the set game function
        }
        private void playerClick(object sender, EventArgs e)
        {
            var button = (Button)sender; // find which button was clicked
            currentPlayer = Player.X; // set the player to X
            button.Text = currentPlayer.ToString(); // change the button text to player X
            button.Enabled = false; // disable the button
            button.BackColor = System.Drawing.Color.Cyan; // change the player colour to Cyan
            buttons.Remove(button); //remove the button from the list buttons so the AI can't click it either
            Check(); // check if the player won
            AImoves.Start(); // start the AI timer
        }
        

        private Button FindWinningMove(string symbol)
        {
            // Проверка всех комбинаций выигрыша
            List<(Button, Button, Button)> winningCombinations = new List<(Button, Button, Button)>
    {
        (button1, button2, button3),
        (button4, button5, button6),
        (button7, button8, button9),
        (button1, button4, button7),
        (button2, button5, button8),
        (button3, button6, button9),
        (button1, button5, button9),
        (button3, button5, button7)
    };

            foreach (var (b1, b2, b3) in winningCombinations)
            {
                if (b1.Text == symbol && b2.Text == symbol && b3.Text == "?") return b3;
                if (b1.Text == symbol && b3.Text == symbol && b2.Text == "?") return b2;
                if (b2.Text == symbol && b3.Text == symbol && b1.Text == "?") return b1;
            }
            return null;
        }
        private void restartGame(object sender, EventArgs e)
        {
            // this function is linked with the reset button
            // when the reset button is clicked then
            // this function will run the reset game function
            resetGame();
        }
        private void loadbuttons()
        {
            // this the custom function which will load all the buttons from the form to the buttons list
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button9, button8 };
        }
        private void resetGame()
        {
            //check each of the button with a tag of play
            foreach (Control X in this.Controls)
            {
                if (X is Button && X.Tag == "play")
                {
                    ((Button)X).Enabled = true; // change them all back to enabled or clickable
                    ((Button)X).Text = "?"; // set the text to question mark
                    ((Button)X).BackColor = default(Color); // change the background colour to default button colors
                }
            }
            loadbuttons(); // run the load buttons function so all the buttons are inserted back in the array
        }
        private void Check()
        {
            //in this function we will check if the player or the AI has won
            // we have two very large if statements with the winning possibilities
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X"
               || button4.Text == "X" && button5.Text == "X" && button6.Text == "X"
               || button7.Text == "X" && button9.Text == "X" && button8.Text == "X"
               || button1.Text == "X" && button4.Text == "X" && button7.Text == "X"
               || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
               || button3.Text == "X" && button6.Text == "X" && button9.Text == "X"
               || button1.Text == "X" && button5.Text == "X" && button9.Text == "X"
               || button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                // if any of the above conditions are met
                AImoves.Stop(); //stop the timer
                MessageBox.Show("Player Wins"); // show a message to the player
                playerWins++; // increase the player wins 
                label1.Text = "Player Wins- " + playerWins; // update player label
                resetGame(); // run the reset game function
            }
            // below if statement is for when the AI wins the game
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O"
            || button4.Text == "O" && button5.Text == "O" && button6.Text == "O"
            || button7.Text == "O" && button9.Text == "O" && button8.Text == "O"
            || button1.Text == "O" && button4.Text == "O" && button7.Text == "O"
            || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
            || button3.Text == "O" && button6.Text == "O" && button9.Text == "O"
            || button1.Text == "O" && button5.Text == "O" && button9.Text == "O"
            || button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                // if any of the conditions are met above then we will do the following
                // this code will run when the AI wins the game
                AImoves.Stop(); // stop the timer
                MessageBox.Show("Computer Wins"); // show a message box to say computer won
                computerWins++; // increase the computer wins score number
                label2.Text = "AI Wins- " + computerWins; // update the label 2 for computer wins
                resetGame(); // run the reset game
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            foreach (Control X in this.Controls)
            {
                if (X is Button && X.Tag == "play")
                {
                    ((Button)X).Enabled = true; // change them all back to enabled or clickable
                    ((Button)X).Text = "?"; // set the text to question mark
                    ((Button)X).BackColor = default(Color); // change the background colour to default button colors
                }
            }
            loadbuttons(); // run the load buttons function so all the buttons are inserted back in the array
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = (ComboBox)sender;
            switch (comboBox.SelectedItem.ToString())
            {
                case "Easy":
                    gameDifficulty = Difficulty.Easy;
                    break;
                case "Medium":
                    gameDifficulty = Difficulty.Medium;
                    break;
                case "Hard":
                    gameDifficulty = Difficulty.Hard;
                    break;
            }
        }
    }
}