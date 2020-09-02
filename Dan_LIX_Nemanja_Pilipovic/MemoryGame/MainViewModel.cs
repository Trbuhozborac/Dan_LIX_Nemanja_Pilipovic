using System.Windows.Input;

namespace MemoryGame
{
    class MainViewModel : BaseViewModel
    {
        #region Objects

        MainWindow main;

        #endregion

        #region Constructors

        public MainViewModel(MainWindow mainOpen)
        {
            main = mainOpen;
        }

        #endregion

        #region Properties



        #endregion

        #region Commands

        private ICommand startGame;
        public ICommand StartGame
        {
            get
            {
                if (startGame == null)
                {
                    startGame = new RelayCommand(param => StartGameExecute(), param => CanStartGameExecute());
                }
                return startGame;
            }
        }

        #endregion

        #region Functions

        private void StartGameExecute()
        {
            GameView view = new GameView();
            view.ShowDialog();
        }

        private bool CanStartGameExecute()
        {
            return true;
        }

        #endregion
    }
}
