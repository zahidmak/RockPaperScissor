//GROUP : 6
//GROUP MEMBERS: William Wiltshire, Kirsti Tench, Zahidali Maknojia, Krishna Bhandari, Aleksander Mukhin
//ASSIGNMENT# 6
//Description: A paper rock scissors game
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        RockPaperScissor RockPaperScissor = new RockPaperScissor();
        public MainWindow()
        {
            InitializeComponent();
            MainGrid.DataContext = RockPaperScissor;
        }

        private void RockButton_Click(object sender, RoutedEventArgs e)
        {
            RockPaperScissor.HumanChoice = 3;
            RockPaperScissor.CChoose();
            RockPaperScissor.ChooseWinner();
        }

        private void PaperButton_Click(object sender, RoutedEventArgs e)
        {
            RockPaperScissor.HumanChoice = 1;
            RockPaperScissor.CChoose();
            RockPaperScissor.ChooseWinner();
        }

        private void ScissorButton_Click(object sender, RoutedEventArgs e)
        {
            RockPaperScissor.HumanChoice = 2;
            RockPaperScissor.CChoose();
            RockPaperScissor.ChooseWinner();
        }

        private void Restart_Click(object sender, RoutedEventArgs e)
        {
            RockPaperScissor.ComputerWinsCount = 0;
            RockPaperScissor.TiesCount = 0;
            RockPaperScissor.HumanWinsCount = 0;
            RockPaperScissor.ComputerChoice = 0;
            RockPaperScissor.HumanChoice = 0;
        }
        
    }
}
