class deck {

    public deck(){
        // Creates a list to represent our deck
        // Numbers 1-13 4 times for each suit 
        List<int> cardDeck = new List<int>();
        for (int x = 1; x<4; x++) {
            for (int i = 1; i<13; i++) {
                cardDeck.Add(i);
            }
        }
        return cardDeck;

    }
    public removeCard(list, card){
        // Remove the selected card from deckList
        
    }

    public drawRandom(list) {
        // Selects a random card from the deck

    }


}