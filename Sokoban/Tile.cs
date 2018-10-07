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
      
        public Crate Chest { get; set; }
        public Boolean HasCrate { get; set; }
                
            

        public Boolean HasPlayer { get; set; }

        public Crate Crate
        {
            get => default(Crate);
            set
            {
            }
        }
    }
}