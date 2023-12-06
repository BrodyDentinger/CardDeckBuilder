/*
 Name: Brody Dentinger
 File: Form1.cs
 Description: This is the main class file for this project. This file implements all other classes to code functionality into
our game.
 Date: November 16, 2023
 */

namespace COSC2100Assignment4BrodyDentinger
{
    public partial class Form1 : Form
    {

        // Initalize a deck.
        Deck currentGameDeck = new Deck();

        // Intiatilize a custom deck.
        CustomDeck currentCustomDeck = new CustomDeck();

        // Intialize a list for drawn cards.
        List<Card> allDrawnCardsList = new List<Card>();

        public Form1()
        {
            InitializeComponent();
        }

        /*
         Validate Inputs.
        Will validate given control inputs and return true if valid, false if not.
         */
        private bool validateInputs(Control control1 = null, Control control2 = null, Control control3 = null)
        {

            // Validating the draw text box
            if (control1 == drawTextBox || control2 == drawTextBox || control3 == drawTextBox)
            {
                // If the draw text box is not empty
                if (drawTextBox.Text.Trim() != "")
                {
                    // Get the string value of the desired draw amount.
                    string drawString = drawTextBox.Text;

                    // Try to Parse that into a integer value.
                    if (int.TryParse(drawString, out int drawInt))
                    {

                        int numberOfCardsLeft = currentGameDeck.listOfCards.Count;

                        // If that value if > 0 and less than the count of the current deck
                        if (drawInt < numberOfCardsLeft)
                        {
                            if (drawInt > 0)
                            {
                                return true;
                            }
                            else
                            {
                                MessageBox.Show("Draw amount must a postive number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Draw amount must be less than the total amount left in the deck: {numberOfCardsLeft}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Draw amount must be a numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Draw amount must not be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            // If validating for rank and suit text box
            else if (control1 == rankTextBox || control1 == suitTextBox || control2 == rankTextBox || control2 == suitTextBox || control3 == rankTextBox || control3 == suitTextBox)
            {
                if (rankTextBox.Text.Trim() != "" && suitTextBox.Text.Trim() != "")
                {
                    return true;

                }
                else
                {
                    MessageBox.Show("Rank and Suit must not be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        /*
         Reset Game
        Resets the current deck and all input fields and list views.
        */
        private void resetGame()
        {
            // Take current game deck, and make it equal to a new instance of the Deck class, effectively resetting it.
            currentGameDeck = new Deck();

            rankTextBox.Clear();
            suitTextBox.Clear();
            drawTextBox.Clear();
            dealtListView.Clear();
            deckListView.Clear();
        }


        /*
         View Deck
        On click, this will loop through our deck and append each ToString value of each card object onto our deck list view.
         */
        private void viewDeckButton_Click(object sender, EventArgs e)
        {

            // Clear the deck listview.
            deckListView.Items.Clear();

            // Repopulate with the current game deck.
            foreach (Card currentCard in currentGameDeck.listOfCards)
            {
                deckListView.Items.Add(currentCard.ToString());
            }

        }

        /*
         Shuffle Deck
        This will randomize the order of the list of cards in the current game deck.
         */
        private void shuffleDeckButton_Click(object sender, EventArgs e)
        {
            // Clear the deck list view.
            deckListView.Items.Clear();

            // Shuffle the current game deck.
            currentGameDeck.ShuffleDeck();
        }

        /*
         Add Custom Card.
        This will create a new object of the card class and add it to the current game deck.
         
         */
        private void addCustomButton_Click(object sender, EventArgs e)
        {

            // Clear the list view
            deckListView.Items.Clear();

            // Check if either input box is empty.
            if (validateInputs(suitTextBox, rankTextBox))
            {
                // Get the values.
                string suit = suitTextBox.Text;
                string rank = rankTextBox.Text;

                // Check if that suit AND rank already exist, if only one or none exist, create the card
                bool bothExists = currentGameDeck.listOfCards.Any(card => card.suit.ToLower() == suit.ToLower() && card.rank.ToLower() == rank.ToLower());
                bool bothExistsInDrawnDeck = allDrawnCardsList.Any(card => card.suit.ToLower() == suit.ToLower() && card.rank.ToLower() == rank.ToLower());

                if (bothExists || bothExistsInDrawnDeck)
                {
                    MessageBox.Show("A card of that suit and rank already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Instantiate the new card with user values.
                    Card newCard = currentCustomDeck.AddCustomCard(suit, rank);

                    // Add it to the current game deck.
                    currentGameDeck.listOfCards.Add(newCard);

                    // Clear the text fields
                    rankTextBox.Clear();
                    suitTextBox.Clear();
                }
            }
        }

        /*
         Deal Button
        This will remove a select number of cards from the current game deck, and add them to the dealt cards list view.
         */
        private void dealButton_Click(object sender, EventArgs e)
        {

            // Clear the deck list view
            deckListView.Items.Clear();

            // If the draw textbox is valid
            if (validateInputs(drawTextBox))
            {

                // parse the value into an int again because we have to use a function for this for some reason.
                if (int.TryParse(drawTextBox.Text, out int drawInt))
                {
                    // Draw that amount of cards from the current deck and create a new list of drawn cards.
                    List<Card> drawnCardList = currentGameDeck.DealDeck(drawInt);

                    // Add those cards to our overall list of all drawn cards.
                    foreach (Card currentCard in drawnCardList)
                    {
                        allDrawnCardsList.Insert(0, currentCard);
                    }

                    // Clear the drawn card list view every time the draw button is used.
                    dealtListView.Clear();

                    // For every card in our ALL drawn card list, repopulate the drawn card list view.
                    foreach (Card currentCard in allDrawnCardsList)
                    {
                        dealtListView.Items.Insert(0, currentCard.ToString());
                    }

                    // Clear the draw text field
                    drawTextBox.Clear();
                }
            }
        }

        /*
         Reset Button.
        Resets all fields to their default state.
        Resets currentGameDeck.
         */
        private void resetButton_Click(object sender, EventArgs e)
        {
            resetGame();
        }

        /*
         Exit Button.
        Exits the application.
         */
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}