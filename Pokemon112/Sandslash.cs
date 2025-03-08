using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokemon112.Properties;
using Pokemon112;

namespace Pokemon112
{
    public class Sandslash : Pokemon
    {
        //constructor
        //run at first when the object is created
        public Sandslash()
        {
            this.Type = PokemonType.ground;
            this.Height = 5.0;
            this.Weight = 30.0;
            this.HP = 90;
            this.Attack = 30;
            this.Defense = 80;
            this.SpecialAttack = 40;
            this.SpecialDefense = 36;
            this.Speed = 30;
            this.Total = 312;
            this.Name = "Sandslash";
            //check if the image in ResourceManager is not null
            //return the image
            var imageObject = Resourcepokemon.ResourceManager.GetObject("sandslash");
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
