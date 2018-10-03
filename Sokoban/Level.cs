using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Level
    {
        public Tile Tegel
        {
            get => default(Tile);
            set
            {
            }
        }

        public int Completed
        {
            get => default(int);
            set
            {
            }
        }

        public void Load()
        {
            throw new System.NotImplementedException();
        }

        public void Save()
        {
            throw new System.NotImplementedException();
        }

        public void CheckFieldState()
        {
            throw new System.NotImplementedException();
        }
    }
}