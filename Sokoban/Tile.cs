using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Tile
    {
        public Tile()
        {

        }
      
        public Crate Chest
        {
            get => default(Crate);
            set
            {
            }
        }
        public Boolean HasCrate
        {
            get => default(Boolean);
            set
            {
            }
        }

        public Boolean HasPlayer
        {
            get => default(Boolean);
            set
            {
            }
        }
    }
}