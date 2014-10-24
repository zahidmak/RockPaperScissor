//GROUP : 6
//GROUP MEMBERS: William Wiltshire, Kirsti Tench, Zahidali Maknojia, Krishna Bhandari, Aleksander Mukhin
//ASSIGNMENT# 6
//Description: A paper rock scissors game
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public class RockPaperScissor : INotifyPropertyChanged
    {
        //Cont
        const int MAX = 4;
        const int MIN = 1;
        
        //private attributes
        private int computerWinsCount;
        private int humanWinsCount;
        private int tiesCount;
        private int humanChoice;
        private int computerChoice;
        private string computerImageUrl;
        private string humanImageUrl;
        private string computerLabel;
        private string humanLabel;

        public int ComputerWinsCount { get { return computerWinsCount; } set { computerWinsCount = value; NotifyPropertyChanged(); } }
        public int HumanWinsCount { get { return humanWinsCount; } set { humanWinsCount = value; NotifyPropertyChanged(); } }
        public int TiesCount { get { return tiesCount; } set { tiesCount = value; NotifyPropertyChanged(); } }
        public int HumanChoice { get { return humanChoice; } set { humanChoice = value; this.HumanImageUrl = String.Format("/Images/H{0}.jpg", value); NotifyPropertyChanged(); } }
        public int ComputerChoice { get { return computerChoice; } set { computerChoice = value; this.ComputerImageUrl = String.Format("/Images/C{0}.jpg", value); NotifyPropertyChanged(); } }
        public string ComputerImageUrl { get { return computerImageUrl; } set { computerImageUrl = value; NotifyPropertyChanged(); } }
        public string HumanImageUrl { get { return humanImageUrl; } set { humanImageUrl = value; NotifyPropertyChanged(); } }
        public string ComputerLabel { get { return computerLabel; } set { computerLabel = value; NotifyPropertyChanged(); } }
        public string HumanLabel { get { return humanLabel; } set { humanLabel = value; NotifyPropertyChanged(); } }

        public void CChoose()
        {
            Random random = new Random();
            this.ComputerChoice = random.Next(MIN, MAX);
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public RockPaperScissor()
        {
            this.ComputerWinsCount = 0;
            this.HumanWinsCount = 0;
            this.TiesCount = 0;
            this.ComputerChoice = 0;
            this.HumanChoice = 0;
        }

        /// <summary>
        /// Chooses the winner between computer and human
        /// </summary>
        public void ChooseWinner()
        {
            this.HumanLabel = null;
            this.ComputerLabel = null;
            if(HumanChoice==1 && ComputerChoice==1)
            {
                //Tie
                this.TiesCount += 1;
                this.HumanLabel = "TIE!";
                this.ComputerLabel = "TIE!";

            }
            else if (HumanChoice == 1 && ComputerChoice == 2)
            {
                //Computer won
                this.ComputerWinsCount += 1;
                this.ComputerLabel = "WIN!";
            }
            else if (HumanChoice == 1 && ComputerChoice == 3)
            {
                //Human won
                this.HumanWinsCount += 1;
                this.HumanLabel = "WIN!";
            }
            else if (HumanChoice == 2 && ComputerChoice == 1)
            {
                //Human won
                this.HumanWinsCount += 1;
                this.HumanLabel = "WIN!";
            }
            else if (HumanChoice == 2 && ComputerChoice == 2)
            {
                //Tie
                this.TiesCount += 1;
                this.HumanLabel = "TIE!";
                this.ComputerLabel = "TIE!";
            }
            else if (HumanChoice == 2 && ComputerChoice == 3)
            {
                //Computer won
                this.ComputerWinsCount += 1;
                this.ComputerLabel = "WIN!";
            }
            else if (HumanChoice == 3 && ComputerChoice == 1)
            {
                //Computer won
                this.ComputerWinsCount += 1;
                this.ComputerLabel = "WIN!";
            }
            else if (HumanChoice == 3 && ComputerChoice == 2)
            {
                //Human won
                this.HumanWinsCount += 1;
                this.HumanLabel = "WIN!";
            }
            else if (HumanChoice ==3 && ComputerChoice == 3)
            {
                //Tie
                this.TiesCount += 1;
                this.HumanLabel = "TIE!";
                this.ComputerLabel = "TIE!";
            }

            
        }

        #region INotifyPropertyChanged Members

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}
