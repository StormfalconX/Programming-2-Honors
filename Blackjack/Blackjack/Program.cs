﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blackjack
{
    class Program
    {
        static string[,] DeckOfCards = new string[,]
        {{"Two of Diamonds", "2"}, {"Three of Diamonds", "3"}, {"Four of Diamonds", "4"},
        {"Five of Diamonds", "5"}, {"Six of Diamonds", "6"}, {"Seven of Diamonds", "7"},
        {"Eight of Diamonds", "8"}, {"Nine of Diamonds", "9"}, {"Ten of Diamonds", "10"},
        {"Jack of Diamonds", "10"}, {"Queen of Diamonds", "11"}, {"King of Diamonds", "10"},
        {"Ace of Diamonds", "11"},

        {"Two of Hearts", "2"}, {"Three of Hearts", "3"}, {"Four of Hearts", "4"},
        {"Five of Hearts", "5"}, {"Six of Hearts", "6"}, {"Seven of Hearts", "7"},
        {"Eight of Hearts", "8"}, {"Nine of Hearts", "9"}, {"Ten of Hearts", "10"},
        {"Jack of Hearts", "10"}, {"Queen of Hearts", "11"}, {"King of Hearts", "10"},
        {"Ace of Hearts", "11"},

        {"Two of Spades", "2"}, {"Three of Spades", "3"}, {"Four of Spades", "4"},
        {"Five of Spades", "5"}, {"Six of Spades", "6"}, {"Seven of Spades", "7"},
        {"Eight of Spades", "8"}, {"Nine of Spades", "9"}, {"Ten of Spades", "10"},
        {"Jack of Spades", "10"}, {"Queen of Spades", "11"}, {"King of Spades", "10"},
        {"Ace of Spades", "11"},

        {"Two of Clubs", "2"}, {"Three of Clubs", "3"}, {"Four of Clubs", "4"},
        {"Five of Clubs", "5"}, {"Six of Clubs", "6"}, {"Seven of Clubs", "7"},
        {"Eight of Clubs", "8"}, {"Nine of Clubs", "9"}, {"Ten of Clubs", "10"},
        {"Jack of Clubs", "10"}, {"Queen of Clubs", "11"}, {"King of Clubs", "10"},
        {"Ace of Clubs", "11"}};

        static string[,] ShuffledDeck = new string[52, 2];
        static bool[] CardsPicked = new bool[52];

        static string nameInput = Microsoft.VisualBasic.Interaction.InputBox("Enter your name", "Name Input");

        static int intCardNumber = 0;

        static void Main(string[] args)
        {
            Shuffle();

        }



        public static void Shuffle()
        {
            Random rNum = new Random();
            int intCard = 0;

            for (int i = 0; i < 52; i++)
            {
                do
                {
                    intCard = rNum.Next(0, 52);
                } while (CardsPicked[intCard] == true);

                CardsPicked[intCard] = true;
                ShuffledDeck[i, 0] = DeckOfCards[intCard, 0];
                ShuffledDeck[i, 1] = DeckOfCards[intCard, 1];
            }//for      
        }//Shuffle

        public static void Deal()
        {
            if (intCardNumber < 40)
            {

            }
            else
            {

            }
        }

    }
}