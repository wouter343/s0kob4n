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
      
        public Crate Kist
        {
            get => default(Crate);
            set
            {
            }
        }

<<<<<<< HEAD
        public Boolean HasCrate
        {
            get => default(Boolean);
=======
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
>>>>>>> 8fa2859936765b3602ba013e30a327e86ee85e17
            set
            {
            }
        }

<<<<<<< HEAD
        public Boolean HasPlayer
        {
            get => default(Boolean);
=======
        public Tile left
        {
            get => default(Tile);
>>>>>>> 8fa2859936765b3602ba013e30a327e86ee85e17
            set
            {
            }
        }

<<<<<<< HEAD
=======
        public Tile right
        {
            get => default(Tile);
            set
            {
            }
        }
>>>>>>> 8fa2859936765b3602ba013e30a327e86ee85e17
    }
}