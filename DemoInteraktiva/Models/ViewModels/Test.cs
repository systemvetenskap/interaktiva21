using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoInteraktiva.Models.ViewModels
{
    public abstract class Duck
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Age { get; set; }
        public void Quack()
        {

        }

    }

    public class Toy : Duck
    {
        public bool HasBattery { get; set; }
        public Toy()
        {
            Name = "asdf";
            HasBattery = true;
        }
    }

    public class Food : Duck
    {
    }

    public class ASDasfd : Duck
    {
        public int Special { get; set; }
    }


}
