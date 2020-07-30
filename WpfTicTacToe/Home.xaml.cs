using System.Windows;

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