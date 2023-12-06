/*
 Name: Brody Dentinger
 File: Card.cs
 Description: This class file is used to create new cards.
 Date: November 13, 2023
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COSC2100Assignment4BrodyDentinger
{
    internal class Card
    {
        // Properties 
        internal string suit;
        internal string rank;

        // Parameterized Constructor
        public Card(string suit, string rank)
        {
            this.suit = suit;
            this.rank = rank;
        }

        // Methods

        // Overriding the ToString() method to print the suit and rank of a given card object
        public override string ToString()
        {
            return $"{this.rank} of {this.suit}";
        }
    }
}
