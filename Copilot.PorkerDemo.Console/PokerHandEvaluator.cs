public class PokerHandEvaluator
{
    public enum HandRank
    {
        None,
        HighCard,
        OnePair,
        TwoPair,
        ThreeOfAKind,
        Straight,
        Flush,
        FullHouse,
        FourOfAKind,
        StraightFlush,
        RoyalStraightFlush
    }

    public static HandRank EvaluateHand(Card[] hand)
    {
        if (IsRoyalStraightFlush(hand))
        {
            return HandRank.RoyalStraightFlush;
        }
        else if (IsStraightFlush(hand))
        {
            return HandRank.StraightFlush;
        }
        else if (IsFourOfAKind(hand))
        {
            return HandRank.FourOfAKind;
        }
        else if (IsFullHouse(hand))
        {
            return HandRank.FullHouse;
        }
        else if (IsFlush(hand))
        {
            return HandRank.Flush;
        }
        else if (IsStraight(hand))
        {
            return HandRank.Straight;
        }
        else if (IsThreeOfAKind(hand))
        {
            return HandRank.ThreeOfAKind;
        }
        else if (IsTwoPair(hand))
        {
            return HandRank.TwoPair;
        }
        else if (IsOnePair(hand))
        {
            return HandRank.OnePair;
        }
        else
        {
            return HandRank.None;
        }
    }

    public static bool IsRoyalStraightFlush(Card[] hand)
    {
        return IsStraightFlush(hand) && hand[0].Value == 1 && hand[4].Value == 13;
    }

    public static bool IsStraightFlush(Card[] hand)
    {
        return IsStraight(hand) && IsFlush(hand);
    }

    public static bool IsFourOfAKind(Card[] hand)
    {
        return hand[0].Value == hand[3].Value || hand[1].Value == hand[4].Value;
    }

    public static bool IsFullHouse(Card[] hand)
    {
        return (hand[0].Value == hand[2].Value && hand[3].Value == hand[4].Value) ||
               (hand[0].Value == hand[1].Value && hand[2].Value == hand[4].Value);
    }

    public static bool IsFlush(Card[] hand)
    {
        return hand[0].Suit == hand[1].Suit &&
               hand[1].Suit == hand[2].Suit &&
               hand[2].Suit == hand[3].Suit &&
               hand[3].Suit == hand[4].Suit;
    }

    public static bool IsStraight(Card[] hand)
    {
        return hand[0].Value + 1 == hand[1].Value &&
               hand[1].Value + 1 == hand[2].Value &&
               hand[2].Value + 1 == hand[3].Value &&
               hand[3].Value + 1 == hand[4].Value;
    }

    public static bool IsThreeOfAKind(Card[] hand)
    {
        Array.Sort(hand, (x, y) => x.Value.CompareTo(y.Value));
        int count = 0;
        for (int i = 0; i < hand.Length - 2; i++)
        {
            if (hand[i].Value == hand[i + 1].Value && hand[i + 1].Value == hand[i + 2].Value)
            {
                count++;
            }
        }
        return count == 1;
    }

    public static bool IsTwoPair(Card[] hand)
    {
        return (hand[0].Value == hand[1].Value && hand[2].Value == hand[3].Value) ||
               (hand[0].Value == hand[1].Value && hand[3].Value == hand[4].Value) ||
               (hand[1].Value == hand[2].Value && hand[3].Value == hand[4].Value);
    }

    public static bool IsOnePair(Card[] hand)
    {
        return hand[0].Value == hand[1].Value ||
               hand[1].Value == hand[2].Value ||
               hand[2].Value == hand[3].Value ||
               hand[3].Value == hand[4].Value;
    }

}
