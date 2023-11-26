public class Card
{

    public Card(Suit suit, int value)
    {
        Suit = suit;
        Value = value;
    }

    public Suit Suit { get; set; }
    public int Value { get; set; }

    //保持するカードかどうか
    public bool IsHeld { get; set; }


    public override string ToString()
    {
        string suitSymbol = "";
        switch (Suit)
        {
            case Suit.Spades:
                suitSymbol = "♠";
                break;
            case Suit.Hearts:
                suitSymbol = "♥";
                break;
            case Suit.Diamonds:
                suitSymbol = "♦";
                break;
            case Suit.Clubs:
                suitSymbol = "♣";
                break;
        }

        string valueString = "";
        if (Value >= 2 && Value <= 10)
        {
            valueString = Value.ToString();
        }
        else
        {
            switch (Value)
            {
                case 1:
                    valueString = "A";
                    break;
                case 11:
                    valueString = "J";
                    break;
                case 12:
                    valueString = "Q";
                    break;
                case 13:
                    valueString = "K";
                    break;
            }
        }

        return suitSymbol + valueString;
    }

}

public enum Suit
{
    Spades,
    Hearts,
    Diamonds,
    Clubs
}
