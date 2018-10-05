using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class GameView
    {
        

        public GameView()
        {
            
        }

        public void PrintField(Tile[,] level)
        {
            
            for (int x = 0; x < level.GetLength(0) ; x++){
               
                for(int y = 0; y < level.GetLength(1); y++){
                    PrintTile(level[x,y]);
                    }
                Console.WriteLine();
            }
           Console.ReadLine();
        }

        private void PrintTile(Tile tile)
        {
            if(tile.HasCrate){
                Console.Write("o");
                }
            else if(tile.HasPlayer){
                Console.Write("@");
                }
            else if(tile.GetType() == typeof(Wall)) {
                Console.Write("#");
            } else if(tile.GetType() == typeof(Trap)){
               Console.Write("bla"); 
             } else {
                Console.Write(".");
                }
        }
    }
}