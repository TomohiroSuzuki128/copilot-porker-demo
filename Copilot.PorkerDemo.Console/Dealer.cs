class Dealer
{
    private List<Card> deck;
    private Random random;

    public Dealer()
    {
        deck = new List<Card>();
        random = new Random();
    }

    public void CreateDeck()
    {
        deck.Clear();
        foreach (Suit suit in Enum.GetValues(typeof(Suit)))
        {
            for (int i = 1; i <= 13; i++)
            {
                deck.Add(new Card(suit, i));
            }
        }
    }

    public void ShuffleDeck()
    {
        int n = deck.Count;
        while (n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            Card value = deck[k];
            deck[k] = deck[n];
            deck[n] = value;
        }
    }

    public void DealCards(List<Player> players, int numCards)
    {
        foreach (Player player in players)
        {
            for (int i = 0; i < numCards; i++)
            {
                Card card = deck[0];
                deck.RemoveAt(0);
                player.AddCard(card);
            }
        }
    }

    // IsHeld が false のカードをチェンジする
    public void ChangeCards(List<Player> players)
    {
        foreach (Player player in players)
        {
            for (int i = 0; i < player.Hand.Count; i++)
            {
                if (!player.Hand[i].IsHeld)
                {
                    Card card = deck[0];
                    deck.RemoveAt(0);
                    player.Hand[i] = card;
                }
            }
        }
    }


}
