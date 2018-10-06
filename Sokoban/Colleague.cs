using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Colleague : Player
    {

        public Colleague(Level level) :base(level)
        {

        }
        public int Sleeps
        {
            get => default(int);
            set
            {
            }
        }

        public void ChangeState()
        {
            throw new System.NotImplementedException();
        }

        public void GenerateMove()
        {
            throw new System.NotImplementedException();
        }

        public void _checkMove()
        {
            throw new System.NotImplementedException();
        }
    }
}