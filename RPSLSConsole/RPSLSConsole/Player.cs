using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPSLSConsole
{
    class Player
    {
        private int wins;
        private int losses;
        private int ties;
        private int selectRock;
        private int selectPaper;
        private int selectScissors;
        private int selectLizard;
        private int selectSpock;

        public int Wins
        {
            get { return wins; }
            set { wins = value; }
        }

        public int Losses
        {
            get { return losses; }
            set { losses = value; }
        }

        public int Ties
        {
            get { return ties; }
            set { ties = value; }
        }

        public int Rock
        {
            get { return selectRock; }
            set { selectRock = value; }
        }

        public int Paper
        {
            get { return selectPaper; }
            set { selectPaper = value; }
        }

        public int Scissors
        {
            get { return selectScissors; }
            set { selectScissors = value; }
        }

        public int Lizard
        {
            get { return selectLizard; }
            set { selectLizard = value; }
        }

        public int Spock
        {
            get { return selectSpock; }
            set { selectSpock = value; }
        }

        public string ShowStats()
        {
            return "Player Stats: " + wins.ToString() + " wins; " + losses.ToString() + " losses; " + ties.ToString() + " ties;\n# times selected Rock: " + selectRock.ToString() + ";\n# times selected Paper: " + selectPaper.ToString() + ";\n# times selected Scissor: " + selectScissors.ToString() +";\n# times selected Lizard: " + selectLizard.ToString() + ";\n# times selected Spock: " + selectSpock.ToString();
        }

    }
}
