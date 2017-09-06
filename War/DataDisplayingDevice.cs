using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace War
{
    public class DataDisplayingDevice
    {
        public void DisplayGameData(int numberOfCardsInFirstPlayersDeck, Card firstPlayersCard,
                             int numberOfCardsInSecondPlayersDeck, Card secondPlayersCard)
        {
            Console.WriteLine("Number of cards in the deck of Player 1: " + numberOfCardsInFirstPlayersDeck);
            Console.WriteLine("Card currently played by Player 1: " + firstPlayersCard.figure.ToString() 
                                                         + " of " + firstPlayersCard.colour.ToString());
            Console.WriteLine("Number of cards in the deck of Player 2: " + numberOfCardsInSecondPlayersDeck);
            Console.WriteLine("Card currently played by Player 2: " + secondPlayersCard.figure.ToString()
                                                         + " of " + secondPlayersCard.colour.ToString());
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
