using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War
{
    public class GameEngine
    {

        private List<Card> mainDeck;
        private PreparationModule preparationModule;
        private PlayingModule playingModule;

        public void StartNewGame()
        {
            preparationModule = new PreparationModule();
            mainDeck = preparationModule.PrepareDeckToPlay();

            playingModule = new PlayingModule();
            playingModule.DealTheCards(mainDeck);
            playingModule.Play();
        }


    }


    }

