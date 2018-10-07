using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Sokoban
{
    public class Level
    {
        public Tile[,] field {get; set;}
        private String[,] testveld = new String[2,8];
       

        public Level()
        {
            
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
            field = new Tile[stringfield.GetLength(0),stringfield.GetLength(1)];
            for(int x =0; x < stringfield.GetLength(0); x++)
            {
                for(int y = 0; y < stringfield.GetLength(1); y++) 
                {
                    if(stringfield[x,y].Equals("#"))
                    {
                         field[x,y] = new Wall();
                    } else if(stringfield[x,y].Equals(".")){
                         field[x,y] = new Tile();
                    } else if(stringfield[x,y].Equals("x")){
                         field[x,y] = new Destination();
                    } else if(stringfield[x,y].Equals("o")){
                        field[x, y] = new Tile() { HasCrate = true };
                    } else if(stringfield[x,y].Equals("@")){
                        field[x, y] = new Tile() { HasPlayer = true };
                    }
                }
             }
        }
           

        public void Load(String lvl)
        {
            string[] lines;
            var list = new List<string>();

            var fileStream = new FileStream(@"C:\Users\rbnde\Source\Repos\s0kob4n\Sokoban\Saves\Level" + lvl + ".txt", FileMode.Open, FileAccess.Read);

            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
            string line;
                while ((line = streamReader.ReadLine()) != null)
                    {
                         list.Add(line);
                    }
            }
            lines = list.ToArray();
            int width = 0;
            int height = lines.Length;
            foreach(string line in lines){
                if(line.Length > width){
                    width = line.Length;       
                }
            }
           String[,] stringField = new String[height,width];
            int x = 0;
           
            foreach(string line in lines){
                int y = 0;
                foreach (char letter in line){
                  stringField[x,y] = letter.ToString(); 
                    y++;
                }
                x++;
             }
            createField(stringField);
        }

        public void Save()
        {
           String[] stringField = new String[field.GetLength(0)];
           String value;

           for (int x = 0; x < field.GetLength(0) ; x++)
           {
               
                for(int y = 0; y < field.GetLength(1); y++)
                {
                   if (field[x,y].HasCrate)
                    {
                        value = "o";
                    }
                    else if (field[x,y].HasPlayer)
                    {
                        value = "@";
                    }
                    else if (field[x,y].GetType() == typeof(Wall))
                    {
                        value = "#";
                    }
                    else if (field[x,y].GetType() == typeof(Trap))
                    {
                        value = "~";
                    }
                    else if (field[x,y].GetType() == typeof(Destination))
                    {
                        value = "x";
                    } else
                    {
                        value = ".";
                    }
                   stringField[x] += value;
                }
                System.IO.File.WriteAllLines(@"C:\Users\rbnde\Source\Repos\s0kob4n\Sokoban\Saves\test.txt", stringField);       
            }
        }
        

        public Boolean CheckFieldState()
        { 
            
            for(int x = 0; x < field.GetLength(0); x++){ 
                for(int y = 0; y < field.GetLength(1); y++){
                   if (field[x,y].GetType() == typeof(Destination) && !field[x,y].HasCrate)
                    {
                      
                        return true;
                    } 
                 }
            }
            return false;
        }
    }
}