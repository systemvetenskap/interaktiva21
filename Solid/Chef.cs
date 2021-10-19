using System;
using System.Collections.Generic;
using System.Text;

namespace Solid
{
    class Chef
    {
        public string Name { get; set; }
        public void MakeMeal()
        {

        }

        public void AddIngredient(IEcological ingredient)
        {

        }
    }
    public interface IEcological
    {
        bool IsEcologic { get; set; }
    }
    public interface IHasFrictionTires
    {
        bool IsEcologic { get; set; }
    }
}
