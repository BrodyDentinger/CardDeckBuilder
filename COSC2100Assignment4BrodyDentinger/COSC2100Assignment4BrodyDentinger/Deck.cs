/*
 Name: Brody Dentinger
 File: Deck.cs
 Description: This class file is used to create new decks.
 Date: November 13, 2023
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace COSC2100Assignment4BrodyDentinger
{
    internal class Deck
    {

        // Create a list to hold our deck (Our card objects)
        internal List<Card> listOfCards = new List<Card>();

        // Create 2 lists for suits and ranks
        List<string> listOfSuits = new List<string>()
        {
            "Clubs", "Diamonds", "Hearts", "Spades"
        };
        List<string> listOfRanks = new List<string>() 
        {
            "Two","Three","Four", "Five","Six","Seven","Eight","Nine","Ten","Jack","Queen","King","Ace"
        };

        // Default Constructor
        public Deck ()
        {
            // Populate and return the list of 52 basic cards (deck)
            CreateDeck();
        }

        // Methods
        public List<Card> CreateDeck()
        {
            // Method that Loops through 2 lists
            // (one for rank, one for suit, and instantiate a card object for every suit and rank
            foreach (string currentSuit in listOfSuits)
            {
                foreach (string currentRank in listOfRanks)
                {   
                    // Create the card
                    Card cardOne = new Card(currentSuit, currentRank);

                    // Add the card to the list of cards
                    listOfCards.Add(cardOne);
                }
            }
            // Return the list
            return listOfCards;
        }

        // Shuffle
        public void ShuffleDeck()
        {   
            // Orders the list of cards by giving each a new GUID (unique identifier), and creating a new list with them
            listOfCards = listOfCards.OrderBy(x => Guid.NewGuid()).ToList();
        }

        /*
         Deal from Deck
        This function takes a draw quantity, and a currently used deck.
        Will create a new list of drawn cards by taking the first 0 - x quantity of cards
        Will Remove the same range from the currently used game deck.
        Returns the drawn card list.
        */
        public List<Card> DealDeck(int drawQuantity)
        {
            // Get the range specified by the user in the box
            List<Card> drawnCardsList = listOfCards.GetRange(0, drawQuantity);

            // Remove the range from the custom deck
            listOfCards.RemoveRange(0, drawQuantity);

            // return the list of cards that were drawn
            return drawnCardsList;

        }

    }
}
