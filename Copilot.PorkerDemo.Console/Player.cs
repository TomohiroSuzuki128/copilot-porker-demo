using static PokerHandEvaluator;

class Player
{
    private List<Card> hand;

    public List<Card> Hand
    {
        get { return hand; }
    }

    //手札の役を取得するため、HandRanking プロパティを作成する
    public HandRank HandRank
    {
        get
        {
            Card[] handArray = hand.ToArray();
            return PokerHandEvaluator.EvaluateHand(handArray);
        }
    }

    public Player()
    {
        hand = new List<Card>();
    }

    public void AddCard(Card card)
    {
        hand.Add(card);
    }

    public void ShowHand()
    {
        string handOutput = string.Join(" | ", hand.Select(card => card.ToString()));
        Console.WriteLine(handOutput);
    }

    //保持する手札を決めるため、カンマ区切りで受け取った文字列を分解し、IsHeld を true にする。メソッド名は HoldCards
    public void HoldCards(string input)
    {
        // input が null の場合は return する
        if (input == null)
        {
            return;
        }
        string[] inputArray = input.Split(',');
        foreach (string inputNumber in inputArray)
        {
            int number = int.Parse(inputNumber);
            hand[number - 1].IsHeld = true;
        }
    }

}




