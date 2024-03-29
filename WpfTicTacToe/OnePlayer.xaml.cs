﻿using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfTicTacToe
{
    /// <summary>
    /// Interaction logic for OnePlayer.xaml
    /// </summary>
    public partial class OnePlayer : Window
    {
        #region Private Members

        private Random rnd = new Random();

        /// <summary>
        /// Holds the current result of text in the active game
        /// </summary>
        private MarkType[] mResults;

        /// <summary>
        /// True if it is player 1's turn (x) or player 2's turn (o)
        /// </summary>
        private bool mPlayer1Turn;

        /// <summary>
        /// True if the Game has ended
        /// </summary>
        private bool mGameEnded;

        /// <summary>
        /// Checks if we actually have a winner
        /// </summary>
        private bool aWin;

        #endregion Private Members

        #region Constructor

        public OnePlayer()
        {
            InitializeComponent();

            NewGame();
        }

        #endregion Constructor

        /// <summary>
        /// Starts a new game and clears all values back to start
        /// </summary>
        private void NewGame()
        {
            // Create a new blank array of free cells
            mResults = new MarkType[9];
            for (var i = 0; i < mResults.Length; i++)
                mResults[i] = MarkType.Free;

            // Make sure Player 1 starts the Game
            mPlayer1Turn = true;

            //Iterate every Button on the Grid
            Container.Children.Cast<Button>().ToList().ForEach(button =>
            {
                // Change Background, Foreground and Content to default values
                button.Content = string.Empty;
                button.Background = Brushes.White;
                button.Foreground = Brushes.Blue;
            });

            // Make sure the Game hasn't finished
            mGameEnded = false;

            // Sets the win to false on start
            aWin = false;
        }

        /// <summary>
        /// A Function that allows the Computer to play
        /// </summary>
        /// <param name="GridIndex"></param>
        /// <returns></returns>
        private async Task ComputerPlayAsync(int GridIndex)
        {
            string theIndex = GridIndex.ToString();

            this.Container.IsEnabled = false;
            await Task.Delay(2000);
            this.Container.IsEnabled = true;

            Container.Children.Cast<Button>().ToList().ForEach(button =>
            {
                // Change Background, Foreground and Content to default values
                //button.Content = string.Empty;
                //button.Background = Brushes.White;
                //button.Foreground = Brushes.Blue;

                if (button.Uid == theIndex)
                {
                    button.Content = "o";
                    button.Foreground = Brushes.Red;
                }
            });
        }

        /// <summary>
        /// Handles a Button Click Event
        /// </summary>
        /// <param name="sender">The Button that was clicked</param>
        /// <param name="e">The events of the click</param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Start a new game on the click after it finished
            if (mGameEnded)
            {
                NewGame();
                return;
            }

            // Cast the sender to button
            var button = (Button)sender;

            // Find the buttons position in the Grid
            var column = Grid.GetColumn(button);
            var row = Grid.GetRow(button);

            var index = column + (row * 3);

            // Don't do anything if the cell already has a value in it
            if (mResults[index] != MarkType.Free)
                return;

            // Set the cell value based on which players turn it is
            mResults[index] = MarkType.Cross;

            // Set button text to the result
            button.Content = "X";
            mPlayer1Turn = false;

            // Check for winners
            checkForWinners();

            // Change Noughts to Green Color
            if (!mPlayer1Turn && aWin == false)
            {
                int BtnToBeMarked;
                Random rnd = new Random();

                if ((mResults[0] == MarkType.Free)
                    || (mResults[1] == MarkType.Free)
                    || (mResults[2] == MarkType.Free)
                    || (mResults[3] == MarkType.Free)
                    || (mResults[4] == MarkType.Free)
                    || (mResults[5] == MarkType.Free)
                    || (mResults[6] == MarkType.Free)
                    || (mResults[7] == MarkType.Free)
                    || (mResults[8] == MarkType.Free))
                {
                    do
                    {
                        BtnToBeMarked = rnd.Next(0, 9);
                    } while (mResults[BtnToBeMarked] != MarkType.Free);

                    if (mResults[BtnToBeMarked] == MarkType.Free)
                    {
                        mResults[BtnToBeMarked] = MarkType.Nought;
                        ComputerPlayAsync(BtnToBeMarked);
                        mPlayer1Turn = true;
                    }
                }

                //Check for winners
                checkForWinners();
            }
            // Toggling between players turns True/false (If true, it sets it to False, if False, it sets it to True)
            //mPlayer1Turn ^= true;
        }

        /// <summary>
        /// Check if there is a winner of a three line straight
        /// </summary>
        private void checkForWinners()
        {
            #region Horizontal Wins

            // Check for horizontal wins
            //
            //  -Row 0
            //
            if (mResults[0] != MarkType.Free && (mResults[0] & mResults[1] & mResults[2]) == mResults[0])
            {
                // Game ends
                mGameEnded = true;

                // Sets the win to true
                aWin = true;

                // Highlight winning cells to Green
                Button0_0.Background = Button1_0.Background = Button2_0.Background = Brushes.Green;

                // Trow up a message showing who the winner is
                if (mResults[0] == MarkType.Cross)
                {
                    MessageBox.Show("Player One Wins!");
                }
                else if (mResults[0] == MarkType.Nought)
                {
                    MessageBox.Show("Player Two Wins!");
                }
            }
            //
            //  -Row 1
            //
            if (mResults[3] != MarkType.Free && (mResults[3] & mResults[4] & mResults[5]) == mResults[3])
            {
                // Game ends
                mGameEnded = true;

                // Sets the win to true
                aWin = true;

                // Highlight winning cells to Green
                Button0_1.Background = Button1_1.Background = Button2_1.Background = Brushes.Green;

                // Trow up a message showing who the winner is
                if (mResults[3] == MarkType.Cross)
                {
                    MessageBox.Show("Player One Wins!");
                }
                else if (mResults[3] == MarkType.Nought)
                {
                    MessageBox.Show("Player Two Wins!");
                }
            }
            //
            //  -Row 2
            //
            if (mResults[6] != MarkType.Free && (mResults[6] & mResults[7] & mResults[8]) == mResults[6])
            {
                // Game ends
                mGameEnded = true;

                // Sets the win to true
                aWin = true;

                // Highlight winning cells to Green
                Button0_2.Background = Button1_2.Background = Button2_2.Background = Brushes.Green;

                // Trow up a message showing who the winner is
                if (mResults[6] == MarkType.Cross)
                {
                    MessageBox.Show("Player One Wins");
                }
                else if (mResults[6] == MarkType.Nought)
                {
                    MessageBox.Show("Player Two Wins");
                }
            }

            #endregion Horizontal Wins

            #region Vertical Wins

            // Check for vertical wins
            //
            //  -Column 0
            //
            if (mResults[0] != MarkType.Free && (mResults[0] & mResults[3] & mResults[6]) == mResults[0])
            {
                // Game ends
                mGameEnded = true;

                // Sets the win to true
                aWin = true;

                // Highlight winning cells to Green
                Button0_0.Background = Button0_1.Background = Button0_2.Background = Brushes.Green;

                // Trow up a message showing who the winner is
                if (mResults[0] == MarkType.Cross)
                {
                    MessageBox.Show("Player One Wins!");
                }
                else if (mResults[0] == MarkType.Nought)
                {
                    MessageBox.Show("Player Two Wins!");
                }
            }
            //
            //  -Column 1
            //
            if (mResults[1] != MarkType.Free && (mResults[1] & mResults[4] & mResults[7]) == mResults[1])
            {
                // Game ends
                mGameEnded = true;

                // Sets the win to true
                aWin = true;

                // Highlight winning cells to Green
                Button1_0.Background = Button1_1.Background = Button1_2.Background = Brushes.Green;

                // Trow up a message showing who the winner is
                if (mResults[1] == MarkType.Cross)
                {
                    MessageBox.Show("Player One Wins!");
                }
                else if (mResults[1] == MarkType.Nought)
                {
                    MessageBox.Show("Player Two Wins!");
                }
            }
            //
            //  -Column 2
            //
            if (mResults[2] != MarkType.Free && (mResults[2] & mResults[5] & mResults[8]) == mResults[2])
            {
                // Game ends
                mGameEnded = true;

                // Sets the win to true
                aWin = true;

                // Highlight winning cells to Green
                Button2_0.Background = Button2_1.Background = Button2_2.Background = Brushes.Green;

                // Trow up a message showing who the winner is
                if (mResults[2] == MarkType.Cross)
                {
                    MessageBox.Show("Player One Wins!");
                }
                else if (mResults[2] == MarkType.Nought)
                {
                    MessageBox.Show("Player Two Wins!");
                }
            }

            #endregion Vertical Wins

            #region Diagonal Wins

            // Check for diagonal wins
            //
            //  -Top Left to Bottom Right
            //
            if (mResults[0] != MarkType.Free && (mResults[0] & mResults[4] & mResults[8]) == mResults[0])
            {
                // Game ends
                mGameEnded = true;

                // Sets the win to true
                aWin = true;

                // Highlight winning cells to Green
                Button0_0.Background = Button1_1.Background = Button2_2.Background = Brushes.Green;

                // Trow up a message showing who the winner is
                if (mResults[0] == MarkType.Cross)
                {
                    MessageBox.Show("Player One Wins!");
                }
                else if (mResults[0] == MarkType.Nought)
                {
                    MessageBox.Show("Player Two Wins!");
                }
            }
            //
            //  -Top Right to Bottom Left
            //
            if (mResults[2] != MarkType.Free && (mResults[2] & mResults[4] & mResults[6]) == mResults[2])
            {
                // Game ends
                mGameEnded = true;

                // Sets the win to true
                aWin = true;

                // Highlight winning cells to Green
                Button2_0.Background = Button1_1.Background = Button0_2.Background = Brushes.Green;

                // Trow up a message showing who the winner is
                if (mResults[2] == MarkType.Cross)
                {
                    MessageBox.Show("Player One Wins!");
                }
                else if (mResults[2] == MarkType.Nought)
                {
                    MessageBox.Show("Player Two Wins!");
                }
            }

            #endregion Diagonal Wins

            #region No Winners

            // Check for no winners and full board
            if (!mResults.Any(f => f == MarkType.Free))
            {
                // Game ended
                mGameEnded = true;

                // Turn all cells Orange
                Container.Children.Cast<Button>().ToList().ForEach(button =>
                {
                    button.Background = Brushes.Orange;
                });

                // Checks and throw a message showing that nobody won
                if (!aWin)
                {
                    MessageBox.Show("Nobody won!");
                }
                mPlayer1Turn = true;
            }

            #endregion No Winners
        }
    }
}