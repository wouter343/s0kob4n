using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class GameController
    {
        private Player Speler;
        private Level level;
        private GameView gameview;

        public GameController()
        {
            level = new Level();
            gameview = new GameView();
            gameview.PrintField(level.field);
        }

        public Player Player
        {
            get => default(Player);
            set
            {
            }
        }

        public Level Level
        {
            get => default(Level);
            set
            {
            }
        }

        public GameView GameView
        {
            get => default(GameView);
            set
            {
            }
        }

        public int Colleague
        {
            get => default(int);
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
            throw new System.NotImplementedException();
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