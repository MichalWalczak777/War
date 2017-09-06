using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War
{
    public class Card
    {
        public Colour colour;
        public Figure figure;

        public Card(Colour colour, Figure figure)
        {
            this.figure = figure;
            this.colour = colour;
        }
    }
}
