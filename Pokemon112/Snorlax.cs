using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokemon112;
using Pokemon112.Properties;

namespace Pokemon112
{
    class Snorlax : Pokemon
    {
        public Snorlax()
        {
            this.Type = PokemonType.normal;
            this.Height = 2.1;
            this.Weight = 460.0;
            this.HP = 160;
            this.Attack = 110;
            this.Defense = 65;
            this.SpecialAttack = 65;
            this.SpecialDefense = 110;
            this.Speed = 30;
            this.Total = 540;
            this.Name = "Snorlax";
            //check if the image in ResourceManager is not null
            //return the image
            var imageObject = Resourcepokemon.ResourceManager.GetObject("snorlax");
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
