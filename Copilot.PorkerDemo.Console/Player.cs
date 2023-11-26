using static PokerHandEvaluator;

class Player
{
    private List<Card> hand;

    public List<Card> Hand
    {
        get { return hand; }
    }

    //��D�̖����擾���邽�߁AHandRanking �v���p�e�B���쐬����
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

    //�ێ������D�����߂邽�߁A�J���}��؂�Ŏ󂯎����������𕪉����AIsHeld �� true �ɂ���B���\�b�h���� HoldCards
    public void HoldCards(string input)
    {
        // input �� null �̏ꍇ�� return ����
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




