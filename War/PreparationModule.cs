using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War
{
    public class PreparationModule
    {

        private List<Card> deck;


        public List<Card> PrepareDeckToPlay()
        {
            deck = new List<Card>();
            CreateADeck(deck);
            ShuffleTheDeck(deck);
            return deck;
        }



        public void CreateADeck(List <Card> deck)
        {

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    deck.Add(new Card((Colour)i, (Figure)j));
                }
            }
        }



        private void ShuffleTheDeck(List <Card> deck)
        {
            List<Card> shuffledDeck = new List<Card>();
            Random randomIndexGenerator = new Random();

            while (deck.Count() != 0)
            {
                int maximumCardIndex = deck.Count();
                int currentCardIndex = randomIndexGenerator.Next(maximumCardIndex);

                shuffledDeck.Add(deck.ElementAt(currentCardIndex));
                deck.RemoveAt(currentCardIndex);
            }

            foreach (Card card in shuffledDeck)
            {
                deck.Add(card);
            }

        }
    }
}
