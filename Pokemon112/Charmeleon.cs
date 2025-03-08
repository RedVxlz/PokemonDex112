using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokemon112;

namespace Pokemon112
{
    public class Charmeleon : Pokemon
    {
        //constructor
        //run at first when the object is created
        public Charmeleon()
        {
            this.Type = PokemonType.fire;
            this.Height = 6.9;
            this.Weight = 50.9;
            this.HP = 499;
            this.Attack = 48;
            this.Defense = 40;
            this.SpecialAttack = 40;
            this.SpecialDefense = 80;
            this.Speed = 66;
            this.Total = 740;
            this.Name = "Charmeleon";
            //check if the image in ResourceManager is not null
            //return the image
            var imageObject = Resourcepokemon.ResourceManager.GetObject("charmeleon");
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
