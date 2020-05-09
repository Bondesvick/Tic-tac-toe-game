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
using System.Windows.Shapes;

namespace WpfTicTacToe
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
        }

        private void TwoPlayers_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mWindow = new MainWindow();
            mWindow.ShowDialog();
        }

        private void OnePlayer_Click(object sender, RoutedEventArgs e)
        {
            OnePlayer OnePlayerWindow = new OnePlayer();
            OnePlayerWindow.ShowDialog();
        }
    }
}
