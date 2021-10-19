using System;
using System.Collections.Generic;
using System.Text;

namespace Solid
{
    class GameViewModel
    {
        private readonly IPlayer cpu;

        public IPlayer Human { get; set; } 
       // public IPlayer Cpu { get; set; }

        public GameViewModel(IPlayer player, IPlayer cpu)
        {
            Human = player;
            this.cpu = cpu;
        }
        public void AddPlayer(IPlayer player)
        {

        }
        // här har jag kod för spelare

        // här finns kod för själva spelet
    }
    class PlayerViewModel
    {
        public virtual void Metod()
        {

        }
    }
    class Human : PlayerViewModel, IPlayer
    {
        public string Name { get; set; }
    }
    class Cpu : PlayerViewModel, IPlayer
    {
        public string Name { get; set; }

    }
    public interface IPlayer
    {
        string Name { get; set; }
    }

}
