using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Tile
    {
        public int Position
        {
            get => default(int);
            set
            {
            }
        }

        public Crate Kist
        {
            get => default(Crate);
            set
            {
            }
        }

        public int HasCrate
        {
            get => default(int);
            set
            {
            }
        }

        public Tile HasPlayer
        {
            get => default(Tile);
            set
            {
            }
        }

        public Tile down
        {
            get => default(Tile);
            set
            {
            }
        }

        public Tile up
        {
            get => default(Tile);
            set
            {
            }
        }

        public Tile left
        {
            get => default(Tile);
            set
            {
            }
        }

        public Tile right
        {
            get => default(Tile);
            set
            {
            }
        }
    }
}