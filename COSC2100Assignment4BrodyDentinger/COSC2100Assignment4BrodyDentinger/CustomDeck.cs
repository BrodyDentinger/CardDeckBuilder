/*
 Name: Brody Dentinger
 File: CustomDeck.cs
 Description: This class file is used to create custom decks.
 Date: November 16, 2023
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COSC2100Assignment4BrodyDentinger
{   

    // Custom Deck inherits Deck
    internal class CustomDeck : Deck
    {

        // Methods

        // Add Card
        public Card AddCustomCard(string suit, string rank)
        {   
            // Create a new instance of the class Card with the given suit and rank
            Card newCard = new Card(suit, rank);

            return newCard;

        }


    }
}
