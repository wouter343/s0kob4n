using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Level
    {
        public Tile[,] field {get; set;}
        private String[,] testveld = new String[2,8];

        public Level()
        {
            field = new Tile[2,8];

            testveld[0,0] = "#";
            testveld[0,1] = "#";
            testveld[0,2] = "#";
            testveld[0,3] = "#";
            testveld[0,4] = "#";
            testveld[0,5] = "#";
            testveld[0,6] = "#";
            testveld[0,7] = "#";
            testveld[1,0] = "#";
            testveld[1,1] = ".";
            testveld[1,2] = ".";
            testveld[1,3] = ".";
            testveld[1,4] = ".";
            testveld[1,5] = ".";
            testveld[1,6] = ".";
            testveld[1,7] = "#";

            createField(testveld);
        }

        public Tile tile
        {
            get => default(Tile);
            set
            {
            }
        }

        public Boolean Completed
        {
            get => default(Boolean);
            set
            {
            }
        }

        private void createField(String[,] stringfield)
        {
            for(int x =0; x < stringfield.GetLength(0); x++){
            
                for(int y = 0; y < stringfield.GetLength(1); y++) {
                    if(stringfield[x,y].Equals("#")){
                         field[x,y] = new Wall();
                    } else if(stringfield[x,y].Equals(".")){
                         field[x,y] = new Tile();
                    } else if(stringfield[x,y].Equals("x")){
                         field[x,y] = new Destination();
                    }
                }
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