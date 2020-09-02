namespace MemoryGame
{
    class Card
    {
        #region Properties

        public string Letter { get; set; }
        public string Number { get; set; }
        public bool  Guessed { get; set; }

        #endregion

        #region Constructors

        public Card()
        {

        }
        public Card(string letter)
        {
            Letter = letter;
        }

        #endregion
    }
}
