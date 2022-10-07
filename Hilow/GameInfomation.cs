namespace cse210
{
    public class GameInformation
    {
        // Variables storing game info
        private int[] _cards;
        private int _cardIndex;
        private int _nextCard;
        private int _score;
        private Random _random;

        public GameInformation()
        {
            _cards = new int[12];
            _cardIndex = 0;
            _random = new Random();
            _score = 300;
            
            // Setup each card
            for (int i = 0; i < _cards.Length; i++)
            {
                // instead of starting at 0 ending at 11...
                // start at 1 end at 12. (which is why '= i + 1')
                _cards[i] = i + 1;
            }
            // Set card index to refer to a random place in our card list
            _cardIndex = _random.Next(0, 12);
            _nextCard = _random.Next(0, 12);

        }

        /// <summary>
        /// Returns currently selected card
        /// </summary>
        /// <returns>int</returns>
        public int GetCurrentCard()
        {
            return _cards[_cardIndex];
        }

        /// <summary>
        /// Returns next card in queue
        /// </summary>
        /// <returns>int</returns>
        public int GetNextCard()
        {
            return _cards[_nextCard];
        }

        /// <summary>
        /// Selects next card in queue
        /// </summary>
        public void SetNextCard()
        {
            _cardIndex = _nextCard;
            _nextCard = _random.Next(0, 12);
        }

        /// <summary>
        /// Gets the current score
        /// </summary>
        /// <returns>int</returns>
        public int GetScore()
        {
            return _score;
        }

        /// <summary>
        /// Sets score relative to current score
        /// </summary>
        /// <param name="value"></param>
        public void SetScore(int value)
        {
            _score += value;
        }

        /// <summary>
        /// Checks if next card is higher than current card.
        /// Returns true if current card is higher.
        /// </summary>
        /// <returns></returns>
        public bool CheckScore()
        {
            return GetCurrentCard() > GetNextCard();
        }
    }
}
