using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class GameController
    {
        private Player player;
        private Level level;
        private GameView gameview;

        public GameController()
        {
            level = new Level();
            level.Load();

            gameview = new GameView();

            player = new Player(level);
            
        }


        public int Colleague { get; set; }

        public void TriggerColleague()
        {
            throw new System.NotImplementedException();
        }

        public void Play()
        {
            ConsoleKeyInfo keyinfo;
            gameview.PrintField(level.field);

            keyinfo = Console.ReadKey(true);
            while (keyinfo.Key != ConsoleKey.S)
            {
                Console.WriteLine(keyinfo.Key);
                if(keyinfo.Key == ConsoleKey.DownArrow)
                {
                    player._moveDown();
                    Console.WriteLine("move up!");
                } else if(keyinfo.Key == ConsoleKey.UpArrow)
                {
                    player._moveUp();
                } else if(keyinfo.Key == ConsoleKey.LeftArrow)
                {
                    player._moveLeft();
                } else if(keyinfo.Key == ConsoleKey.RightArrow)
                {
                    player._moveRight();
                }
                Console.Clear();
                gameview.PrintField(level.field);

                keyinfo = Console.ReadKey(true);
               if(!level.CheckFieldState()){
                    break; 
                }

            }
            Console.WriteLine("game over");


        }

        public void Reset()
        {
            throw new System.NotImplementedException();
        }

        public void Quit()
        {
            throw new System.NotImplementedException();
        }
    }
}