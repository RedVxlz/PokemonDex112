using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon112
{
    public enum PokemonType
    {
        normal,
        flying,
        electric,
        fire,
        water,
        ground,
        fairy,
        poison
    }

    public class Pokemon
    {
        // class attributes
        protected string Name;
        protected int HP;
        protected int Attack;
        protected int Defense;
        protected int SpecialAttack;
        protected int SpecialDefense;
        protected int Speed;
        protected int Total;
        protected double Height;
        protected double Weight;
        protected string Species;
        protected PokemonType Type;
        protected byte[] image;
        public string ImagePath { get; set; }
        public string GetName() => Name;
        public byte[] GetImage() => image;
        public int GetHP() => HP;
        public int GetAttack() => Attack;
        public int GetDefense() => Defense;
        public int GetSpecialAttack() => SpecialAttack;
        public int GetSpecialDefense() => SpecialDefense;
        public int GetSpeed() => Speed;
        public int GetTotal() => Total;
        public double GetHeight() => Height;
        public double GetWeight() => Weight;
        public string GetSpecies() => Species;
        public PokemonType GetType() => Type;

        public void LoadImage(string path)
        {
            ImagePath = path;
        }
    }
}
