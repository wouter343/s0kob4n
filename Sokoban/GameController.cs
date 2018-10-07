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

            gameview = new GameView();
        }


        public int Colleague { get; set; }

        public Level Level
        {
            get => default(Level);
            set
            {
            }
        }

        public Player Player
        {
            get => default(Player);
            set
            {
            }
        }

        public void TriggerColleague()
        {
            throw new System.NotImplementedException();
        }

        public void Play()
        {
            bool validNumber = false;
            int lvl = 0;

            while (true)
            {
                validNumber = false;
                Console.WriteLine("welcome to sokoban!");
                Console.WriteLine("kies een doolhof(1-4), druk op s om te stoppen");

                String info = "";
                while (!validNumber)
                {
                    info = Console.ReadLine();
                    if (info.Equals("s"))
                    {
                        Quit();
                    }
                    else
                    {
                        try
                        {
                            lvl = Int32.Parse(info);
                            validNumber = true;
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine("please enter a valid number");
                            validNumber = false;
                        }
                        if (validNumber && lvl > 0 && lvl <= 4)
                        {
                            level.Load(info);
                        }
                        else if (validNumber)
                        {
                            Console.WriteLine("please enter a valid number");
                        }
                    }
                }

                ConsoleKeyInfo keyinfo;
                player = new Player(level);
                gameview.PrintField(level.field);

                keyinfo = Console.ReadKey(true);
                while (keyinfo.Key != ConsoleKey.S)
                {
                    Console.WriteLine(keyinfo.Key);
                    if (keyinfo.Key == ConsoleKey.DownArrow)
                    {
                        player._moveDown();
                    }
                    else if (keyinfo.Key == ConsoleKey.UpArrow)
                    {
                        player._moveUp();
                    }
                    else if (keyinfo.Key == ConsoleKey.LeftArrow)
                    {
                        player._moveLeft();
                    }
                    else if (keyinfo.Key == ConsoleKey.RightArrow)
                    {
                        player._moveRight();
                    } else if(keyinfo.Key == ConsoleKey.R)
                    {
                        level.Load(info);
                        player = new Player(level);
                    }
                    Console.Clear();
                    gameview.PrintField(level.field);

                    keyinfo = Console.ReadKey(true);
                    if (!level.CheckFieldState())
                    {
                        break;
                    }

                }
                Console.WriteLine("game over");
                Console.ReadLine();
                Console.Clear();
            }


        }

        public void Reset()
        {
            throw new System.NotImplementedException();
        }

        public void Quit()
        {
            Environment.Exit(0);
        }
    }
}