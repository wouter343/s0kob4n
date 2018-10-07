using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sokoban
{
    public class Player
    {
        private Level level;
        private GameView gameView;
        private Tile[,] field;
        private Tile CurrentTile { get; set; }
        private int CurXpos;
        private int CurYpos;


        public Player(Level level)
        {
            this.level = level;
            field = level.field;

            for (int x = 0; x < field.GetLength(0); x++)
            {

                for (int y = 0; y < field.GetLength(1); y++)
                {
                    if(field[x,y].HasPlayer)
                    {
                        CurXpos = x;
                        CurYpos = y;
                    }
                }
            }
        }

        
        public void _moveUp()
        {
            if (!(field[CurXpos - 1, CurYpos].GetType() == typeof(Wall) || field[CurXpos, CurYpos].HasCrate)) {
                field[CurXpos, CurYpos].HasPlayer = false;
                CurXpos--;
                field[CurXpos, CurYpos].HasPlayer = true;
            }
        }

        public void _moveDown()
        {
            if (!(field[CurXpos + 1, CurYpos].GetType() == typeof(Wall) || field[CurXpos + 1, CurYpos].HasCrate))
            {
                field[CurXpos, CurYpos].HasPlayer = false;
                CurXpos++;
                field[CurXpos, CurYpos].HasPlayer = true;
            }
        }

        public void _moveRight()
        {
            if (!(field[CurXpos, CurYpos + 1].GetType() == typeof(Wall) || field[CurXpos, CurYpos + 1].HasCrate))
            {
                field[CurXpos, CurYpos].HasPlayer = false;
                CurYpos++;
                field[CurXpos, CurYpos].HasPlayer = true;
            }
        }

        public void _moveLeft()
        {
            if (!(field[CurXpos, CurYpos - 1].GetType() == typeof(Wall) || field[CurXpos, CurYpos - 1].HasCrate))
            {
                field[CurXpos, CurYpos].HasPlayer = false;
                CurYpos--;
                field[CurXpos, CurYpos].HasPlayer = true;
            }
        }

        public void _checkMove()
        {
            throw new System.NotImplementedException();
        }
    }
}