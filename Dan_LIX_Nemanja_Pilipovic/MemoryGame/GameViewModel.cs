using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Input;

namespace MemoryGame
{
    class GameViewModel : BaseViewModel
    {
        #region Objects

        GameView gameView;

        #endregion

        #region Constructors

        public GameViewModel(GameView gameViewOpen)
        {
            gameView = gameViewOpen;
            RandomLetters = GetRandomLetters();
            
        }

        #endregion

        #region Properties

        private static int counter = 0;

        private List<string> randomLetters;

        public List<string> RandomLetters
        {
            get { return randomLetters; }
            set 
            {
                randomLetters = value;
                OnPropertyChanged("RandomLetters");
            }
        }

        private string letter1;

        public string Letter1
        {
            get { return letter1; }
            set 
            {
                letter1 = value;
                OnPropertyChanged("Letter1");
                Card1 = new Card("A");
            }
        }


        private Card card1;

        public Card Card1
        {
            get { return card1; }
            set 
            {
                card1 = value;
                OnPropertyChanged("Card1");
            }
        }

        private Card card2;

        public Card Card2
        {
            get { return card2; }
            set
            {
                card2 = value;
                OnPropertyChanged("Card2");
            }
        }

        private Card card3;

        public Card Card3
        {
            get { return card3; }
            set
            {
                card3 = value;
                OnPropertyChanged("Card3");
            }
        }

        private Card card4;

        public Card Card4
        {
            get { return card4; }
            set
            {
                card4 = value;
                OnPropertyChanged("Card4");
            }
        }

        private Card card5;

        public Card Card5
        {
            get { return card5; }
            set
            {
                card5 = value;
                OnPropertyChanged("Card5");
            }
        }

        private Card card6;

        public Card Card6
        {
            get { return card6; }
            set
            {
                card6 = value;
                OnPropertyChanged("Card6");
            }
        }

        private Card card7;

        public Card Card7
        {
            get { return card7; }
            set
            {
                card7 = value;
                OnPropertyChanged("Card7");
            }
        }

        private Card card8;

        public Card Card8
        {
            get { return card8; }
            set
            {
                card8 = value;
                OnPropertyChanged("Card8");
            }
        }

        private Card card9;

        public Card Card9
        {
            get { return card9; }
            set
            {
                card9 = value;
                OnPropertyChanged("Card9");
            }
        }

        private Card card10;

        public Card Card10
        {
            get { return card10; }
            set
            {
                card10 = value;
                OnPropertyChanged("Card10");
            }
        }

        private Card card11;

        public Card Card11
        {
            get { return card11; }
            set
            {
                card11 = value;
                OnPropertyChanged("Card11");
            }
        }

        private Card card12;

        public Card Card12
        {
            get { return card12; }
            set
            {
                card12 = value;
                OnPropertyChanged("Card12");
            }
        }

        private Card card13;

        public Card Card13
        {
            get { return card13; }
            set
            {
                card13 = value;
                OnPropertyChanged("Card13");
            }
        }

        private Card card14;

        public Card Card14
        {
            get { return card14; }
            set
            {
                card14 = value;
                OnPropertyChanged("Card14");
            }
        }

        private Card card15;

        public Card Card15
        {
            get { return card15; }
            set
            {
                card15 = value;
                OnPropertyChanged("Card15");
            }
        }

        private Card card16;

        public Card Card16
        {
            get { return card16; }
            set
            {
                card16 = value;
                OnPropertyChanged("Card16");
            }
        }

        #endregion

        #region Commands

        private ICommand show1;
        public ICommand Show1
        {
            get
            {
                if (show1 == null)
                {
                    show1 = new RelayCommand(param => Show1Execute(), param => CanShow1Execute());
                }
                return show1;
            }
        }

        #endregion

        #region Functions

        private List<string> GetRandomLetters()
        {
            List<string> lettters = new List<string>();
            lettters.Add("A");
            lettters.Add("E");
            lettters.Add("T");
            lettters.Add("K");
            lettters.Add("J");
            lettters.Add("O");
            lettters.Add("M");
            lettters.Add("C");
            return lettters;
        }

        private List<Card> GetFirst8Cards()
        {
            List<Card> cards = new List<Card>();
            cards.Add(Card1 = new Card());
            cards.Add(Card2 = new Card());
            cards.Add(Card3 = new Card());
            cards.Add(Card4 = new Card());
            cards.Add(Card5 = new Card());
            cards.Add(Card6 = new Card());
            cards.Add(Card7 = new Card());
            cards.Add(Card8 = new Card());
            
            return cards;
        }

        private List<Card> GetSecond8Cards()
        {
            List<Card> cards = new List<Card>();
            cards.Add(Card9 = new Card());
            cards.Add(Card10 = new Card());
            cards.Add(Card11 = new Card());
            cards.Add(Card12 = new Card());
            cards.Add(Card13 = new Card());
            cards.Add(Card14 = new Card());
            cards.Add(Card15 = new Card());
            cards.Add(Card16 = new Card());

            return cards;
        }

        private void Show1Execute()
        {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                  
        }

        private bool CanShow1Execute()
        {
            return true;
        }

        #endregion
    }
}
