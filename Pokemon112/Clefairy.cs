using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokemon112.Properties;
using Pokemon112;

namespace Pokemon112
{
    public class Clefairy : Pokemon
    {
        //constructor
        //run at first when the object is created
        public Clefairy()
        {
            this.Type = PokemonType.fairy;
            this.Height = 6.0;
            this.Weight = 41.9;
            this.HP = 49;
            this.Attack = 59;
            this.Defense = 40;
            this.SpecialAttack = 60;
            this.SpecialDefense = 41;
            this.Speed = 68;
            this.Total = 340;
            this.Name = "Clefairy";
            //check if the image in ResourceManager is not null
            //return the image
            var imageObject = Resourcepokemon.ResourceManager.GetObject("clefairy");
            if (imageObject != null)
            {
                this.image = (byte[])imageObject;
            }
            else
            {
                this.image = Array.Empty<byte>();
            }
        }
    }
}
