class deck {
    List<int> cardDeck = new List<int>();
    
    public deck(){
        // Creates a list to represent our deck
        // Numbers 1-13 4 times for each suit 
        for (int x = 1; x<=4; x++) {
            for (int i = 1; i<13; i++) {
                cardDeck.Add(i);
            }
        }
}
    
    public void removeCard(int card){
        // Remove the selected card from deckList
        int index = cardDeck.FindIndex(x => x==5);
        cardDeck.RemoveAt(index);
    }

    public int drawRandom() {
        // Selects a random card from the deck
        Random rnd = new Random();
        int num  = rnd.Next(cardDeck.Count);
        int randomCard = cardDeck[num-1];
        return randomCard;
    }
}
