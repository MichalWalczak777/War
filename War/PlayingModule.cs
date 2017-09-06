using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War
{
    public class PlayingModule
    {
        private List<Card> mainDeck;
        private List<Card> fightingCards;
        private Player playerOne;
        private Player playerTwo;
        private DataDisplayingDevice displayingDevice;

        public void DealTheCards(List<Card> cardsToDeal)
        {
            mainDeck = new List<Card>();
            FillTheDeck(cardsToDeal);
            playerOne = new Player();
            playerTwo = new Player();

            bool isCardforPlayerOne = true;

            foreach (Card card in mainDeck)
            {
                switch (isCardforPlayerOne)
                {
                    case true:
                        playerOne.deck.Add(card);
                        isCardforPlayerOne = false;
                        break;

                    case false:
                        playerTwo.deck.Add(card);
                        isCardforPlayerOne = true;
                        break;
                }
            }
        }

        private void FillTheDeck(List <Card> cardsToDeal)
        {
            foreach (Card card in cardsToDeal)
            {
                mainDeck.Add(card);
            }
        }


        public void Play()
        {
            fightingCards = new List<Card>();
            displayingDevice = new DataDisplayingDevice();

            while (playerOne.deck.Count() != 0 && playerTwo.deck.Count() != 0)
            {
                displayingDevice.DisplayGameData(playerOne.deck.Count(), playerOne.deck.ElementAt(0),
                                                 playerTwo.deck.Count(), playerTwo.deck.ElementAt(0));

                Clash(playerOne.deck.ElementAt(0), playerTwo.deck.ElementAt(0));
            }
        }

        private void Clash(Card cardOfPlayerOne, Card cardOfPlayerTwo)
        {

            fightingCards.Add(cardOfPlayerOne);
            playerOne.deck.Remove(cardOfPlayerOne);

            fightingCards.Add(cardOfPlayerTwo);
            playerTwo.deck.Remove(cardOfPlayerTwo);

            if (cardOfPlayerOne.figure > cardOfPlayerTwo.figure)
            {
                SendCardsToPlayersDeck(playerOne, fightingCards);
            }
            else if (cardOfPlayerOne.figure < cardOfPlayerTwo.figure)
            {
                SendCardsToPlayersDeck(playerTwo, fightingCards);
            }
        }

        private void SendCardsToPlayersDeck(Player player, List<Card> cards)
        {
            foreach (Card card in cards)
            {
                player.deck.Add(card);
            }
            cards.RemoveRange(0, cards.Count());
        }
    }
}
