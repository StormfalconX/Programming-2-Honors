using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blackjack
{
    class Player
    {
        public string[] Cards { get; set; }
        public int[] CardValues { get; set; }
        public int CardsInHand { get; set; }
        public string Name { get; set; }
        public bool Turn { get; set; }
        public bool Busted { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Ties { get; set; }

        public Player()
        {
            Cards = new string[5];
            CardValues = new int[5];
            CardsInHand = 0;
            Name = "Dealer";
            Turn = true;
            Busted = false;
            Wins = 0;
            Losses = 0;
            Ties = 0;
        }

        public Player(string nameInput)
        {
            Cards = new string[5];
            CardValues = new int[5];
            CardsInHand = 0;
            Name = nameInput;
            Turn = true;
            Busted = false;
            Wins = 0;
            Losses = 0;
            Ties = 0;
        }

        public int HandTotal()
        {
            int total = 0;

            for (int i = 0; i < 5; i++)
            {
                total += CardValues[i];
            }

            return total;
        }
    }//Player class
}//namespace
