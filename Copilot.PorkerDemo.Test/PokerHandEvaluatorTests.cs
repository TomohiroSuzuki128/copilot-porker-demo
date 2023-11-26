namespace Copilot.PorkerDemo.Console.Tests
{
    public class PokerHandEvaluatorTests
    {
        [Fact]
        public void IsThreeOfAKind_ReturnsTrue_WhenHandContainsThreeOfAKind()
        {
            // Arrange
            Card[] hand = new Card[]
            {
                new Card(Suit.Clubs, 2),
                new Card(Suit.Diamonds, 3),
                new Card(Suit.Hearts, 2),
                new Card(Suit.Spades, 5),
                new Card(Suit.Clubs, 2)
            };

            // Act
            bool result = PokerHandEvaluator.IsThreeOfAKind(hand);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsFullHouse_ReturnsTrue_WhenHandIsFullHouse()
        {
            // Arrange
            var hand = new Card[]
            {
                new Card(Suit.Clubs, 2),
                new Card(Suit.Diamonds, 3),
                new Card(Suit.Hearts, 2),
                new Card(Suit.Spades, 3),
                new Card(Suit.Clubs, 3)
            };

            // Act
            var result = PokerHandEvaluator.IsFullHouse(hand);

            // Assert
            Assert.True(result);
        }

        // Additional test cases
        [Fact]
        public void IsThreeOfAKind_ReturnsFalse_WhenHandDoesNotContainThreeOfAKind()
        {
            // Arrange
            var hand = new Card[]
            {
                new Card(Suit.Clubs, 2),
                new Card(Suit.Diamonds, 3),
                new Card(Suit.Hearts, 4),
                new Card(Suit.Spades, 5),
                new Card(Suit.Clubs, 6)
            };

            // Act
            var result = PokerHandEvaluator.IsThreeOfAKind(hand);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsFullHouse_ReturnsFalse_WhenHandIsNotFullHouse()
        {
            // Arrange
            var hand = new Card[]
            {
                new Card(Suit.Clubs, 2),
                new Card(Suit.Diamonds, 3),
                new Card(Suit.Hearts, 4),
                new Card(Suit.Spades, 5),
                new Card(Suit.Clubs, 6)
            };

            // Act
            var result = PokerHandEvaluator.IsFullHouse(hand);

            // Assert
            Assert.False(result);
        }
    }
}
