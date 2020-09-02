using System.Windows;

namespace MemoryGame
{
    /// <summary>
    /// Interaction logic for GameView.xaml
    /// </summary>
    public partial class GameView : Window
    {
        public GameView()
        {
            InitializeComponent();
            this.DataContext = new GameViewModel(this);
        }
    }
}
