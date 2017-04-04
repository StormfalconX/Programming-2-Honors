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
    }
}
